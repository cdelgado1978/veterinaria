using System;

namespace Veterinaria.Modelo.DTO
{
    public class CotizacionesDTO
    {


        public int Id { get;  set; }
        public DateTime Fecha { get;  set; }
        public int EmpleadoId { get;  set; }
        public int ClienteId { get;  set; }
        public int ProductoId { get;  set; }
        public int TipoProductoId { get;  set; }
        public decimal Precio { get;  set; }
        public int Cantidad { get;  set; }
        public decimal? Descuento { get;  set; }
        public decimal? SubTotal { get;  set; }
        public decimal? Total { get;  set; }
        public bool Inactivo { get;  set; }
    }
}