using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eProdaja_PCL.Model
{
  public  class NaruzbaList
    {
        public int NarudzbaID { get; set; }
        public string BrojNarudzbe { get; set; }
        public string Naziv { get; set; }
        public string Sifra { get; set; }
        public decimal Cijena { get; set; }
        public int? Kolicina { get; set; }
        public string Kategorija { get; set; }
        public byte[] SlikaThumb { get; set; }
        public System.DateTime Datum { get; set; }
    }
}
