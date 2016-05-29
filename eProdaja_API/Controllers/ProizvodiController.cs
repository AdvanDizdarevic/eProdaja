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
    public class ProizvodiController : ApiController
    {
        private eProdajaEntities db = new eProdajaEntities();

        // GET: api/Proizvodi
        public IQueryable<Proizvodi> GetProizvodis()
        {
            return db.Proizvodis;
        }

        // GET: api/Proizvodi/5
        [ResponseType(typeof(Proizvodi))]
        public IHttpActionResult GetProizvodi(int id)
        {
            esp_Proizvodi_SelectById_Result proizvodi = db.esp_Proizvodi_SelectById(id).FirstOrDefault();
            if (proizvodi == null)
            {
                return NotFound();
            }

            return Ok(proizvodi);
        }

        [HttpGet]
        [Route("api/Proizvodi/SearchProizvodiByVrsta/{typeId}")]
        public List<esp_Proizvodi_SelectByVrsta_Result> SearchProizvodiByVrsta(int typeId)
        {
            return db.esp_Proizvodi_SelectByVrsta(typeId).ToList();
        }


        // PUT: api/Proizvodi/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutProizvodi(int id, Proizvodi proizvodi)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != proizvodi.ProizvodID)
            {
                return BadRequest();
            }

            db.Entry(proizvodi).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProizvodiExists(id))
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

        // POST: api/Proizvodi
        [ResponseType(typeof(Proizvodi))]
        public IHttpActionResult PostProizvodi(Proizvodi proizvodi)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.esp_Proizvodi_Insert(proizvodi.Naziv, proizvodi.Sifra, proizvodi.Cijena,
                proizvodi.KategorijaID, proizvodi.JedinicaMjereID, proizvodi.Slika, proizvodi.SlikaThumb);

            return CreatedAtRoute("DefaultApi", new { id = proizvodi.ProizvodID }, proizvodi);
        }

        // DELETE: api/Proizvodi/5
        [ResponseType(typeof(Proizvodi))]
        public IHttpActionResult DeleteProizvodi(int id)
        {
            Proizvodi proizvodi = db.Proizvodis.Find(id);
            if (proizvodi == null)
            {
                return NotFound();
            }

            db.Proizvodis.Remove(proizvodi);
            db.SaveChanges();

            return Ok(proizvodi);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ProizvodiExists(int id)
        {
            return db.Proizvodis.Count(e => e.ProizvodID == id) > 0;
        }
    }
}