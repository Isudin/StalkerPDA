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
    
    public partial class Granica
    {
        public int Id_ukladu { get; set; }
        public int Id_terytorium_p { get; set; }
        public int Id_terytorium_d { get; set; }
    
        public virtual Terytorium Terytorium { get; set; }
        public virtual Terytorium Terytorium1 { get; set; }
    }
}
