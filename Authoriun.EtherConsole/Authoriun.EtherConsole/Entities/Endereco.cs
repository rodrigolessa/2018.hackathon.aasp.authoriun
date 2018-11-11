namespace Authoriun.EtherConsole.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Org.Endereco")]
    public partial class Endereco
    {
        public int Id { get; set; }

        public int IdTenant { get; set; }

        public int IdTipoEndereco { get; set; }

        public int IdPessoa { get; set; }

        public int? IdPais { get; set; }

        public string UF { get; set; }

        public string Municipio { get; set; }

        public string Bairro { get; set; }

        [Required]
        public string Logradouro { get; set; }

        public string Numero { get; set; }

        public string Complemento { get; set; }

        public string CEP { get; set; }

        public int CriadoPor { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime CriadoEm { get; set; }

        public int? AlteradoPor { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? AlteradoEm { get; set; }

        public virtual Usuario Usuario { get; set; }

        public virtual Pais Pais { get; set; }

        public virtual TipoEndereco TipoEndereco { get; set; }

        public virtual Pessoa Pessoa { get; set; }
    }
}
