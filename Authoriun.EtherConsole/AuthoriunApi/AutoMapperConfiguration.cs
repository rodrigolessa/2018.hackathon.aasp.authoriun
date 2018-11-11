using AuthoriunApi.DTO;
using AuthoriunApi.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AuthoriunApi
{
    public class AutoMapperConfiguration
    {
        public static void Configure()
        {
            Mapper.Initialize(cfg =>
            {
                // Core
                cfg.CreateMap<Obra, ObraDTO>();

                cfg.CreateMap<Registro, RegistroDTO>();
                    //.ForMember(d => d.NomeDoArquivo, opt => opt.MapFrom(src => src.Arquivo.Nome));

                cfg.CreateMap<RequerenteObra, RequerenteObraDTO>();

                cfg.CreateMap<Arquivo, ArquivoDTO>();

                cfg.CreateMap<GeneroObraDescricao, GeneroObraDescricaoDTO>();

                cfg.CreateMap<RegistroTransmissao, RegistroTransmissaoDTO>();

            });
        }
    }
}