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

namespace eProdaja_API.Controllers
{
    public class KupciController : ApiController
    {
        private eProdajaEntities db = new eProdajaEntities();

        // GET: api/Kupci
        public IQueryable<Kupci> GetKupcis()
        {
            return db.Kupcis;
        }

        [Route("api/Kupci/GetKupciByUsername/{name?}")]
        [HttpGet]
        public IHttpActionResult GetKupciByUsername(string name = "")
        {
            Kupci k = db.Kupcis.Where(x => x.KorisnickoIme == name && x.Status == true).FirstOrDefault();

            if (k == null)
            {
                return NotFound();
            }
                return Ok(k);
            
        }

     
        [HttpGet]
        [Route("api/Kupci/GetKupacSearch/{name?}")]
        public List<esp_Kupci_SelectByFUsername_Result> GetKupacSearch(string name = "")
        {
            return db.esp_Kupci_SelectByFUsername(name).ToList();

        }
        // GET: api/Kupci/5
        [ResponseType(typeof(Kupci))]
        public IHttpActionResult GetKupci(int id)
        {
            Kupci kupci = db.Kupcis.Find(id);
            if (kupci == null)
            {
                return NotFound();
            }

            return Ok(kupci);
        }

        // PUT: api/Kupci/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutKupci(int id, Kupci kupci)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != kupci.KupacID)
            {
                return BadRequest();
            }

            db.Entry(kupci).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!KupciExists(id))
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

        // POST: api/Kupci
        [ResponseType(typeof(Kupci))]
        public IHttpActionResult PostKupci(Kupci kupci)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Kupcis.Add(kupci);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = kupci.KupacID }, kupci);
        }

        // DELETE: api/Kupci/5
        [ResponseType(typeof(Kupci))]
        public IHttpActionResult DeleteKupci(int id)
        {
            Kupci kupci = db.Kupcis.Find(id);
            if (kupci == null)
            {
                return NotFound();
            }

            db.Kupcis.Remove(kupci);
            db.SaveChanges();

            return Ok(kupci);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool KupciExists(int id)
        {
            return db.Kupcis.Count(e => e.KupacID == id) > 0;
        }
    }
}