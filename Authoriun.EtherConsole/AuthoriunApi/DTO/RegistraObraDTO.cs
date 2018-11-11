using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AuthoriunApi.DTO
{
    public class RegistraObraDTO
    {
        public int IdGeneroObra { get; set; }

        //public bool? EhRequerimento { get; set; }

        //public bool? EhAverbacao { get; set; }

        //public bool? EhInedita { get; set; }

        //public bool? EhPublicada { get; set; }

        public string Titulo { get; set; }

        public string Grafica { get; set; }

        public string Editora { get; set; }

        public string Ano { get; set; }

        public string Volume { get; set; }

        public string Edicao { get; set; }

        public string LocalPublicacao { get; set; }

        public int? Paginas { get; set; }

        //public string AdaptacaoTituloOriginal { get; set; }

        //public string AdaptacaoAutorOriginal { get; set; }

        //public string TraducaoTituloOriginal { get; set; }

        //public string TraducaoAutorOriginal { get; set; }

        public string Observacoes { get; set; }

        public int CriadoPor { get; set; }

        public DateTime CriadoEm { get; set; }

        // Arquivo

        public string Nome { get; set; }

        public string Extensao { get; set; }

        public string Mime { get; set; }

        public string Tamanho { get; set; }

        //public string MD5 { get; set; }

        public string SHA256 { get; set; }

        //public string SHA512 { get; set; }

        //public string JWTCertificado { get; set; }

        //public string JWTChavePublica { get; set; }
    }
}