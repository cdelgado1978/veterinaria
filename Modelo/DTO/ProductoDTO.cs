namespace Veterinaria.Modelo.DTO
{
    public class ProductoDto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int TipoProductoId { get; set; }

        public string TipoProductoNombre { get; set; }
        public string Descripcion { get; set; }
        public int ProveedorId { get; set; }

        public string ProveedorNombre { get; set; }
        public decimal Costo { get; set; }
        public decimal Precio { get; set; }
        public int Cantidad { get; set; }
        public bool Inactivo { get; set; }

        
    }
}
