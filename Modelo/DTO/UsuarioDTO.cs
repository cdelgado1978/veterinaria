namespace Veterinaria.Modelo.DTO
{
    public class UsuarioDTO
    {
        public int Id { get; set; }
        public int EmpleadoId { get; set; }
        public string Usuario { get; set; }
        public string Contrasena { get; set; }
        public bool Inactivo { get; set; }
    }
}