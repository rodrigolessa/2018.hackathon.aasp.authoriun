using AuthoriunApi.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AuthoriunApi.Controllers
{
    public class ConsultaObraController : ApiController
    {
        private AuthoriunContext db = new AuthoriunContext();

        [HttpGet]
        public List<DTO.ObraDTO> GetConsultaObra(string texto)
        {
            var obras = db.Obra.Where(x =>
              x.Titulo.Contains(texto) ||
              x.Grafica.Contains(texto) ||
              x.Editora.Contains(texto) ||
              x.Ano.Contains(texto) ||
              x.Volume.Contains(texto) ||
              x.Edicao.Contains(texto) ||
              x.LocalPublicacao.Contains(texto) ||
              x.Observacoes.Contains(texto)).ToList();

            var dto = Mapper.Map<List<Obra>, List<DTO.ObraDTO>>(obras);

            foreach (DTO.ObraDTO o in dto)
            {
                var gdo = db.GeneroObraDescricao.Where(x => x.IdGeneroObra == o.IdGeneroObra && x.IdIdioma == 2).FirstOrDefault();
                if (gdo != null)
                    o.DescricaoGeneroObra = gdo.Descricao;
            }

            return dto;
        }
    }
}
