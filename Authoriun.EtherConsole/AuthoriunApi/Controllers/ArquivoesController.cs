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
    public class ArquivoesController : ApiController
    {
        private AuthoriunContext db = new AuthoriunContext();

        // GET: api/Arquivoes
        public List<ArquivoDTO> GetArquivo()
        {
            return Mapper.Map<List<Arquivo>, List<ArquivoDTO>>(db.Arquivo.ToList());
        }

        // GET: api/Arquivoes/5
        [ResponseType(typeof(Arquivo))]
        public IHttpActionResult GetArquivo(int id)
        {
            Arquivo arquivo = db.Arquivo.Find(id);
            if (arquivo == null)
            {
                return NotFound();
            }

            return Ok(arquivo);
        }

        // PUT: api/Arquivoes/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutArquivo(int id, Arquivo arquivo)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != arquivo.Id)
            {
                return BadRequest();
            }

            db.Entry(arquivo).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ArquivoExists(id))
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

        // POST: api/Arquivoes
        [ResponseType(typeof(Arquivo))]
        public IHttpActionResult PostArquivo(Arquivo arquivo)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Arquivo.Add(arquivo);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = arquivo.Id }, arquivo);
        }

        // DELETE: api/Arquivoes/5
        [ResponseType(typeof(Arquivo))]
        public IHttpActionResult DeleteArquivo(int id)
        {
            Arquivo arquivo = db.Arquivo.Find(id);
            if (arquivo == null)
            {
                return NotFound();
            }

            db.Arquivo.Remove(arquivo);
            db.SaveChanges();

            return Ok(arquivo);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ArquivoExists(int id)
        {
            return db.Arquivo.Count(e => e.Id == id) > 0;
        }
    }
}