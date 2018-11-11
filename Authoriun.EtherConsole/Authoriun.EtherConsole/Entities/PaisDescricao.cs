namespace Authoriun.EtherConsole.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Config.PaisDescricao")]
    public partial class PaisDescricao
    {
        public int Id { get; set; }

        public int IdTenant { get; set; }

        public int IdPais { get; set; }

        public int IdIdioma { get; set; }

        [Required]
        public string Descricao { get; set; }

        public virtual Usuario Usuario { get; set; }

        public virtual Idioma Idioma { get; set; }

        public virtual Pais Pais { get; set; }
    }
}
