namespace Authoriun.EtherConsole.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Core.Pessoa")]
    public partial class Pessoa
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Pessoa()
        {
            Cliente = new HashSet<Cliente>();
            Contato = new HashSet<Contato>();
            Documento = new HashSet<Documento>();
            Endereco = new HashSet<Endereco>();
            Representante = new HashSet<Representante>();
            Requerente = new HashSet<Requerente>();
        }

        public int Id { get; set; }

        public int IdTenant { get; set; }

        public int IdTipoPessoa { get; set; }

        public int? IdPaisNacionalidade { get; set; }

        [Required]
        public string Nome { get; set; }

        public string NomeFantasia { get; set; }

        public string Pseudonimo { get; set; }

        public string NomeMae { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? Nascimento { get; set; }

        public string Naturalidade { get; set; }

        public string Ocupacao { get; set; }

        public string Escolaridade { get; set; }

        public int CriadoPor { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime CriadoEm { get; set; }

        public int? AlteradoPor { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? AlteradoEm { get; set; }

        public virtual Usuario Usuario { get; set; }

        public virtual Pais Pais { get; set; }

        public virtual TipoPessoa TipoPessoa { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cliente> Cliente { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Contato> Contato { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Documento> Documento { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Endereco> Endereco { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Representante> Representante { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Requerente> Requerente { get; set; }
    }
}
