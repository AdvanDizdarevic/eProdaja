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
    public class AkcijskiProizvodiController : ApiController
    {
        private eProdajaEntities db = new eProdajaEntities();

        // GET: api/AkcijskiProizvodi
        public IQueryable<AkcijskiProizvodi> GetAkcijskiProizvodis()
        {
            return db.AkcijskiProizvodis;
        }

        [HttpGet]
        [Route("api/AkcijskiProizvodi/GetTrenutnoAktivni")]
        public List<esp_AkcijskiProizvodi_SelectTrenutnoAktivni_Result> GetTrenutnoAktivni()
        {
            return db.esp_AkcijskiProizvodi_SelectTrenutnoAktivni().ToList();
        }

        // GET: api/AkcijskiProizvodi/5
        [ResponseType(typeof(AkcijskiProizvodi))]
        public IHttpActionResult GetAkcijskiProizvodi(int id)
        {
            AkcijskiProizvodi akcijskiProizvodi = db.AkcijskiProizvodis.Find(id);
            if (akcijskiProizvodi == null)
            {
                return NotFound();
            }

            return Ok(akcijskiProizvodi);
        }

        // PUT: api/AkcijskiProizvodi/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutAkcijskiProizvodi(int id, AkcijskiProizvodi akcijskiProizvodi)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != akcijskiProizvodi.AkcijskiProizvodID)
            {
                return BadRequest();
            }

            db.Entry(akcijskiProizvodi).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AkcijskiProizvodiExists(id))
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

        // POST: api/AkcijskiProizvodi
        [ResponseType(typeof(AkcijskiProizvodi))]
        public IHttpActionResult PostAkcijskiProizvodi(AkcijskiProizvodi akcijskiProizvodi)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.AkcijskiProizvodis.Add(akcijskiProizvodi);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = akcijskiProizvodi.AkcijskiProizvodID }, akcijskiProizvodi);
        }

        // DELETE: api/AkcijskiProizvodi/5
        [ResponseType(typeof(AkcijskiProizvodi))]
        public IHttpActionResult DeleteAkcijskiProizvodi(int id)
        {
            AkcijskiProizvodi akcijskiProizvodi = db.AkcijskiProizvodis.Find(id);
            if (akcijskiProizvodi == null)
            {
                return NotFound();
            }

            db.AkcijskiProizvodis.Remove(akcijskiProizvodi);
            db.SaveChanges();

            return Ok(akcijskiProizvodi);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool AkcijskiProizvodiExists(int id)
        {
            return db.AkcijskiProizvodis.Count(e => e.AkcijskiProizvodID == id) > 0;
        }
    }
}