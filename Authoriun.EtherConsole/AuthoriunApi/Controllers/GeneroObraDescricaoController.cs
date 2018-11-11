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
    public class GeneroObraDescricaoController : ApiController
    {
        private AuthoriunContext db = new AuthoriunContext();

        // GET: api/GeneroObraDescricao
        public List<GeneroObraDescricaoDTO> GetGeneroObraDescricao()
        {
            return Mapper.Map<List<GeneroObraDescricao>, List<GeneroObraDescricaoDTO>>(db.GeneroObraDescricao.Where(x => x.IdIdioma == 2).ToList());
        }

        // GET: api/GeneroObraDescricao/5
        [ResponseType(typeof(GeneroObraDescricao))]
        public IHttpActionResult GetGeneroObraDescricao(int id)
        {
            GeneroObraDescricao generoObraDescricao = db.GeneroObraDescricao.Find(id);
            if (generoObraDescricao == null)
            {
                return NotFound();
            }

            return Ok(generoObraDescricao);
        }

        // PUT: api/GeneroObraDescricao/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutGeneroObraDescricao(int id, GeneroObraDescricao generoObraDescricao)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != generoObraDescricao.Id)
            {
                return BadRequest();
            }

            db.Entry(generoObraDescricao).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GeneroObraDescricaoExists(id))
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

        // POST: api/GeneroObraDescricao
        [ResponseType(typeof(GeneroObraDescricao))]
        public IHttpActionResult PostGeneroObraDescricao(GeneroObraDescricao generoObraDescricao)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.GeneroObraDescricao.Add(generoObraDescricao);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = generoObraDescricao.Id }, generoObraDescricao);
        }

        // DELETE: api/GeneroObraDescricao/5
        [ResponseType(typeof(GeneroObraDescricao))]
        public IHttpActionResult DeleteGeneroObraDescricao(int id)
        {
            GeneroObraDescricao generoObraDescricao = db.GeneroObraDescricao.Find(id);
            if (generoObraDescricao == null)
            {
                return NotFound();
            }

            db.GeneroObraDescricao.Remove(generoObraDescricao);
            db.SaveChanges();

            return Ok(generoObraDescricao);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool GeneroObraDescricaoExists(int id)
        {
            return db.GeneroObraDescricao.Count(e => e.Id == id) > 0;
        }
    }
}