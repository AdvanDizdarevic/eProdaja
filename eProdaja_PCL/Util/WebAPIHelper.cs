using eProdaja_UI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace eProdaja_PCL.Util
{
   public class WebAPIHelper
    {
        private HttpClient client { get; set; }
        private string route { get; set; }

        public WebAPIHelper(string uri,string route)
        {
            client = new HttpClient();
            client.BaseAddress = new Uri(uri);
            this.route = route;

        }
    
      public  HttpResponseMessage getResponse()
        {
            return client.GetAsync(route).Result;
        }

        public HttpResponseMessage postResponse(Object newObject)
        {
            return client.PostAsJsonAsync(route, newObject).Result;
        }

        public HttpResponseMessage getResponse(string korisnici)
        {
            //api/Korisnici/Advan
            return client.GetAsync(route+"/"+korisnici).Result;
        }


        public HttpResponseMessage getActionResponse(string action, string parameter ="")
        {
            //api/Korisnici/SearchKorisnici/ime
            return client.GetAsync(route + "/" + action + "/" + parameter).Result;
        }

        public HttpResponseMessage putResponse(int id, Object existingObject)
        {
            return client.PutAsJsonAsync(route + "/" + id, existingObject).Result;
        }

        public HttpResponseMessage PostActionResponse(string action, Object izlaz)
        {
            return client.PostAsJsonAsync(route + "/" + action, izlaz).Result;
        }

        public HttpResponseMessage getActionResponseMessage(string action, int parameter1, int parameter2)
        {
            // api/Korisnici/Filter/{parametar1}/{parametar2}
            return client.GetAsync(route + "/" + action + "/" + parameter1 + "/" + parameter2).Result;
        }
    }
}
