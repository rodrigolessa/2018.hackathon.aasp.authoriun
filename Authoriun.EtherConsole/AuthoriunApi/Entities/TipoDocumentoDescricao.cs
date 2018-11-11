namespace AuthoriunApi.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Config.TipoDocumentoDescricao")]
    public partial class TipoDocumentoDescricao
    {
        public int Id { get; set; }

        public int IdTenant { get; set; }

        public int IdTipoDocumento { get; set; }

        public int IdIdioma { get; set; }

        [Required]
        public string Descricao { get; set; }

        public virtual Usuario Usuario { get; set; }

        public virtual Idioma Idioma { get; set; }

        public virtual TipoDocumento TipoDocumento { get; set; }
    }
}
