namespace Veterinaria.Controlador
{
    public class ClienteDTO
    {
        public int Id { get; internal set; }
        public string Nombre { get; internal set; }
        public string Apellido { get; internal set; }
        public string Cedula { get; internal set; }
        public string Direccion { get; internal set; }
        public int CiudadId { get; internal set; }
        public string Telefono { get; internal set; }
        public bool Inactivo { get; internal set; }
    }
}