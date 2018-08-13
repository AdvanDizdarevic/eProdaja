using System;

namespace eProdaja_PCL.Model
{
    public class AkcijskiProizvodis
    {
        public int ProizvodID { get; set; }
        public string Naziv { get; set; }
        public string Sifra { get; set; }
        public decimal Cijena { get; set; }
        public decimal Popust { get; set; }
        public decimal? SaPopustom { get; set; }
        public System.DateTime DatumPocetka { get; set; }
        public System.DateTime DatumKraja { get; set; }
        public byte[] SlikaThumb { get; set; }
        public int UkupnoDana { get; set; }
    }
}