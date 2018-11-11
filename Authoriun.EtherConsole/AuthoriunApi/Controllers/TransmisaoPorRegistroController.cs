using AuthoriunApi.DTO;
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
    public class TransmisaoPorRegistroController : ApiController
    {
        private AuthoriunContext db = new AuthoriunContext();

        // GET: api/RegistroTransmissaos
        public List<RegistroTransmissaoDTO> GetRegistroTransmissao(int idRegistro)
        {
            return Mapper.Map<List<RegistroTransmissao>, List<RegistroTransmissaoDTO>>(db.RegistroTransmissao.Where( x => x.IdRegistro == idRegistro).ToList());
        }
    }
}
