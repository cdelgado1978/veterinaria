namespace Veterinaria.Modelo.DTO
{
    public class EmpleadoDTO
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int UsuarioId { get; set; }
        public int CargoId { get; set; }
        public int Sueldo { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Cedula { get; set; }
        public string Correo { get; set; }
        public bool Inactivo { get; set; }

        public int MunicipioId { get; set; }
    }
}