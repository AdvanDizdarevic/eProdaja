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
    public class DobavljaciController : ApiController
    {
        private eProdajaEntities db = new eProdajaEntities();

        // GET: api/Dobavljaci
        public IQueryable<Dobavljaci> GetDobavljacis()
        {
            return db.Dobavljacis;
        }

        // GET: api/Dobavljaci/5
        [ResponseType(typeof(Dobavljaci))]
        public IHttpActionResult GetDobavljaci(int id)
        {
            Dobavljaci dobavljaci = db.Dobavljacis.Find(id);
            if (dobavljaci == null)
            {
                return NotFound();
            }

            return Ok(dobavljaci);
        }

        [HttpGet]
        [Route("api/Dobavljaci/GetDobavljacStatus/{typeId}")]
        public bool GetDobavljacStatus(int typeId)
        {
            return db.Dobavljacis.Find(typeId).Status;
        }

        [HttpGet]
        [Route("api/Dobavljaci/GetAktivni/")]
        public List<Dobavljaci> GetAktivni()
        {
            return db.Dobavljacis.Where(x => x.Status == true).ToList();
        }

        [HttpGet]
        [Route("api/Dobavljaci/GetNeAktivni/")]
        public List<Dobavljaci> GetNeAktivni()
        {
            return db.Dobavljacis.Where(x => x.Status == false).ToList();
        }

        [HttpGet]
        [Route("api/Dobavljaci/GetSearch/{name?}")]
        public List<esp_Dobavljaci_SelectByNaziv_KOsoba_Result> GetSearch(string name="")
        {
            return db.esp_Dobavljaci_SelectByNaziv_KOsoba(name).ToList();
        }

        // PUT: api/Dobavljaci/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutDobavljaci(int id, Dobavljaci dobavljaci)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != dobavljaci.DobavljacID)
            {
                return BadRequest();
            }

            db.Entry(dobavljaci).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DobavljaciExists(id))
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

        // POST: api/Dobavljaci
        [ResponseType(typeof(Dobavljaci))]
        public IHttpActionResult PostDobavljaci(Dobavljaci dobavljaci)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Dobavljacis.Add(dobavljaci);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = dobavljaci.DobavljacID }, dobavljaci);
        }

        // DELETE: api/Dobavljaci/5
        [ResponseType(typeof(Dobavljaci))]
        public IHttpActionResult DeleteDobavljaci(int id)
        {
            Dobavljaci dobavljaci = db.Dobavljacis.Find(id);
            if (dobavljaci == null)
            {
                return NotFound();
            }

            dobavljaci.Status = false;
            db.SaveChanges();

            return Ok(dobavljaci);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool DobavljaciExists(int id)
        {
            return db.Dobavljacis.Count(e => e.DobavljacID == id) > 0;
        }
    }
}