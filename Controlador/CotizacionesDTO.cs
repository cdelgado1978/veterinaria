using System;

namespace Veterinaria.Controlador
{
    public class CotizacionesDTO
    {
      

        public int Id { get; internal set; }
        public DateTime Fecha { get; internal set; }
        public int EmpleadoId { get; internal set; }
        public int ClienteId { get; internal set; }
        public int ProductoId { get; internal set; }
        public int TipoProductoId { get; internal set; }
        public decimal Precio { get; internal set; }
        public int Cantidad { get; internal set; }
        public decimal? Descuento { get; internal set; }
        public decimal? SubTotal { get; internal set; }
        public decimal? Total { get; internal set; }
        public bool Inactivo { get; internal set; }
    }
}