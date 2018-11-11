namespace Authoriun.EtherConsole.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Config.TipoEnderecoDescricao")]
    public partial class TipoEnderecoDescricao
    {
        public int Id { get; set; }

        public int IdTenant { get; set; }

        public int IdTipoEndereco { get; set; }

        public int IdIdioma { get; set; }

        [Required]
        public string Descricao { get; set; }

        public virtual Usuario Usuario { get; set; }

        public virtual Idioma Idioma { get; set; }

        public virtual TipoEndereco TipoEndereco { get; set; }
    }
}
