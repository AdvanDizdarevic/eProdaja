using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace eProdaja_API.Models
{
    public partial class Proizvodi
    {
        public override string ToString()
        {
            return Sifra + "-" + Naziv;
        }
    }
}