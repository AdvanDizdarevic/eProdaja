using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eProdaja_PCL.Model
{
  public  class Greska
    {
        public int GreskaID { get; set; }
        public string Naziv { get; set; }
        public string Sadrzaj { get; set; }
        public System.DateTime DatumPostavljanja { get; set; }
        public bool Pregledana { get; set; }
        public bool Status { get; set; }
        public int KupacID { get; set; }
    }
}
