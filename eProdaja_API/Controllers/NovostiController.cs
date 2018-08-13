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
    public class NovostiController : ApiController
    {
        private eProdajaEntities db = new eProdajaEntities();

        // GET: api/Novosti
        public IQueryable<Novosti> GetNovostis()
        {
            return db.Novostis.Where(x=>x.Status==true).OrderBy(x=>x.NovostID);
        }

        // GET: api/Novosti/5
        [ResponseType(typeof(Novosti))]
        public IHttpActionResult GetNovosti(int id)
        {
            Novosti novosti = db.Novostis.Find(id);
            if (novosti == null)
            {
                return NotFound();
            }

            return Ok(novosti);
        }
        [HttpGet]
        [Route("api/Novosti/GetNovostiStatus/{typeId}")]
        public bool GetNovostiStatus(int typeId)
        {
            return db.Novostis.Find(typeId).Status;
        }
        // GET: api/Novosti/5
        [ResponseType(typeof(Novosti))]
        [Route("api/Novosti/GetNeaktivne")]
        public List<Novosti> GetNeaktivne()
        {
            return db.Novostis.Where(x => x.Status == false).ToList();
        }

        // PUT: api/Novosti/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutNovosti(int id, Novosti novosti)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != novosti.NovostID)
            {
                return BadRequest();
            }

            db.Entry(novosti).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!NovostiExists(id))
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

        // POST: api/Novosti
        [ResponseType(typeof(Novosti))]
        public IHttpActionResult PostNovosti(Novosti novosti)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Novostis.Add(novosti);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = novosti.NovostID }, novosti);
        }

        // DELETE: api/Novosti/5
        [ResponseType(typeof(Novosti))]
        public IHttpActionResult DeleteNovosti(int id)
        {
            Novosti novosti = db.Novostis.Find(id);
            if (novosti == null)
            {
                return NotFound();
            }

            db.Novostis.Remove(novosti);
            db.SaveChanges();

            return Ok(novosti);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool NovostiExists(int id)
        {
            return db.Novostis.Count(e => e.NovostID == id) > 0;
        }
    }
}