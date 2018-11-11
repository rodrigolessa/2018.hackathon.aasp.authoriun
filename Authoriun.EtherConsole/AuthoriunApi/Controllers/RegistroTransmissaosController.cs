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

namespace AuthoriunApi.Controllers
{
    public class RegistroTransmissaosController : ApiController
    {
        private AuthoriunContext db = new AuthoriunContext();

        // GET: api/RegistroTransmissaos
        public IQueryable<RegistroTransmissao> GetRegistroTransmissao()
        {
            return db.RegistroTransmissao;
        }

        // GET: api/RegistroTransmissaos/5
        [ResponseType(typeof(RegistroTransmissao))]
        public IHttpActionResult GetRegistroTransmissao(int id)
        {
            RegistroTransmissao registroTransmissao = db.RegistroTransmissao.Find(id);
            if (registroTransmissao == null)
            {
                return NotFound();
            }

            return Ok(registroTransmissao);
        }

        // PUT: api/RegistroTransmissaos/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutRegistroTransmissao(int id, RegistroTransmissao registroTransmissao)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != registroTransmissao.Id)
            {
                return BadRequest();
            }

            db.Entry(registroTransmissao).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RegistroTransmissaoExists(id))
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

        // POST: api/RegistroTransmissaos
        [ResponseType(typeof(RegistroTransmissao))]
        public IHttpActionResult PostRegistroTransmissao(RegistroTransmissao registroTransmissao)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.RegistroTransmissao.Add(registroTransmissao);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = registroTransmissao.Id }, registroTransmissao);
        }

        // DELETE: api/RegistroTransmissaos/5
        [ResponseType(typeof(RegistroTransmissao))]
        public IHttpActionResult DeleteRegistroTransmissao(int id)
        {
            RegistroTransmissao registroTransmissao = db.RegistroTransmissao.Find(id);
            if (registroTransmissao == null)
            {
                return NotFound();
            }

            db.RegistroTransmissao.Remove(registroTransmissao);
            db.SaveChanges();

            return Ok(registroTransmissao);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool RegistroTransmissaoExists(int id)
        {
            return db.RegistroTransmissao.Count(e => e.Id == id) > 0;
        }
    }
}