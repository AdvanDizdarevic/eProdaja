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
    
    public partial class esp_Narudzbe_Aktivne_result
    {
        public int NarudzbaID { get; set; }
        public string BrojNarudzbe { get; set; }
        public int KupacID { get; set; }
        public System.DateTime Datum { get; set; }
        public string Kupac { get; set; }
        public Nullable<decimal> Iznos { get; set; }
    }
}
