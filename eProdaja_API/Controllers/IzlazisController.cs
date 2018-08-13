using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using eProdaja_API.Models;

namespace eProdaja_API.Controllers
{
    public class IzlazisController : ApiController
    {
        private eProdajaEntities db = new eProdajaEntities();

        // GET: api/Izlazis
        public IQueryable<Izlazi> GetIzlazis()
        {
            return db.Izlazis;
        }

        // GET: api/Izlazis/5
        [ResponseType(typeof(Izlazi))]
        public async Task<IHttpActionResult> GetIzlazi(int id)
        {
            Izlazi izlazi = await db.Izlazis.FindAsync(id);
            if (izlazi == null)
            {
                return NotFound();
            }

            return Ok(izlazi);
        }
        [HttpGet]
        [Route("api/Izlazis/GetIzlaziStavkeByIzlazID/{id?}")]
        public List<esp_IzlaziStavkeByIzlazID_Result> GetIzlaziStavkeByIzlazID(int id)
        {
            return db.esp_IzlaziStavkeByIzlazID(id).ToList();
        }

        [HttpPost]
        [Route("api/Izlazis/ProcesirajNarudzbu/{int?}")]

        public void ProcesirajNarudzbu(Izlazi i)
        {
            db.ProcesirajNarudzbu(i.NarudzbaID, i.IznosSaPDV, i.IznosBezPDV, i.SkladisteID, i.KorisnikID);
        }


        // PUT: api/Izlazis/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutIzlazi(int id, Izlazi izlazi)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != izlazi.IzlazID)
            {
                return BadRequest();
            }

            db.Entry(izlazi).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!IzlaziExists(id))
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

        // POST: api/Izlazis
        [ResponseType(typeof(Izlazi))]
        public async Task<IHttpActionResult> PostIzlazi(Izlazi izlazi)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Izlazis.Add(izlazi);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = izlazi.IzlazID }, izlazi);
        }

        // DELETE: api/Izlazis/5
        [ResponseType(typeof(Izlazi))]
        public async Task<IHttpActionResult> DeleteIzlazi(int id)
        {
            Izlazi izlazi = await db.Izlazis.FindAsync(id);
            if (izlazi == null)
            {
                return NotFound();
            }

            db.Izlazis.Remove(izlazi);
            await db.SaveChangesAsync();

            return Ok(izlazi);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool IzlaziExists(int id)
        {
            return db.Izlazis.Count(e => e.IzlazID == id) > 0;
        }
    }
}