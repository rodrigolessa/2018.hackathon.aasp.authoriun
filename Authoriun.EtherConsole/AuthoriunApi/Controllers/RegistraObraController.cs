using AuthoriunApi.DTO;
using AuthoriunApi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

namespace AuthoriunApi.Controllers
{
    public class RegistraObraController : ApiController
    {
        private AuthoriunContext db = new AuthoriunContext();

        // POST: api/Obras
        //[ResponseType(typeof(Obra))]
        [HttpPost]
        public int PostRegistraObra(RegistraObraDTO registraObra)
        {
            //if (!ModelState.IsValid)
            //{
            //    return BadRequest(ModelState);
            //}

            Registro registro = new Registro()
            {
                IdTenant = 1,
                //HashTransacao { get; set; }
                SolicitadoEm = DateTime.Now,
                Status = 1,
                CriadoPor = 1
                //public DateTime CriadoEm { get; set; }
            };

            Arquivo arquivo = new Arquivo()
            {
                IdTenant = 1,
                Nome = registraObra.Nome,
                Extensao = registraObra.Extensao,
                Mime = registraObra.Mime,
                Tamanho = registraObra.Tamanho,
                MD5 = registraObra.SHA256,
                SHA256 = registraObra.SHA256,
                SHA512 = registraObra.SHA256
                //public string JWTCertificado { get; set; }
                //public string JWTChavePublica { get; set; }
            };

            arquivo.Registro.Add(registro);

            Obra obra = new Obra()
            {
                IdTenant = 1,
                IdGeneroObra = registraObra.IdGeneroObra,
                EhRequerimento = true,
                Titulo = registraObra.Titulo,
                Grafica = registraObra.Grafica,
                Editora = registraObra.Editora,
                Ano = registraObra.Ano,
                Volume = registraObra.Volume,
                Edicao = registraObra.Edicao,
                LocalPublicacao = registraObra.LocalPublicacao,
                Paginas = registraObra.Paginas,
                Observacoes = registraObra.Observacoes,
                CriadoPor = 1,
                CriadoEm = DateTime.Now
            };

            obra.Arquivo.Add(arquivo);

            db.Obra.Add(obra);
            db.SaveChanges();

            //return CreatedAtRoute("DefaultApi", new
            //{
            //    id = obra.Id
            //}, obra);

            return obra.Id;
        }
    }
}