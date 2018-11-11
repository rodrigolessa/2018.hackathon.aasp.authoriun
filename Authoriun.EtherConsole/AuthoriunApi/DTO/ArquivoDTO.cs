using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AuthoriunApi.DTO
{
    public class ArquivoDTO
    {
        public ArquivoDTO()
        {
            Registro = new HashSet<RegistroDTO>();
        }

        public int Id { get; set; }

        public int IdTenant { get; set; }

        public int IdObra { get; set; }

        public string Nome { get; set; }

        public string Extensao { get; set; }

        public string Mime { get; set; }

        public string Tamanho { get; set; }

        public string MD5 { get; set; }

        public string SHA256 { get; set; }

        public string SHA512 { get; set; }

        public string JWTCertificado { get; set; }

        public string JWTChavePublica { get; set; }

        public int CriadoPor { get; set; }

        public DateTime CriadoEm { get; set; }

        public int? AlteradoPor { get; set; }

        public DateTime? AlteradoEm { get; set; }

        //public virtual Usuario Usuario { get; set; }

        //public virtual Obra Obra { get; set; }

        public virtual ICollection<RegistroDTO> Registro { get; set; }
    }
}