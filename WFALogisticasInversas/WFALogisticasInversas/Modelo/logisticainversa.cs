//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WFALogisticasInversas.Modelo
{
    using System;
    using System.Collections.Generic;
    
    public partial class logisticainversa
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public logisticainversa()
        {
            this.tarimas = new HashSet<tarimas>();
        }
    
        public int id { get; set; }
        public string Folio { get; set; }
        public Nullable<System.DateTime> FechaAlta { get; set; }
        public int origenlogistica_id { get; set; }
        public int statuslogisticasinversas_Id { get; set; }
    
        public virtual origenlogistica origenlogistica { get; set; }
        public virtual statuslogisticasinversas statuslogisticasinversas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tarimas> tarimas { get; set; }
    }
}
