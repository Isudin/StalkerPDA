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
    
    public partial class Sprzedaz
    {
        public int Id_sprzedazy { get; set; }
        public int Id_handlarza { get; set; }
        public int Id_przedmiotu { get; set; }
        public decimal Cena { get; set; }
        public int Ilosc { get; set; }
    
        public virtual Asortyment Asortyment { get; set; }
        public virtual Handlarz Handlarz { get; set; }
    }
}