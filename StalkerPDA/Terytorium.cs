//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StalkerPDA
{
    using System;
    using System.Collections.Generic;
    
    public partial class Terytorium
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Terytorium()
        {
            this.Granica = new HashSet<Granica>();
            this.Granica1 = new HashSet<Granica>();
            this.Handlarz = new HashSet<Handlarz>();
        }
    
        public int Id_terytorium { get; set; }
        public string Nazwa { get; set; }
        public string Powierzchnia { get; set; }
        public Nullable<int> Id_frakcji { get; set; }
        public Nullable<System.DateTime> Od_kiedy { get; set; }
    
        public virtual Frakcja Frakcja { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Granica> Granica { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Granica> Granica1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Handlarz> Handlarz { get; set; }
    }
}
