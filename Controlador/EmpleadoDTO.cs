namespace Veterinaria.Controlador
{
    public class EmpleadoDTO
    {
        public int Id { get; internal set; }
        public string Nombre { get; internal set; }
        public string Apellido { get; internal set; }
        public int UsuarioId { get; internal set; }
        public int CargoId { get; internal set; }
        public int Sueldo { get; internal set; }
        public string Direccion { get; internal set; }
        public object CiudadId { get; internal set; }
        public string Telefono { get; internal set; }
        public string Cedula { get; internal set; }
        public string Correo { get; internal set; }
        public bool Inactivo { get; internal set; }
    }
}