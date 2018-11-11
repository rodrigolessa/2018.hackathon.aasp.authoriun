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
using AuthoriunApi.Entities;
using AutoMapper;

namespace AuthoriunApi.Controllers
{
    public class ObrasController : ApiController
    {
        private AuthoriunContext db = new AuthoriunContext();

        // GET: api/Obras
        public List<DTO.ObraDTO> GetObra()
        {
            return Mapper.Map<List<Obra>, List<DTO.ObraDTO>>(db.Obra.ToList());
        }

        // GET: api/Obras/5
        [ResponseType(typeof(DTO.ObraDTO))]
        public IHttpActionResult GetObra(int id)
        {
            Obra obra = db.Obra.Find(id);
            if (obra == null)
            {
                return NotFound();
            }

            return Ok(Mapper.Map<Obra, DTO.ObraDTO>(obra));
        }

        // PUT: api/Obras/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutObra(int id, Obra obra)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != obra.Id)
            {
                return BadRequest();
            }

            db.Entry(obra).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ObraExists(id))
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

        // POST: api/Obras
        [ResponseType(typeof(Obra))]
        public IHttpActionResult PostObra(Obra obra)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Obra.Add(obra);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = obra.Id }, obra);
        }

        // DELETE: api/Obras/5
        [ResponseType(typeof(Obra))]
        public IHttpActionResult DeleteObra(int id)
        {
            Obra obra = db.Obra.Find(id);
            if (obra == null)
            {
                return NotFound();
            }

            db.Obra.Remove(obra);
            db.SaveChanges();

            return Ok(obra);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ObraExists(int id)
        {
            return db.Obra.Count(e => e.Id == id) > 0;
        }
    }
}