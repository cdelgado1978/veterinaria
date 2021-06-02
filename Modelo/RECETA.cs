//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Veterinaria.Modelo
{
    using System;
    using System.Collections.Generic;
    
    public partial class Receta
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Receta()
        {
            this.Historial_Recetas = new HashSet<Historial_Recetas>();
        }
    
        public int Id { get; set; }
        public int AnimalID { get; set; }
        public int TipoAnimalId { get; set; }
        public int RazaID { get; set; }
        public string Padecimiento { get; set; }
        public string ProductoId { get; set; }
        public string Dosis { get; set; }
        public string Personales { get; set; }
        public bool Inactivo { get; set; }
    
        public virtual Animale Animale { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Historial_Recetas> Historial_Recetas { get; set; }
    }
}