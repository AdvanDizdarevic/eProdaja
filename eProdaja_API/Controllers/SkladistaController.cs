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
    public class SkladistaController : ApiController
    {
        private eProdajaEntities db = new eProdajaEntities();

        // GET: api/Skladista
        public IQueryable<Skladista> GetSkladistas()
        {
            return db.Skladistas;
        }

        // GET: api/Skladista/5
        [ResponseType(typeof(Skladista))]
        public IHttpActionResult GetSkladista(int id)
        {
            Skladista skladista = db.Skladistas.Find(id);
            if (skladista == null)
            {
                return NotFound();
            }

            return Ok(skladista);
        }

        //GET: api/Skladista/NeAktivni
        [HttpGet]
        [Route("api/Skladista/GetNeAktivni/")]
        public List<Skladista> GetNeAktivni()
        {
            return db.Skladistas.Where(x => x.Status == false).ToList();
        }

        //GET: api/Skladista/Aktivni
        [HttpGet]
        [Route("api/Skladista/GetAktivni/")]
        public List<Skladista> GetAktivni()
        {
            return db.Skladistas.Where(x => x.Status == true).OrderBy(y => y.Naziv).ToList();
        }

        //GET: api/Skladista/Search
        [HttpGet]
        [Route("api/Skladista/GetSearch/{name?}")]
        public List<esp_Skladiste_SelectByNaziv_Result> GetSearch(string name = "")
        {
            return db.esp_Skladiste_SelectByNaziv(name).ToList();
        }

        // PUT: api/Skladista/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutSkladista(int id, Skladista skladista)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != skladista.SkladisteID)
            {
                return BadRequest();
            }

            db.Entry(skladista).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SkladistaExists(id))
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

        // POST: api/Skladista
        [ResponseType(typeof(Skladista))]
        public IHttpActionResult PostSkladista(Skladista skladista)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Skladistas.Add(skladista);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = skladista.SkladisteID }, skladista);
        }

        // DELETE: api/Skladista/5
        [ResponseType(typeof(Skladista))]
        public IHttpActionResult DeleteSkladista(int id)
        {
            Skladista skladista = db.Skladistas.Find(id);
            if (skladista == null)
            {
                return NotFound();
            }

            skladista.Status = false;
            db.SaveChanges();

            return Ok(skladista);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool SkladistaExists(int id)
        {
            return db.Skladistas.Count(e => e.SkladisteID == id) > 0;
        }
    }
}