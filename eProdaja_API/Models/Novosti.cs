//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace eProdaja_API.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Novosti
    {
        public int NovostID { get; set; }
        public string Naziv { get; set; }
        public string Sadrzaj { get; set; }
        public byte[] Slika { get; set; }
        public System.DateTime Datum { get; set; }
        public bool Status { get; set; }
        public int KorisnikID { get; set; }
    
        public virtual Korisnici Korisnici { get; set; }
    }
}
