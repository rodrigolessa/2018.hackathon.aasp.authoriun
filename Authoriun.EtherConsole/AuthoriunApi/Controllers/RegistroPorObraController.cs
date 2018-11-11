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
    public class RegistroPorObraController : ApiController
    {
        private AuthoriunContext db = new AuthoriunContext();

        // GET: api/Registroes
        public List<ObraDTO> GetRegistroPorObra(int idObra)
        {
            return Mapper.Map<List<Obra>, List<ObraDTO>>(db.Obra.Where(x=>x.Id == idObra).ToList());
        }
    }
}