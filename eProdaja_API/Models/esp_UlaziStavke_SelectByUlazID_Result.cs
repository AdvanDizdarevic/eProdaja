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
    
    public partial class esp_UlaziStavke_SelectByUlazID_Result
    {
        public int UlazID { get; set; }
        public string BrojFakture { get; set; }
        public string Naziv { get; set; }
        public string Sifra { get; set; }
        public int Kolicina { get; set; }
        public decimal Cijena { get; set; }
        public Nullable<decimal> Ukupno { get; set; }
        public decimal PDV { get; set; }
        public decimal IznosRacuna { get; set; }
        public System.DateTime Datum { get; set; }
        public string Napomena { get; set; }
    }
}
