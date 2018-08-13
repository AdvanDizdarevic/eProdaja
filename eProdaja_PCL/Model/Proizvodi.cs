using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eProdaja_PCL.Model
{
    public class Proizvodi
    {

        public int ProizvodID { get; set; }
        public string Naziv { get; set; }
        public string Sifra { get; set; }
        public decimal Cijena { get; set; }
        public int KategorijaID { get; set; }
        public int JedinicaMjereID { get; set; }
        public byte[] Slika { get; set; }
        public byte[] SlikaThumb { get; set; }
        public bool Status { get; set; }

        public string Kategorija { get; set; }
        public Nullable<decimal> ProsjecnaOcjena { get; set; }
    }
}
