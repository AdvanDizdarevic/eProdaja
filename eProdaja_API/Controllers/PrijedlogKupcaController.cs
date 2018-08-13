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
    public class PrijedlogKupcaController : ApiController
    {
        private eProdajaEntities db = new eProdajaEntities();

        // GET: api/PrijedlogKupca
        public IQueryable<PrijedlogKupca> GetPrijedlogKupcas()
        {
            return db.PrijedlogKupcas;
        }
        [HttpGet]
        [Route("api/PrijedlogKupca/SelectAll")]
        public List<esp_PrijedlogKupca_SelectAll_Result> SelectAll()
        {
            return db.esp_PrijedlogKupca_SelectAll().ToList();
        }

        // GET: api/PrijedlogKupca/5
        [ResponseType(typeof(PrijedlogKupca))]
        public IHttpActionResult GetPrijedlogKupca(int id)
        {
            PrijedlogKupca prijedlogKupca = db.PrijedlogKupcas.Find(id);
            if (prijedlogKupca == null)
            {
                return NotFound();
            }

            return Ok(prijedlogKupca);
        }

        // PUT: api/PrijedlogKupca/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutPrijedlogKupca(int id, PrijedlogKupca prijedlogKupca)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != prijedlogKupca.PrijedlogKupcaID)
            {
                return BadRequest();
            }

            db.Entry(prijedlogKupca).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PrijedlogKupcaExists(id))
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

        // POST: api/PrijedlogKupca
        [ResponseType(typeof(PrijedlogKupca))]
        public IHttpActionResult PostPrijedlogKupca(PrijedlogKupca prijedlogKupca)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.PrijedlogKupcas.Add(prijedlogKupca);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = prijedlogKupca.PrijedlogKupcaID }, prijedlogKupca);
        }

        // DELETE: api/PrijedlogKupca/5
        [ResponseType(typeof(PrijedlogKupca))]
        public IHttpActionResult DeletePrijedlogKupca(int id)
        {
            PrijedlogKupca prijedlogKupca = db.PrijedlogKupcas.Find(id);
            if (prijedlogKupca == null)
            {
                return NotFound();
            }

            db.PrijedlogKupcas.Remove(prijedlogKupca);
            db.SaveChanges();

            return Ok(prijedlogKupca);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool PrijedlogKupcaExists(int id)
        {
            return db.PrijedlogKupcas.Count(e => e.PrijedlogKupcaID == id) > 0;
        }
    }
}