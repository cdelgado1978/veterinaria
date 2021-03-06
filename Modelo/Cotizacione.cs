//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Veterinaria.Modelo
{
    using System;
    using System.Collections.Generic;
    
    public partial class Cotizacione
    {
        public int ID { get; set; }
        public System.DateTime fecha { get; set; }
        public int EmpleadoID { get; set; }
        public int ClienteID { get; set; }
        public int ProductoID { get; set; }
        public int TipoProductoID { get; set; }
        public decimal Precio { get; set; }
        public int Cantidad { get; set; }
        public Nullable<decimal> Descuento { get; set; }
        public Nullable<decimal> SubTotal { get; set; }
        public Nullable<decimal> Total { get; set; }
        public bool Inactivo { get; set; }
    
        public virtual Cliente Cliente { get; set; }
        public virtual Empleado Empleado { get; set; }
        public virtual Producto Producto { get; set; }
    }
}
