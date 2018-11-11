namespace AuthoriunApi.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Core.RegistroTransmissao")]
    public partial class RegistroTransmissao
    {
        public int Id { get; set; }

        public int IdTenant { get; set; }

        public int IdRegistro { get; set; }

        [Required]
        public string HashTransacao { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? EnviadoEm { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? ConcluidoEm { get; set; }

        public string De { get; set; }

        public string Para { get; set; }

        public string Bloco { get; set; }

        public decimal? Valor { get; set; }

        public int? GasLimite { get; set; }

        public int? GasUsado { get; set; }

        public decimal? GasPreco { get; set; }

        public decimal? CustoFinal { get; set; }

        public int? Nonce { get; set; }

        public int? Posicao { get; set; }

        public string DadoEnviado { get; set; }

        public string NotaPrivada { get; set; }

        public string Status { get; set; }

        public string Mensagem { get; set; }

        public int CriadoPor { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime CriadoEm { get; set; }

        public int? AlteradoPor { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? AlteradoEm { get; set; }

        public virtual Usuario Usuario { get; set; }

        public virtual Registro Registro { get; set; }
    }
}
