namespace AuthoriunApi.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Config.TipoContatoDescricao")]
    public partial class TipoContatoDescricao
    {
        public int Id { get; set; }

        public int IdTenant { get; set; }

        public int IdTipoContato { get; set; }

        public int IdIdioma { get; set; }

        [Required]
        public string Descricao { get; set; }

        public virtual Usuario Usuario { get; set; }

        public virtual Idioma Idioma { get; set; }

        public virtual TipoContato TipoContato { get; set; }
    }
}
