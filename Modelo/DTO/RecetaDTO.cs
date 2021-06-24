namespace Veterinaria.Modelo.DTO
{
    public class RecetaDTO
    {
        public int Id { get; set; }
        public int Animal { get; set; }
        public int TipoAnimalId { get; set; }
        public int RazaId { get; set; }
        public string Padecimiento { get; set; }
        public string ProductoId { get; set; }

        public string ProductoNombre { get; set; }

        public string Dosis { get; set; }
        public string Personales { get; set; }
        public bool Inactivo { get; set; }
    }
}