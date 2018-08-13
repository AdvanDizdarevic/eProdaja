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
    public class GreskaController : ApiController
    {
        private eProdajaEntities db = new eProdajaEntities();

        // GET: api/Greska
        public IQueryable<Greska> GetGreskas()
        {
            return db.Greskas;
        }

        // GET: api/Greska/5
        [ResponseType(typeof(Greska))]
        public IHttpActionResult GetGreska(int id)
        {
            Greska greska = db.Greskas.Find(id);
            if (greska == null)
            {
                return NotFound();
            }

            return Ok(greska);
        }

        // PUT: api/Greska/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutGreska(int id, Greska greska)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != greska.GreskaID)
            {
                return BadRequest();
            }

            db.Entry(greska).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GreskaExists(id))
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

        // POST: api/Greska
        [ResponseType(typeof(Greska))]
        public IHttpActionResult PostGreska(Greska greska)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Greskas.Add(greska);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = greska.GreskaID }, greska);
        }

        // DELETE: api/Greska/5
        [ResponseType(typeof(Greska))]
        public IHttpActionResult DeleteGreska(int id)
        {
            Greska greska = db.Greskas.Find(id);
            if (greska == null)
            {
                return NotFound();
            }

            db.Greskas.Remove(greska);
            db.SaveChanges();

            return Ok(greska);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool GreskaExists(int id)
        {
            return db.Greskas.Count(e => e.GreskaID == id) > 0;
        }
    }
}