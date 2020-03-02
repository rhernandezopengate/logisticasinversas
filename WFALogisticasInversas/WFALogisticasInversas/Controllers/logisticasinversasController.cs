using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WFALogisticasInversas.Modelo;

namespace WFALogisticasInversas.Controllers
{
    public class logisticasinversasController
    {
        DB_A3F19C_OpenGateEntities db = new DB_A3F19C_OpenGateEntities();

        public bool AgregarLogistica(logisticainversa model)
        {
            try
            {
                db.logisticainversa.Add(model);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message.ToString());
                return false;
            }
        }

        public bool AgregarTarimas(tarimas model) 
        {
            try
            {
                db.tarimas.Add(model);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message.ToString());
                return false;
            }        
        }

        public bool AgregarDetalleTarima(dettarimasskus model) 
        {
            try
            {
                db.dettarimasskus.Add(model);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message.ToString());
                return false;
            }        
        }
    }
}
