using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AuthoriunApi.DTO
{
    public class GeneroObraDescricaoDTO
    {
        public int Id { get; set; }

        public int IdTenant { get; set; }

        public int IdGeneroObra { get; set; }

        public int IdIdioma { get; set; }

        public string Descricao { get; set; }

        //public virtual Usuario Usuario { get; set; }

        //public virtual GeneroObra GeneroObra { get; set; }

        //public virtual Idioma Idioma { get; set; }
    }
}