using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eProdaja_PCL.Model
{
  public  class PrijedlogKupca
    {
        public int PrijedlogKupcaID { get; set; }
        public string Naziv { get; set; }
        public string Sadrzaj { get; set; }
        public System.DateTime Datum { get; set; }
        public bool Status { get; set; }
        public int KupacID { get; set; }
    }
}
