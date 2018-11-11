namespace Authoriun.EtherConsole.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Org.Documento")]
    public partial class Documento
    {
        public int Id { get; set; }

        public int IdTenant { get; set; }

        public int IdTipoDocumento { get; set; }

        public int IdPessoa { get; set; }

        public int? IdPais { get; set; }

        public int? IdOrgaoExpedidor { get; set; }

        [Required]
        public string Identificador { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? Validade { get; set; }

        public int CriadoPor { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime CriadoEm { get; set; }

        public int? AlteradoPor { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? AlteradoEm { get; set; }

        public virtual Usuario Usuario { get; set; }

        public virtual OrgaoExpedidor OrgaoExpedidor { get; set; }

        public virtual Pais Pais { get; set; }

        public virtual TipoDocumento TipoDocumento { get; set; }

        public virtual Pessoa Pessoa { get; set; }
    }
}
