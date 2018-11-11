namespace AuthoriunApi.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Core.ObraVinculo")]
    public partial class ObraVinculo
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public int IdTenant { get; set; }

        public int IdObra { get; set; }

        public bool? EhSupressaoConteudo { get; set; }

        public bool? EhAcrescimoConteudo { get; set; }

        public bool? EhPublicacao { get; set; }

        public bool? EhMudancaTitulo { get; set; }

        public bool? EhTransferenciaTitular { get; set; }

        public string Outros { get; set; }

        public int CriadoPor { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime CriadoEm { get; set; }

        public int? AlteradoPor { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? AlteradoEm { get; set; }

        public virtual Usuario Usuario { get; set; }

        public virtual Obra Obra { get; set; }
    }
}
