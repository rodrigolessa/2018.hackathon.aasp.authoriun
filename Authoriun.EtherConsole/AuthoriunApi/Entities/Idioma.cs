namespace AuthoriunApi.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Config.Idioma")]
    public partial class Idioma
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Idioma()
        {
            GeneroObraDescricao = new HashSet<GeneroObraDescricao>();
            PaisDescricao = new HashSet<PaisDescricao>();
            TipoContatoDescricao = new HashSet<TipoContatoDescricao>();
            TipoDocumentoDescricao = new HashSet<TipoDocumentoDescricao>();
            TipoEnderecoDescricao = new HashSet<TipoEnderecoDescricao>();
            TipoPessoaDescricao = new HashSet<TipoPessoaDescricao>();
        }

        public int Id { get; set; }

        public int IdTenant { get; set; }

        [Required]
        public string Descricao { get; set; }

        [StringLength(2)]
        public string ISO639Alfa2 { get; set; }

        [StringLength(3)]
        public string ISO639Alfa3 { get; set; }

        public string HtmlCode { get; set; }

        public bool? Ativo { get; set; }

        public virtual Usuario Usuario { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GeneroObraDescricao> GeneroObraDescricao { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PaisDescricao> PaisDescricao { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TipoContatoDescricao> TipoContatoDescricao { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TipoDocumentoDescricao> TipoDocumentoDescricao { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TipoEnderecoDescricao> TipoEnderecoDescricao { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TipoPessoaDescricao> TipoPessoaDescricao { get; set; }
    }
}
