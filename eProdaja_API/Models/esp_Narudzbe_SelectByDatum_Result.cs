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
    
    public partial class esp_Narudzbe_SelectByDatum_Result
    {
        public int NarudzbaID { get; set; }
        public string BrojNarudzbe { get; set; }
        public string Naziv { get; set; }
        public string Sifra { get; set; }
        public decimal Cijena { get; set; }
        public Nullable<int> Kolicina { get; set; }
        public string Kategorija { get; set; }
        public byte[] SlikaThumb { get; set; }
        public System.DateTime Datum { get; set; }
    }
}
