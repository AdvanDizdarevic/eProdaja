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
using System.Data.Entity.Core;
using eProdaja_API.Util;
//Configuration.ProxyCreationEnabled = false;
namespace eProdaja_API.Controllers
{
    public class KorisniciController : ApiController
    {
        private eProdajaEntities db = new eProdajaEntities();

        // GET: api/Korisnici
        public IQueryable<Korisnici> GetKorisnicis()
        {
            return db.Korisnicis;
        }


        [HttpGet]
        [Route("api/Korisnici/SearchKorisnici/{name?}")]
        public List<Korisnici> SearchKorisnici(string name="")
        {
            return db.esp_Korisnici_SelectByImePrezime(name).ToList();
        }

        // GET: api/Korisnici/5
        [ResponseType(typeof(Korisnici))]
        public IHttpActionResult GetKorisnici(int id)
        {
            Korisnici korisnici = db.Korisnicis.Find(id);
            if (korisnici == null)
            {
                return NotFound();
            }

            return Ok(korisnici);
        }

        [ResponseType(typeof(Korisnici))]
        [Route("api/Korisnici/{username}")]
        public IHttpActionResult GetKorisnici(string username)
        {
            Korisnici korisnik = db.Korisnicis.Where(x => x.KorisnickoIme == username).FirstOrDefault();
            if (korisnik == null)
            {
                return NotFound();
            }

            return Ok(korisnik);
        }

        // PUT: api/Korisnici/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutKorisnici(int id, Korisnici korisnici)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != korisnici.KorisnikID)
            {
                return BadRequest();
            }

            db.Entry(korisnici).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!KorisniciExists(id))
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

        // POST: api/Korisnici
        [ResponseType(typeof(Korisnici))]
        [ExceptionFilter]
        public IHttpActionResult PostKorisnici(Korisnici korisnici)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            //db.Korisnicis.Add(korisnici);
            //db.SaveChanges();

            try
            {
               korisnici.KorisnikID = Convert.ToInt32(db.esp_Korisnici_Insert(korisnici.Ime, korisnici.Prezime, korisnici.Email, korisnici.Telefon,
                                           korisnici.KorisnickoIme, korisnici.LozinkaSalt, korisnici.LozinkaHash).FirstOrDefault());
            }
            catch (EntityException ex)
            {
                throw new NotImplementedException();
              //  throw CreateHttpResponseExcetion(Util.ExceptionHandler.HandleException(ex), HttpStatusCode.Conflict);
            }
            foreach(Uloge u in korisnici.Uloge)
            {
                db.esp_KorisniciUloge_Insert(korisnici.KorisnikID, u.UlogaID);

            }

            return CreatedAtRoute("DefaultApi", new { id = korisnici.KorisnikID }, korisnici);
        }

        private HttpResponseException CreateHttpResponseExcetion(string reason, HttpStatusCode status)
        {
            HttpResponseMessage msg = new HttpResponseMessage()
            {
                StatusCode = status,
                ReasonPhrase = reason,
                Content = new StringContent(reason)
            };
            return new HttpResponseException(msg);
        }



        // DELETE: api/Korisnici/5
        [ResponseType(typeof(Korisnici))]
        public IHttpActionResult DeleteKorisnici(int id)
        {
            Korisnici korisnici = db.Korisnicis.Find(id);
            if (korisnici == null)
            {
                return NotFound();
            }

            db.Korisnicis.Remove(korisnici);
            db.SaveChanges();

            return Ok(korisnici);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool KorisniciExists(int id)
        {
            return db.Korisnicis.Count(e => e.KorisnikID == id) > 0;
        }
    }
}