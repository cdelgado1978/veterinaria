namespace Veterinaria.Vista.Formularios.Productos
{
    internal class Producto
    {
        public Producto()
        {
        }

        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal Costo { get; set; }
        public decimal Precio { get; set; }
        public int Cantidad { get; set; }
        public int ProveedorId { get; set; }
        public int TipoProductoId { get; set; }
        public bool Inactivo { get; set; }
    }
}