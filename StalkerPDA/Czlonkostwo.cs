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
    
    public partial class Czlonkostwo
    {
        public int Id_czlonka { get; set; }
        public int Id_stalkera { get; set; }
        public int Id_frakcji { get; set; }
        public string Stopien { get; set; }
        public System.DateTime Data_dolaczenia { get; set; }
        public Nullable<System.DateTime> Data_odejscia { get; set; }
    
        public virtual Frakcja Frakcja { get; set; }
        public virtual Stalker Stalker { get; set; }
    }
}
