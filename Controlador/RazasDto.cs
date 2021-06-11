namespace Veterinaria.Controlador
{
    public class RazasDto
    {
        public int id { get; internal set; }

        public string Nombre { get; internal set; }
        public int TipoAnimalId { get; internal set; }
        public bool Inactivo { get; internal set; }
        
    }
}