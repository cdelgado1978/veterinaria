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
    
    public partial class PROVEEDOR
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PROVEEDOR()
        {
            this.PRODUCTOes = new HashSet<PRODUCTO>();
        }
    
        public int IDPROVEEDOR { get; set; }
        public string NOMBREPROV { get; set; }
        public string DIRECCION { get; set; }
        public int IDTIPOPROV { get; set; }
        public string TEELFONOPROV { get; set; }
        public string ESTATUS { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRODUCTO> PRODUCTOes { get; set; }
    }
}
