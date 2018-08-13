using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using eProdaja_API.Models;
using eProdaja_API.Util;

namespace eProdaja_API.Controllers
{
    public class NarudzbeController : ApiController
    {
        private eProdajaEntities db = new eProdajaEntities();

        // GET: api/Narudzbe
        public IQueryable<Narudzbe> GetNarudzbes()
        {
            return db.Narudzbes;
        }

        // GET: api/Narudzbe/5
        [ResponseType(typeof(Narudzbe))]
        public IHttpActionResult GetNarudzbe(int id)
        {
            Narudzbe narudzbe = db.Narudzbes.Find(id);
            if (narudzbe == null)
            {
                return NotFound();
            }

            return Ok(narudzbe);
        }


        [HttpGet]
        [Route("api/Narudzbe/GetBrojAktivnihNarudzbi")]
        public int GetBrojAktivnihNarudzbi()
        {
            return db.Narudzbes.Count(x => x.Status == true);
        }

        [HttpGet]
        [Route("api/Narudzbe/GetAktivneNarudzbe")]
        public List<esp_Narudzbe_Aktivne_result> GetAktivneNarudzbe()
        {
            return db.esp_Narudzbe_SelectAktivne().ToList();
        }


        [HttpGet]
        [Route("api/Narudzbe/GetStavkeNarudzbe/{id}")]
        public List<esp_NarudzbaStavke_SelectByNarudzbaID_Result> GetStavkeNarudzbe(int id)
        {
            return db.esp_NarudzbaStavke_SelectByNarudzbaID(id).ToList();
        }


        [HttpGet]
        [Route("api/Narudzbe/GetByKupac/{id}")]
        public List<esp_Narudzbe_SelectByKupac_Result> GetByKupac(int id)
        {
            return db.esp_Narudzbe_SelectByKupac(id).ToList();
        }


        //GET: api/Narudzbe/GetByKupacSum
        [HttpGet]
        [Route("api/Narudzbe/GetByKupacSum/{kupacID}")]
        public List<esp_Narudzbe_SelectByKupacSum_Result> GetByKupacSum(int kupacID)
        {
            return db.esp_Narudzbe_SelectByKupacSum(kupacID).ToList();
        }

        //GET: api/Narudzbe/GetByKupacNarudzbaId/{kupacId}/{narudzbaId}
        [HttpGet]
        [Route("api/Narudzbe/GetByKupacNarudzbaId/{narudzbaId}/{kupacId}")]
        public List<esp_Narudzbe_SelectByNarudzbaId_Result> GetByKupacNarudzbaId(int narudzbaId, int kupacID)
        {
            return db.esp_Narudzbe_SelectByNarudzbaId(narudzbaId, kupacID).ToList();
        }

        // PUT: api/Narudzbe/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutNarudzbe(int id, Narudzbe narudzbe)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != narudzbe.NarudzbaID)
            {
                return BadRequest();
            }

            db.Entry(narudzbe).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!NarudzbeExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Narudzbe
        [ResponseType(typeof(Narudzbe))]
        public IHttpActionResult PostNarudzbe(Narudzbe narudzbe)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            narudzbe.NarudzbaID = Convert.ToInt32(db.esp_Narudzbe_Insert(narudzbe.BrojNarudzbe, narudzbe.KupacID, narudzbe.Datum).FirstOrDefault());
            foreach (NarudzbaStavke item in narudzbe.NarudzbaStavkes)
            {
                db.esp_NarudzbaStavke_Insert(narudzbe.NarudzbaID, item.ProizvodID, item.Kolicina);
            }

            
            return CreatedAtRoute("DefaultApi", new { id = narudzbe.NarudzbaID }, narudzbe);
        }

        // DELETE: api/Narudzbe/5
        [ResponseType(typeof(Narudzbe))]
        public IHttpActionResult DeleteNarudzbe(int id)
        {
            Narudzbe narudzbe = db.Narudzbes.Find(id);
            if (narudzbe == null)
            {
                return NotFound();
            }

            db.Narudzbes.Remove(narudzbe);
            db.SaveChanges();

            return Ok(narudzbe);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool NarudzbeExists(int id)
        {
            return db.Narudzbes.Count(e => e.NarudzbaID == id) > 0;
        }
    }
}