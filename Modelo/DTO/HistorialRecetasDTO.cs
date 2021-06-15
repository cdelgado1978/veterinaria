using System;

namespace Veterinaria.Modelo.DTO
{
    public class HistorialRecetasDTO
    {
        public int id;

        public int RecetaId { get; set; }
        public int AnimalId { get; set; }
        public DateTime Fecha { get; set; }
        public string Diagnostico { get; set; }
        public TimeSpan Hora { get; set; }
        public string Tratamiento { get; set; }
        public bool Inactivo { get; set; }
    }
}