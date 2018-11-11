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
using AuthoriunApi.DTO;
using AuthoriunApi.Entities;
using AutoMapper;

namespace AuthoriunApi.Controllers
{
    public class RegistroesController : ApiController
    {
        private AuthoriunContext db = new AuthoriunContext();

        // GET: api/Registroes
        public List<RegistroDTO> GetRegistro()
        {
            return Mapper.Map<List<Registro>, List<RegistroDTO>>(db.Registro.ToList());
        }

        // GET: api/Registroes/5
        [ResponseType(typeof(Registro))]
        public IHttpActionResult GetRegistro(int id)
        {
            Registro registro = db.Registro.Find(id);
            if (registro == null)
            {
                return NotFound();
            }

            return Ok(registro);
        }

        // PUT: api/Registroes/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutRegistro(int id, Registro registro)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != registro.Id)
            {
                return BadRequest();
            }

            db.Entry(registro).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RegistroExists(id))
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

        // POST: api/Registroes
        [ResponseType(typeof(Registro))]
        public IHttpActionResult PostRegistro(Registro registro)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Registro.Add(registro);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = registro.Id }, registro);
        }

        // DELETE: api/Registroes/5
        [ResponseType(typeof(Registro))]
        public IHttpActionResult DeleteRegistro(int id)
        {
            Registro registro = db.Registro.Find(id);
            if (registro == null)
            {
                return NotFound();
            }

            db.Registro.Remove(registro);
            db.SaveChanges();

            return Ok(registro);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool RegistroExists(int id)
        {
            return db.Registro.Count(e => e.Id == id) > 0;
        }
    }
}