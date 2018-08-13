using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using eProdaja_API.Models;

namespace eProdaja_API.Controllers
{
    public class PreporukaController : ApiController
    {
        //Proizvodi_SelectById
        [HttpGet]
        [Route("api/Preporuka/GetSlicneProizvode/{id}")]
        public List<esp_Proizvodi_SelectById_Result> GetSlicneProizvode(int id)
        {
            Util.RecomendSystem preporuka = new Util.RecomendSystem();

            return preporuka.GetSlicneProizvode(id);
        }
    }
}
