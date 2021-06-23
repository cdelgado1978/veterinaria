namespace Veterinaria.Modelo.DTO
{
    public class MunicipioDto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public int ProvinciaId { get; set; }

        public string ProvinciaNombre { get; set; }

        public bool Inactivo { get; set; }
    }
}