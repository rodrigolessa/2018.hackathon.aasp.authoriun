using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AuthoriunApi.DTO
{
    public class ObraDTO
    {
        public ObraDTO()
        {
            Arquivo = new HashSet<ArquivoDTO>();
            //ObraVinculo = new HashSet<ObraVinculo>();
            //Registro = new HashSet<RegistroDTO>();
            RequerenteObra = new HashSet<RequerenteObraDTO>();
        }

        public int Id { get; set; }

        public int IdTenant { get; set; }

        public int IdGeneroObra { get; set; }

        public string DescricaoGeneroObra { get; set; }

        public bool? EhRequerimento { get; set; }

        public bool? EhAverbacao { get; set; }

        public bool? EhInedita { get; set; }

        public bool? EhPublicada { get; set; }

        public string Titulo { get; set; }

        public string Grafica { get; set; }

        public string Editora { get; set; }

        public string Ano { get; set; }

        public string Volume { get; set; }

        public string Edicao { get; set; }

        public string LocalPublicacao { get; set; }

        public int? Paginas { get; set; }

        public string AdaptacaoTituloOriginal { get; set; }

        public string AdaptacaoAutorOriginal { get; set; }

        public string TraducaoTituloOriginal { get; set; }

        public string TraducaoAutorOriginal { get; set; }

        public string Observacoes { get; set; }

        public int CriadoPor { get; set; }

        public DateTime CriadoEm { get; set; }

        public int? AlteradoPor { get; set; }

        public DateTime? AlteradoEm { get; set; }

        //public virtual Usuario Usuario { get; set; }

        //public virtual GeneroObraDTO GeneroObra { get; set; }

        public virtual ICollection<ArquivoDTO> Arquivo { get; set; }

        //public virtual ICollection<ObraVinculo> ObraVinculo { get; set; }

        public virtual ICollection<RegistroDTO> Registro { get; set; }

        public virtual ICollection<RequerenteObraDTO> RequerenteObra { get; set; }
    }
}