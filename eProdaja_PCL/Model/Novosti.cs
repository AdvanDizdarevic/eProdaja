using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eProdaja_PCL.Model
{
   public class Novosti
    {
        public int NovostID { get; set; }

        public string Naziv { get; set; }

        public string Sadrzaj { get; set; }

        public byte[] Slika { get; set; }

        public DateTime Datum { get; set; }

        public bool Status { get; set; }

        public int KorisnikID { get; set; }
    }
}
