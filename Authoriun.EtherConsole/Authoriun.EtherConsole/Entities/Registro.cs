namespace Authoriun.EtherConsole.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Core.Registro")]
    public partial class Registro
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Registro()
        {
            RegistroTransmissao = new HashSet<RegistroTransmissao>();
        }

        public int Id { get; set; }

        public int IdTenant { get; set; }

        public int IdObra { get; set; }

        public int IdArquivo { get; set; }

        public string HashTransacao { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime SolicitadoEm { get; set; }

        public int Status { get; set; }

        public int CriadoPor { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime CriadoEm { get; set; }

        public int? AlteradoPor { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? AlteradoEm { get; set; }

        public virtual Usuario Usuario { get; set; }

        public virtual Arquivo Arquivo { get; set; }

        public virtual Obra Obra { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RegistroTransmissao> RegistroTransmissao { get; set; }
    }
}
