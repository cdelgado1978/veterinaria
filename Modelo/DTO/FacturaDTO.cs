namespace Veterinaria.Modelo.DTO
{
    public class FacturaDTO
    {
        public int Id { get;  set; }
        public int CategoriaId { get;  set; }
        public object Fecha { get;  set; }
        public int TipoFactura { get;  set; }
        public int EmpleadoId { get;  set; }
        public int ClienteId { get;  set; }
        public object ProductoId { get;  set; }
        public object Descripcion { get;  set; }
        public object Cantidad { get;  set; }
        public object Precio { get;  set; }
        public object Descuento { get;  set; }
        public decimal SubTotal { get;  set; }
        public decimal Total { get;  set; }
        public bool Inactivo { get;  set; }
    }
}