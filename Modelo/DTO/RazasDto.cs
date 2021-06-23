namespace Veterinaria.Modelo.DTO
{
    public class RazasDto
    {
        public int Id { get; set; }

        public string Nombre { get;  set; }
        public int TipoAnimalId { get;  set; }

        public string TipoAnimalNombre { get; set; }
        public bool Inactivo { get;  set; }

    }
}