using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AuthoriunApi.DTO
{
    public class RegistroDTO
    {
        public RegistroDTO()
        {
            //RegistroTransmissao = new HashSet<RegistroTransmissao>();
        }

        public int Id { get; set; }

        public int IdTenant { get; set; }

        public int IdObra { get; set; }

        public int IdArquivo { get; set; }

        //public string NomeDoArquivo { get; set; }

        public string HashTransacao { get; set; }

        public DateTime SolicitadoEm { get; set; }

        public int Status { get; set; }

        public int CriadoPor { get; set; }

        public DateTime CriadoEm { get; set; }

        public int? AlteradoPor { get; set; }

        public DateTime? AlteradoEm { get; set; }

        //public virtual Usuario Usuario { get; set; }
        //public virtual Arquivo Arquivo { get; set; }
        //public virtual Obra Obra { get; set; }
        //public virtual ICollection<RegistroTransmissao> RegistroTransmissao { get; set; }
    }
}