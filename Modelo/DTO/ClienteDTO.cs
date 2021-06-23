namespace Veterinaria.Modelo.DTO
{
    public class ClienteDTO
    {
        public int Id { get;  set; }
        public string Nombre { get;  set; }
        public string Apellido { get;  set; }
        public string Cedula { get;  set; }
        public string Direccion { get;  set; }
        public string Telefono { get;  set; }
        public bool Inactivo { get;  set; }

        public int MunicipioId { get; set; }
        public string MunicipioNombre { get; set; }
        public string ProvinciaNombre { get; set; }
        public string NombreCompleto { get; set; }
    }
}