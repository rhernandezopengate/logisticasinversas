using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFALogisticasInversas.Modelo;
using WFALogisticasInversas.ViewModel;
using WFALogisticasInversas.Controllers;
using System.Drawing.Printing;

namespace WFALogisticasInversas
{
    public partial class LogisticaInversa : Form
    {
        DB_A3F19C_OpenGateEntities db = new DB_A3F19C_OpenGateEntities();
        logisticasinversasController ctrl = new logisticasinversasController();
        List<CantidadesTarima> listaGrid;

        public LogisticaInversa()
        {
            InitializeComponent();
        }

        private void LogisticaInversa_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsOrigenLogistica.origenlogistica' Puede moverla o quitarla según sea necesario.
            this.origenlogisticaTableAdapter.Fill(this.dsOrigenLogistica.origenlogistica);
            txtSKU.KeyPress += new KeyPressEventHandler(keypressed);
        }

        private void btnAgregarLogistica_Click(object sender, EventArgs e)
        {
            AgregarLogistica();
        }

        private void btnCerrarTarima_Click(object sender, EventArgs e)
        {
            if (lblStatusLogistica.Text.Equals("LOGISTICA ACTUAL"))
            {
                MessageBox.Show("NO HA SELECCIONADO NINGUNA LOGISTICA");
            }
            else
            {
                string respuesta = Microsoft.VisualBasic.Interaction.InputBox("DESEA AGREGAR UNA NUEVA TARIMA \n\n SI -> (Y) \n\n NO -> (N)", "CERRANDO TARIMA");

                if (respuesta.ToUpper().Equals("Y"))
                {
                    AgregarDetTarimaSku();
                    AgregarTarima();
                    listaGrid = new List<CantidadesTarima>();
                    dgvItems.DataSource = null;
                    this.txtSKU.Focus();

                }
                else if (respuesta.ToUpper().Equals("N"))
                {
                    AgregarDetTarimaSku();
                    MessageBox.Show("INFORMACION DE TARIMA GUARDADA CORRECTAMENTE");

                    string respuestalogistica = Microsoft.VisualBasic.Interaction.InputBox("DESEA CERRAR LA LOGISTICA INVERSA \n\n SI -> (Y) \n\n NO -> (N)", "CERRAR LOGISTICA INVERSA");

                    if (respuestalogistica.ToUpper().Equals("Y"))
                    {
                        logisticainversa logistica = db.logisticainversa.Where(x => x.Folio.Equals(this.lblStatusLogistica.Text)).FirstOrDefault();
                        logistica.statuslogisticasinversas_Id = 2;

                        db.SaveChanges();                        
                    }
                    else if (respuestalogistica.ToUpper().Equals("N"))
                    {
                        MessageBox.Show("ESTA LOGISTICA INVERSA CONTINUA ABIERTA");                        
                    }
                    else if (respuestalogistica.Equals(string.Empty))
                    {
                        MessageBox.Show("NO SE REALIZO NINGUNA ACCION");
                    }
                    Limpiar();
                }
                else if (respuesta.Equals(string.Empty))
                {
                    MessageBox.Show("NO SE REALIZO NINGUNA ACCION");
                }
            }
        }
        
