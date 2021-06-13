namespace Veterinaria.Modelo.DTO
{
    public class ProveedorDto
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public int TipoProveedorID { get; set; }
        public string Telefono { get; set; }
        public bool Inactivo { get; set; }
    }
}
