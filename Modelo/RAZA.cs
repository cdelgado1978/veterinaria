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
    
    public partial class Raza
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Raza()
        {
            this.Animales = new HashSet<Animale>();
        }
    
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int TipoAnimalId { get; set; }
        public bool Inactivo { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Animale> Animales { get; set; }
        public virtual Tipo_Animal Tipo_Animal { get; set; }
    }
}