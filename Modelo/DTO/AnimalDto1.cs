namespace Veterinaria.Controlador
{
    public  class AnimalDto
    {
        public int Id { get; set; }
        public string NombreAnimal { get; set; }
        public string TipoAnimalNombre { get; set; }
        public int RazaId { get; set; }
        public int Edad { get; set; }
        public string NombrePropietario { get; set; }
        public string Direccion { get; set; }
        public bool Inactivo { get; set; }
    }
}