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

        [HttpGet]
        [Route("api/Proizvodi/GetProizvodStatus/{typeId}")]
        public bool GetProizvodStatus(int typeId)
        {
            return db.Proizvodis.Find(typeId).Status;
        }

    

        [HttpGet]
        [Route("api/Proizvodi/GetProizvodiBySifra/{sifra?}")]
        public List<esp_Proizvodi_SelectBySifra_Result> GetProizvodiBySifra(string sifra="")
        {
            return db.esp_Proizvodi_SelectBySifra(sifra).ToList();
        }

        [HttpGet]
        [Route("api/Proizvodi/GetProizvodBySifra/{sifra?}")]
        public esp_Proizvodi_SelectBySifra_Result GetProizvodBySifra(string sifra = "")
        {
            return db.esp_Proizvodi_SelectBySifra(sifra).FirstOrDefault();
        }

        [HttpGet]
        [Route("api/Proizvodi/GetProizvodBySifraList/{sifra?}")]
        public List<esp_Proizvodi_SelectBySifraList_Result> GetProizvodBySifraList(string sifra = "")
        {
            return db.esp_Proizvodi_SelectBySifraList(sifra).ToList();
        }


        [HttpGet]
        [Route("api/Proizvodi/GetAktivniProizvodi/")]
        public List<esp_Proizvodi_SelectAktivni_Result> GetAktivniProizvodi()
        {
            return db.esp_Proizvodi_SelectAktivni().ToList();
        }


        [HttpGet]
        [Route("api/Proizvodi/GetNeaktivniProizvodi/")]
        public List<esp_Proizvodi_SelectNeAktivni_Result> GetNeaktivniProizvodi()
        {
            return db.esp_Proizvodi_SelectNeAktivni().ToList();
        }

        // GET: api/Porizvodi/SkladisteStanje/1
        [HttpGet]
        [Route("api/Proizvodi/GetProzivodBySkladiste/{id}")]
        public List<esp_Proizvodi_SelectBySkladiste_Result> GetProzivodBySkladiste(int id)
        {
            //  return db.esp_SelectProizvod_BySkladisteStanje(id).ToList();
            return db.esp_Proizvodi_SelectBySkladiste(id).ToList();
        }

        // GET : api/Proizvodi/GetProizvodiByNaziv/{sifra?}
        [HttpGet]
        [Route("api/Proizvodi/GetProizvodiByNaziv/{naziv?}")]
        public List<esp_Proizvodi_SelectByNaziv_Result> GetProizvodiByNaziv(string naziv = "")
        {
            return db.esp_Proizvodi_SelectByNaziv(naziv).ToList();
        }

        // GET: api/Porizvodi/NeocjenjeniProizvoidByKupacID
        [HttpGet]
        [Route("api/Proizvodi/GetNeocjenjeniProizvodi/{id}")]
        public List<esp_Select_NeocjenjeniKupljeniProizvodi_ByKupacID_Result> GetNeocjenjeniProizvodi(int id)
        {
            //  return db.esp_SelectProizvod_BySkladisteStanje(id).ToList();
            return db.esp_Select_NeocjenjeniKupljeniProizvodi_ByKupacID(id).ToList();
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

            //db.Proizvodis.Remove(proizvodi);
            proizvodi.Status = false;
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