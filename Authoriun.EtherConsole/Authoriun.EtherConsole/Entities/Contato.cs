namespace Authoriun.EtherConsole.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Org.Contato")]
    public partial class Contato
    {
        public int Id { get; set; }

        public int IdTenant { get; set; }

        public int IdTipoContato { get; set; }

        public int IdPessoa { get; set; }

        public string Descricao { get; set; }

        public int CriadoPor { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime CriadoEm { get; set; }

        public int? AlteradoPor { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? AlteradoEm { get; set; }

        public virtual Usuario Usuario { get; set; }

        public virtual TipoContato TipoContato { get; set; }

        public virtual Pessoa Pessoa { get; set; }
    }
}
