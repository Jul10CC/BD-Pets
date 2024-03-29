//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MODELS
{
    using System;
    using System.Collections.Generic;
    
    public partial class Factura
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Factura()
        {
            this.Detalle = new HashSet<Detalle>();
            this.DetalleMetodoPago = new HashSet<DetalleMetodoPago>();
        }
    
        public int FacturaID { get; set; }
        public Nullable<int> ClienteID { get; set; }
        public Nullable<int> EmpleadoID { get; set; }
        public System.DateTime Fecha_Factura { get; set; }
        public bool Estado { get; set; }
        public decimal Total { get; set; }
    
        public virtual Cliente Cliente { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Detalle> Detalle { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DetalleMetodoPago> DetalleMetodoPago { get; set; }
        public virtual Empleado Empleado { get; set; }
    }
}