        private void btnConsultarLogistica_Click(object sender, EventArgs e)
        {
            string codigologistica = Microsoft.VisualBasic.Interaction.InputBox("COLOQUE EL NUMERO DE LA LOGISTICA QUE DESEA CONTINUAR", "BUSCAR LOGISTICA");
            
            var logistica = db.logisticainversa.Where(x => x.Folio.Equals(codigologistica.ToUpper().Trim())).FirstOrDefault();

            if (logistica == null)
            {
                MessageBox.Show("NO SE EXISTE ESTA LOGISTICA INVERSA INTENTE OTRA VEZ");
            }
            else
            {
                if (logistica.statuslogisticasinversas_Id == 2)
                {
                    MessageBox.Show("ESTA LOGISTICA SE ENCUENTRA CERRADA INTENTE CON OTRA");
                }
                else
                {
                    bool valor = false;

                    cbOrigen.SelectedValue = logistica.origenlogistica_id;
                    dtpFechaAlta.Value = (DateTime)logistica.FechaAlta;
                    cbOrigen.Enabled = false;
                    dtpFechaAlta.Enabled = false;
                    lblTipoLogistica.Text = "CONTINUACION";
                    lblStatusLogistica.Text = logistica.Folio;
                    txtSKU.Enabled = true; 

                    do
                    {
                        string codigotarima = Microsoft.VisualBasic.Interaction.InputBox("COLOQUE EL NUMERO DE LA TARIMA QUE DESEA CONTINUAR \n\n (N) -> SALIR", "BUSCAR TARIMA");

                        if (codigotarima.ToUpper().Trim().Equals("N"))
                        {
                            valor = false;
                        }
                        else
                        {
                            var tarima = db.tarimas.Where(x => x.Folio.Equals(codigotarima)).FirstOrDefault();

                            if (tarima == null)
                            {
                                MessageBox.Show("ESTA TARIMA NO EXISTE");
                                valor = false;
                            }
                            else
                            {
                                lblStatusTarima.Text = codigotarima;
                                listaGrid = new List<CantidadesTarima>();
                                int folio = 1;

                                var dettarimassku = db.dettarimasskus.Where(x => x.tarimas_Id.Equals(tarima.id)).ToList();

                                foreach (var item in dettarimassku)
                                {
                                    CantidadesTarima cantidadSKU = new CantidadesTarima();

                                    cantidadSKU.folio += folio++;
                                    cantidadSKU.sku = item.skus.codigobarras;
                                    cantidadSKU.cantidad = (int)item.Cantidad;
                                    cantidadSKU.codigotarima = codigotarima;

                                    listaGrid.Add(cantidadSKU);
                                }

                                var listafinal = listaGrid.OrderByDescending(x => x.folio);
                                dgvItems.DataSource = null;
                                dgvItems.AutoGenerateColumns = false;
                                dgvItems.DataSource = listafinal.ToList();
                                txtSKU.Focus();
                                valor = true;
                            }
                        }
                    } while (valor.Equals(false));
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        public void AgregarDetTarimaSku()
        {
            try
            {
                if (lblTipoLogistica.Text.Equals("CONTINUACION"))
                {
                    foreach (var item in listaGrid)
                    {
                        int idsku = db.skus.Where(x => x.codigobarras.Equals(item.sku)).FirstOrDefault().id;
                        int idtarima = db.tarimas.Where(x => x.Folio.Equals(this.lblStatusTarima.Text)).FirstOrDefault().id;
                        var dettarimassku = db.dettarimasskus.Where(x => x.skus_Id.Equals(idsku) && x.tarimas_Id.Equals(idtarima)).FirstOrDefault();

                        if (dettarimassku != null)
                        {
                            dettarimassku.Cantidad = item.cantidad;
                            db.SaveChanges();
                        }
                        else
                        {
                            dettarimasskus dettarimasskutemp = new dettarimasskus();
                            dettarimasskutemp.skus_Id = db.skus.Where(x => x.codigobarras.Equals(item.sku)).FirstOrDefault().id;
                            dettarimasskutemp.tarimas_Id = db.tarimas.Where(x => x.Folio.Equals(this.lblStatusTarima.Text)).FirstOrDefault().id;
                            dettarimasskutemp.Cantidad = item.cantidad;

                            if (!ctrl.AgregarDetalleTarima(dettarimasskutemp))
                            {
                                Error("Ha ocurrido un error: \n\n CONTINUAR -> (OK)", "ERROR AGREGAR DETALLE TARIMA");
                            }
                        }
                    }
                }
                else
                {
                    foreach (var item in listaGrid)
                    {
                        dettarimasskus dettarimasskus = new dettarimasskus();

                        dettarimasskus.skus_Id = db.skus.Where(x => x.codigobarras.Equals(item.sku)).FirstOrDefault().id;
                        dettarimasskus.tarimas_Id = db.tarimas.Where(x => x.Folio.Equals(this.lblStatusTarima.Text)).FirstOrDefault().id;
                        dettarimasskus.Cantidad = item.cantidad;

                        if (!ctrl.AgregarDetalleTarima(dettarimasskus))
                        {
                            Error("Ha ocurrido un error: \n\n CONTINUAR -> (OK)", "ERROR AGREGAR DETALLE TARIMA");
                        }                        
                    }
                }

                lblTipoLogistica.Text = "TIPO";
            }
            catch (Exception ex)
            {
                Error("Error:" + ex.Message.ToString() + " \n\n CONTINUAR -> (OK)", "ERROR AGREGAR DETALLE TARIMA");
            }
        }

        public void AgregarLogistica()
        {
            try
            {
                int idorigen = Convert.ToInt32(this.cbOrigen.SelectedValue);
                this.lblOrigen.Text = db.origenlogistica.Find(idorigen).descripcion;

                int conteologistica = db.logisticainversa.Count() + 1;
                string foliologistica = "OGLI-" + this.lblOrigen.Text.Replace(" ", "").Trim() + "-" + conteologistica;
                
                logisticainversa logistica = new logisticainversa();

                logistica.FechaAlta = this.dtpFechaAlta.Value;
                logistica.Folio = foliologistica;
                logistica.statuslogisticasinversas_Id = 1;
                logistica.origenlogistica_id = idorigen;

                if (ctrl.AgregarLogistica(logistica))
                {
                    this.lblStatusLogistica.Text = foliologistica;
                    this.cbOrigen.Enabled = false;
                    this.dtpFechaAlta.Enabled = false;
                    this.txtSKU.Enabled = true;

                    AgregarTarima();                    
                }
                else
                {
                    Error("HA OCURRIDO UN ERROR:" + " \n\n CONTINUAR -> (OK)", "ERROR AGREGAR LOGISTICA");
                }                
            }
            catch (Exception ex)
            {
                Error("Error:" + ex.Message.ToString() + " \n\n CONTINUAR -> (OK)", "ERROR AGREGAR LOGISTICA");                
            }
        }

        public void AgregarTarima() 
        {
            tarimas tarimas = new tarimas();
            logisticainversa logisticaTemp = db.logisticainversa.Where(x => x.Folio.Equals(this.lblStatusLogistica.Text)).FirstOrDefault();
            int conteotarima = db.tarimas.Where(x => x.logisticainversa_Id.Equals(logisticaTemp.id)).Count() + 1;

            string foliotarima = this.lblStatusLogistica.Text.Trim() + "-P" + conteotarima;
            tarimas.Folio = foliotarima;
            tarimas.logisticainversa_Id = logisticaTemp.id;
            tarimas.statustarimas_Id = 1;

            if (ctrl.AgregarTarimas(tarimas))
            {
                this.lblStatusTarima.Text = foliotarima;
                txtSKU.Text = string.Empty;
                txtSKU.Focus();
                listaGrid = new List<CantidadesTarima>();
                Printing();
            }
            else
            {
                Error("HA OCURRIDO UN ERROR:" + " \n\n CONTINUAR -> (OK)", "ERROR AGREGAR TARIMA");
            }
        }

        public bool AgregarItem(string sku)
        {
            try
            {
                var skutemp = db.skus.Where(x => x.codigobarras.Equals(sku)).FirstOrDefault();
                var skubenavides = db.skusbenavides.Where(x => x.codigobarras.Equals(sku)).FirstOrDefault();

                if (skutemp == null && skubenavides == null)
                {
                    Error("SKU NO EXISTE \n\n CONTINUAR -> (OK)", "ERROR SKU");
                    txtSKU.Text = string.Empty;
                    txtSKU.Focus();
                }
                else
                {
                    if (skutemp != null)
                    {
                        var skuinventarios = db.skusinventarios.Where(x => x.skus_Id == skutemp.id).FirstOrDefault();

                        int cantidad = 0;
                        if (skuinventarios.qtymanual.Equals("N"))
                        {
                            cantidad = 1;
                        }
                        else
                        {
                            cantidad = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("TECLEA LA CANTIDAD DE ESTE SKU", "CANTIDAD MANUAL"));
                        }

                        CantidadesTarima cantidadSKU = new CantidadesTarima();
                        var skuexistente = listaGrid.Where(x => x.sku.Equals(sku)).FirstOrDefault();

                        if (skuexistente != null)
                        {
                            skuexistente.cantidad += cantidad;
                        }
                        else
                        {
                            cantidadSKU.folio = listaGrid.Count() + 1;
                            cantidadSKU.sku = skutemp.SKU.Trim();
                            cantidadSKU.cantidad = cantidad;
                            cantidadSKU.codigotarima = this.lblTarima.Text;
                            listaGrid.Add(cantidadSKU);
                        }
                    }
                    else
                    {
                        var skuinventarios = db.skusinventarios.Where(x => x.skus_Id.Equals(skubenavides.skus_Id)).FirstOrDefault();

                        int cantidad = 0;
                        if (skuinventarios.qtymanual.Equals("N"))
                        {
                            cantidad = 1;
                        }
                        else
                        {
                            cantidad = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("TECLEA LA CANTIDAD DE ESTE SKU", "CANTIDAD MANUAL"));
                        }

                        CantidadesTarima cantidadSKU = new CantidadesTarima();
                        string skuben = skubenavides.skus.SKU.Trim();
                        var skuexistente = listaGrid.Where(x => x.sku.Equals(skuben)).FirstOrDefault();

                        if (skuexistente != null)
                        {
                            skuexistente.cantidad += cantidad;
                        }
                        else
                        {
                            cantidadSKU.folio = listaGrid.Count() + 1;
                            cantidadSKU.sku = skubenavides.skus.SKU.Trim();
                            cantidadSKU.cantidad = cantidad;
                            cantidadSKU.codigotarima = this.lblTarima.Text;
                            listaGrid.Add(cantidadSKU);
                        }
                    }
                } 

                var listafinal = listaGrid.OrderByDescending(x => x.folio);
                dgvItems.DataSource = null;
                dgvItems.AutoGenerateColumns = false;
                dgvItems.DataSource = listafinal.ToList();
                txtSKU.Text = string.Empty;
                txtSKU.Focus();

                return true;
            }
            catch (Exception ex)
            {
                Error("Error: " + ex.Message.ToString() + " \n\n CONTINUAR -> (OK)", "ERROR SKU");
                return false;                
            }
        }
               
        private void keypressed(Object o, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (this.txtSKU.Text.Equals(string.Empty))
                {
                    Error("NO PUEDE AGREGAR UN VALOR VACIO \n\n CONTINUAR -> (OK)", "ERROR SKU");
                }
                else
                {
                    string sku = this.txtSKU.Text.ToUpper();
                    AgregarItem(sku);
                }

                e.Handled = true;
            }
        }

