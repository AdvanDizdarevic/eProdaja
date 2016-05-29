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
    public class KategorijeProizvodaController : ApiController
    {
        private eProdajaEntities db = new eProdajaEntities();

        // GET: api/KategorijeProizvoda
        public IQueryable<KategorijeProizvoda> GetKategorijeProizvodas()
        {
            return db.KategorijeProizvodas.OrderBy(x => x.Naziv);
        }

        // GET: api/KategorijeProizvoda/5
        //    [ResponseType(typeof(KategorijeProizvoda))]
        //    public IHttpActionResult GetKategorijeProizvoda(int id)
        //    {
        //        KategorijeProizvoda kategorijeProizvoda = db.KategorijeProizvodas.Find(id);
        //        if (kategorijeProizvoda == null)
        //        {
        //            return NotFound();
        //        }

        //        return Ok(kategorijeProizvoda);
        //    }

        //    // PUT: api/KategorijeProizvoda/5
        //    [ResponseType(typeof(void))]
        //    public IHttpActionResult PutKategorijeProizvoda(int id, KategorijeProizvoda kategorijeProizvoda)
        //    {
        //        if (!ModelState.IsValid)
        //        {
        //            return BadRequest(ModelState);
        //        }

        //        if (id != kategorijeProizvoda.KategorijaID)
        //        {
        //            return BadRequest();
        //        }

        //        db.Entry(kategorijeProizvoda).State = EntityState.Modified;

        //        try
        //        {
        //            db.SaveChanges();
        //        }
        //        catch (DbUpdateConcurrencyException)
        //        {
        //            if (!KategorijeProizvodaExists(id))
        //            {
        //                return NotFound();
        //            }
        //            else
        //            {
        //                throw;
        //            }
        //        }

        //        return StatusCode(HttpStatusCode.NoContent);
        //    }

        //    // POST: api/KategorijeProizvoda
        //    [ResponseType(typeof(KategorijeProizvoda))]
        //    public IHttpActionResult PostKategorijeProizvoda(KategorijeProizvoda kategorijeProizvoda)
        //    {
        //        if (!ModelState.IsValid)
        //        {
        //            return BadRequest(ModelState);
        //        }

        //        db.KategorijeProizvodas.Add(kategorijeProizvoda);
        //        db.SaveChanges();

        //        return CreatedAtRoute("DefaultApi", new { id = kategorijeProizvoda.KategorijaID }, kategorijeProizvoda);
        //    }

        //    // DELETE: api/KategorijeProizvoda/5
        //    [ResponseType(typeof(KategorijeProizvoda))]
        //    public IHttpActionResult DeleteKategorijeProizvoda(int id)
        //    {
        //        KategorijeProizvoda kategorijeProizvoda = db.KategorijeProizvodas.Find(id);
        //        if (kategorijeProizvoda == null)
        //        {
        //            return NotFound();
        //        }

        //        db.KategorijeProizvodas.Remove(kategorijeProizvoda);
        //        db.SaveChanges();

        //        return Ok(kategorijeProizvoda);
        //    }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        //    private bool KategorijeProizvodaExists(int id)
        //    {
        //        return db.KategorijeProizvodas.Count(e => e.KategorijaID == id) > 0;
        //    }
    }
}