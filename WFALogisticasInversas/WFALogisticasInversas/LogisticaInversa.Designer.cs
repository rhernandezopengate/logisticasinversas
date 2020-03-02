namespace WFALogisticasInversas
{
    partial class LogisticaInversa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogisticaInversa));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dtpFechaAlta = new System.Windows.Forms.DateTimePicker();
            this.cbOrigen = new System.Windows.Forms.ComboBox();
            this.origenlogisticaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsOrigenLogisticaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsOrigenLogistica = new WFALogisticasInversas.DataSets.dsOrigenLogistica();
            this.lblOrigen = new System.Windows.Forms.Label();
            this.lblFechaAlta = new System.Windows.Forms.Label();
            this.lblLogistica = new System.Windows.Forms.Label();
            this.lblStatusLogistica = new System.Windows.Forms.Label();
            this.lblTarima = new System.Windows.Forms.Label();
            this.lblStatusTarima = new System.Windows.Forms.Label();
            this.lblSKU = new System.Windows.Forms.Label();
            this.txtSKU = new System.Windows.Forms.TextBox();
            this.dgvItems = new System.Windows.Forms.DataGridView();
            this.origenlogisticaTableAdapter = new WFALogisticasInversas.DataSets.dsOrigenLogisticaTableAdapters.origenlogisticaTableAdapter();
            this.btnAgregarLogistica = new System.Windows.Forms.Button();
            this.btnCerrarTarima = new System.Windows.Forms.Button();
            this.btnConsultarLogistica = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.lblTipoLogistica = new System.Windows.Forms.Label();
            this.folio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sku = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.origenlogisticaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsOrigenLogisticaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsOrigenLogistica)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.80182F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.19818F));
            this.tableLayoutPanel1.Controls.Add(this.dtpFechaAlta, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.cbOrigen, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblOrigen, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblFechaAlta, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblLogistica, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblStatusLogistica, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblTarima, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblStatusTarima, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblSKU, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtSKU, 1, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.25373F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.74627F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(432, 155);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dtpFechaAlta
            // 
            this.dtpFechaAlta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaAlta.Location = new System.Drawing.Point(144, 37);
            this.dtpFechaAlta.Name = "dtpFechaAlta";
            this.dtpFechaAlta.Size = new System.Drawing.Size(279, 26);
            this.dtpFechaAlta.TabIndex = 0;
            // 
            // cbOrigen
            // 
            this.cbOrigen.DataSource = this.origenlogisticaBindingSource;
            this.cbOrigen.DisplayMember = "descripcion";
            this.cbOrigen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOrigen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbOrigen.FormattingEnabled = true;
            this.cbOrigen.Location = new System.Drawing.Point(144, 3);
            this.cbOrigen.Name = "cbOrigen";
            this.cbOrigen.Size = new System.Drawing.Size(279, 28);
            this.cbOrigen.TabIndex = 1;
            this.cbOrigen.ValueMember = "id";
            // 
            // origenlogisticaBindingSource
            // 
            this.origenlogisticaBindingSource.DataMember = "origenlogistica";
            this.origenlogisticaBindingSource.DataSource = this.dsOrigenLogisticaBindingSource;
            // 
            // dsOrigenLogisticaBindingSource
            // 
            this.dsOrigenLogisticaBindingSource.DataSource = this.dsOrigenLogistica;
            this.dsOrigenLogisticaBindingSource.Position = 0;
            // 
            // dsOrigenLogistica
            // 
            this.dsOrigenLogistica.DataSetName = "dsOrigenLogistica";
            this.dsOrigenLogistica.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblOrigen
            // 
            this.lblOrigen.AutoSize = true;
            this.lblOrigen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrigen.Location = new System.Drawing.Point(3, 0);
            this.lblOrigen.Name = "lblOrigen";
            this.lblOrigen.Size = new System.Drawing.Size(83, 24);
            this.lblOrigen.TabIndex = 2;
            this.lblOrigen.Text = "ORIGEN";
            // 
            // lblFechaAlta
            // 
            this.lblFechaAlta.AutoSize = true;
            this.lblFechaAlta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaAlta.Location = new System.Drawing.Point(3, 34);
            this.lblFechaAlta.Name = "lblFechaAlta";
            this.lblFechaAlta.Size = new System.Drawing.Size(128, 24);
            this.lblFechaAlta.TabIndex = 3;
            this.lblFechaAlta.Text = "FECHA ALTA";
            // 
            // lblLogistica
            // 
            this.lblLogistica.AutoSize = true;
            this.lblLogistica.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogistica.Location = new System.Drawing.Point(3, 69);
            this.lblLogistica.Name = "lblLogistica";
            this.lblLogistica.Size = new System.Drawing.Size(107, 24);
            this.lblLogistica.TabIndex = 4;
            this.lblLogistica.Text = "LOGISTICA";
            // 
            // lblStatusLogistica
            // 
            this.lblStatusLogistica.AutoSize = true;
            this.lblStatusLogistica.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusLogistica.Location = new System.Drawing.Point(144, 69);
            this.lblStatusLogistica.Name = "lblStatusLogistica";
            this.lblStatusLogistica.Size = new System.Drawing.Size(162, 20);
            this.lblStatusLogistica.TabIndex = 5;
            this.lblStatusLogistica.Text = "LOGISTICA ACTUAL";
            // 
            // lblTarima
            // 
            this.lblTarima.AutoSize = true;
            this.lblTarima.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTarima.Location = new System.Drawing.Point(3, 98);
            this.lblTarima.Name = "lblTarima";
            this.lblTarima.Size = new System.Drawing.Size(81, 24);
            this.lblTarima.TabIndex = 6;
            this.lblTarima.Text = "TARIMA";
            // 
            // lblStatusTarima
            // 
            this.lblStatusTarima.AutoSize = true;
            this.lblStatusTarima.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusTarima.Location = new System.Drawing.Point(144, 98);
            this.lblStatusTarima.Name = "lblStatusTarima";
            this.lblStatusTarima.Size = new System.Drawing.Size(137, 20);
            this.lblStatusTarima.TabIndex = 7;
            this.lblStatusTarima.Text = "TARIMA ACTUAL";
            // 
            // lblSKU
            // 
            this.lblSKU.AutoSize = true;
            this.lblSKU.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSKU.Location = new System.Drawing.Point(3, 123);
            this.lblSKU.Name = "lblSKU";
            this.lblSKU.Size = new System.Drawing.Size(47, 24);
            this.lblSKU.TabIndex = 8;
            this.lblSKU.Text = "SKU";
            // 
            // txtSKU
            // 
            this.txtSKU.Enabled = false;
            this.txtSKU.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSKU.Location = new System.Drawing.Point(144, 126);
            this.txtSKU.Name = "txtSKU";
            this.txtSKU.Size = new System.Drawing.Size(279, 26);
            this.txtSKU.TabIndex = 9;
            // 
            // dgvItems
            // 
            this.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.folio,
            this.cantidad,
            this.sku});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Black", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvItems.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvItems.Location = new System.Drawing.Point(450, 15);
            this.dgvItems.Name = "dgvItems";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvItems.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvItems.Size = new System.Drawing.Size(614, 764);
            this.dgvItems.TabIndex = 1;
            // 
            // origenlogisticaTableAdapter
            // 
            this.origenlogisticaTableAdapter.ClearBeforeFill = true;
            // 
            // btnAgregarLogistica
            // 
            this.btnAgregarLogistica.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAgregarLogistica.BackgroundImage")));
            this.btnAgregarLogistica.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgregarLogistica.Location = new System.Drawing.Point(12, 190);
            this.btnAgregarLogistica.Name = "btnAgregarLogistica";
            this.btnAgregarLogistica.Size = new System.Drawing.Size(99, 89);
            this.btnAgregarLogistica.TabIndex = 2;
            this.btnAgregarLogistica.UseVisualStyleBackColor = true;
            this.btnAgregarLogistica.Click += new System.EventHandler(this.btnAgregarLogistica_Click);
            // 
            // btnCerrarTarima
            // 
            this.btnCerrarTarima.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCerrarTarima.BackgroundImage")));
            this.btnCerrarTarima.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCerrarTarima.Location = new System.Drawing.Point(117, 190);
            this.btnCerrarTarima.Name = "btnCerrarTarima";
            this.btnCerrarTarima.Size = new System.Drawing.Size(96, 89);
            this.btnCerrarTarima.TabIndex = 3;
            this.btnCerrarTarima.UseVisualStyleBackColor = true;
            this.btnCerrarTarima.Click += new System.EventHandler(this.btnCerrarTarima_Click);
            // 
            // btnConsultarLogistica
            // 
            this.btnConsultarLogistica.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnConsultarLogistica.BackgroundImage")));
            this.btnConsultarLogistica.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConsultarLogistica.Location = new System.Drawing.Point(227, 190);
            this.btnConsultarLogistica.Name = "btnConsultarLogistica";
            this.btnConsultarLogistica.Size = new System.Drawing.Size(99, 89);
            this.btnConsultarLogistica.TabIndex = 4;
            this.btnConsultarLogistica.UseVisualStyleBackColor = true;
            this.btnConsultarLogistica.Click += new System.EventHandler(this.btnConsultarLogistica_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLimpiar.BackgroundImage")));
            this.btnLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLimpiar.Location = new System.Drawing.Point(332, 190);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(103, 89);
            this.btnLimpiar.TabIndex = 5;
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // lblTipoLogistica
            // 
            this.lblTipoLogistica.AutoSize = true;
            this.lblTipoLogistica.Location = new System.Drawing.Point(19, 304);
            this.lblTipoLogistica.Name = "lblTipoLogistica";
            this.lblTipoLogistica.Size = new System.Drawing.Size(32, 13);
            this.lblTipoLogistica.TabIndex = 6;
            this.lblTipoLogistica.Text = "TIPO";
            this.lblTipoLogistica.Visible = false;
            // 
            // folio
            // 
            this.folio.DataPropertyName = "folio";
            this.folio.HeaderText = "Folio";
            this.folio.Name = "folio";
            this.folio.Width = 190;
            // 
            // cantidad
            // 
            this.cantidad.DataPropertyName = "cantidad";
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.Name = "cantidad";
            this.cantidad.Width = 190;
            // 
            // sku
            // 
            this.sku.DataPropertyName = "sku";
            this.sku.HeaderText = "SKU";
            this.sku.Name = "sku";
            this.sku.Width = 190;
            // 
            // LogisticaInversa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 784);
            this.Controls.Add(this.lblTipoLogistica);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnConsultarLogistica);
            this.Controls.Add(this.btnCerrarTarima);
            this.Controls.Add(this.btnAgregarLogistica);
            this.Controls.Add(this.dgvItems);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "LogisticaInversa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LogisticaInversa";
            this.Load += new System.EventHandler(this.LogisticaInversa_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.origenlogisticaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsOrigenLogisticaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsOrigenLogistica)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DateTimePicker dtpFechaAlta;
        private System.Windows.Forms.ComboBox cbOrigen;
        private System.Windows.Forms.Label lblOrigen;
        private System.Windows.Forms.Label lblFechaAlta;
        private System.Windows.Forms.Label lblLogistica;
        private System.Windows.Forms.Label lblStatusLogistica;
        private System.Windows.Forms.Label lblTarima;
        private System.Windows.Forms.Label lblStatusTarima;
        private System.Windows.Forms.Label lblSKU;
        private System.Windows.Forms.TextBox txtSKU;
        private System.Windows.Forms.DataGridView dgvItems;
        private System.Windows.Forms.BindingSource dsOrigenLogisticaBindingSource;
        private DataSets.dsOrigenLogistica dsOrigenLogistica;
        private System.Windows.Forms.BindingSource origenlogisticaBindingSource;
        private DataSets.dsOrigenLogisticaTableAdapters.origenlogisticaTableAdapter origenlogisticaTableAdapter;
        private System.Windows.Forms.Button btnAgregarLogistica;
        private System.Windows.Forms.Button btnCerrarTarima;
        private System.Windows.Forms.Button btnConsultarLogistica;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label lblTipoLogistica;
        private System.Windows.Forms.DataGridViewTextBoxColumn folio;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn sku;
    }
}