        public void Limpiar()
        {
            this.txtSKU.Enabled = false;
            this.txtSKU.Text = string.Empty;
            this.lblOrigen.Text = string.Empty;
            this.cbOrigen.Enabled = true;
            this.lblStatusLogistica.Text = "LOGISTICA ACTUAL";
            this.lblStatusTarima.Text = "TARIMA ACTUAL";
            //this.lblTipoLogistica.Text = "TIPO";
            this.lblOrigen.Text = "ORIGEN";
            this.dtpFechaAlta.Enabled = true;
            listaGrid = null;
            dgvItems.DataSource = null;
            listaGrid = new List<CantidadesTarima>();
        }

        private void Error(string error, string encabezado)
        {
            string respuesta;
            do
            {
                SystemSounds.Hand.Play();
                respuesta = Microsoft.VisualBasic.Interaction.InputBox(error, encabezado);
            } while (respuesta.ToUpper().Trim() != "OK");
        }

        public void Printing()
        {
            try
            {
                PrintDocument pd = new PrintDocument();

                pd.PrintPage += new PrintPageEventHandler(documentoAimprimir);
                // Especifica que impresora se utilizara!!
                pd.PrinterSettings.PrinterName = "ZDesigner ZT410-203dpi ZPL";
                PageSettings pa = new PageSettings();
                pa.Margins = new Margins(0, 0, 0, 0);
                pd.DefaultPageSettings.Margins = pa.Margins;
                PaperSize ps = new PaperSize("Custom", 2500, 800);

                pd.DefaultPageSettings.PaperSize = ps;
                pd.DefaultPageSettings.Landscape = true;

                pd.Print();
            }
            catch (Exception exp)
            {
                MessageBox.Show("Printing " + exp.Message);
            }
        }

        private void documentoAimprimir(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try
            {

                Zen.Barcode.Code128BarcodeDraw barcode = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;

                var barcodeImage = barcode.Draw(this.lblStatusTarima.Text, 100);

                Font font14 = new Font("Arial", 25);

                float leading = 60;

                float startX = 0;
                float startY = leading;
                float Offset = 0;

                float lineheight14 = font14.GetHeight() + leading;

                SizeF layoutSize = new SizeF(780 - Offset * 2, lineheight14);
                RectangleF layout = new RectangleF(new PointF(startX, startY + Offset), layoutSize);

                Graphics g = e.Graphics;

                Brush brush = Brushes.Black;

                StringFormat formatLeft = new StringFormat(StringFormatFlags.NoClip);
                StringFormat formatCenter = new StringFormat(formatLeft);
                formatCenter.Alignment = StringAlignment.Center;

                g.DrawString(this.lblStatusTarima.Text + "\n", font14, brush, layout, formatCenter);

                g.DrawImage(barcodeImage, 130, 150, 500, 150);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Printpage" + ex.Message);
            }
        }
    }
}
