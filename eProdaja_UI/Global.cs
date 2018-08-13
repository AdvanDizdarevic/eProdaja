using eProdaja_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace eProdaja_UI
{
   public class Global
    {
        public static Korisnici prijavljeniKorisnik { get; set; }

        public static Dobavljaci odabraniDobavljac { get; set; }



        public static string GetMessage(string key)
        {

            ResourceManager rm = new ResourceManager("eProdaja_UI.Messages",Assembly.GetExecutingAssembly());
            return rm.GetString(key);
        }

       
    }
}
