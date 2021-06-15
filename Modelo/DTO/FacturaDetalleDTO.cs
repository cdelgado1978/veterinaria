using System;

namespace Veterinaria.Modelo.DTO
{
    public class FacturaDetalleDTO
    {
        public int Id { get; set; }
        public int FacturaId { get; set; }
        public DateTime Fecha { get; set; }
        public int EmpleadoId { get; set; }
        public int ProductoId { get; set; }
        public int TipoProducto { get; set; }
        public decimal Precio { get; set; }
        public int Cantidad { get; set; }
        public object Descuento { get; set; }
        public decimal SubTotal { get; set; }
        public decimal Total { get; set; }
        public bool Inactivo { get; set; }
    }
}