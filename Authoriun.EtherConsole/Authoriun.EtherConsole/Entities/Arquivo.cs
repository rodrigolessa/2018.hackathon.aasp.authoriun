namespace Authoriun.EtherConsole.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Core.Arquivo")]
    public partial class Arquivo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Arquivo()
        {
            Registro = new HashSet<Registro>();
        }

        public int Id { get; set; }

        public int IdTenant { get; set; }

        public int IdObra { get; set; }

        [Required]
        public string Nome { get; set; }

        public string Extensao { get; set; }

        public string Mime { get; set; }

        [Required]
        public string Tamanho { get; set; }

        [Required]
        public string MD5 { get; set; }

        [Required]
        public string SHA256 { get; set; }

        [Required]
        public string SHA512 { get; set; }

        public string JWTCertificado { get; set; }

        public string JWTChavePublica { get; set; }

        public int CriadoPor { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime CriadoEm { get; set; }

        public int? AlteradoPor { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? AlteradoEm { get; set; }

        public virtual Usuario Usuario { get; set; }

        public virtual Obra Obra { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Registro> Registro { get; set; }
    }
}
