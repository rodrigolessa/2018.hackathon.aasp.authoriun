namespace AuthoriunApi.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Core.Obra")]
    public partial class Obra
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Obra()
        {
            Arquivo = new HashSet<Arquivo>();
            ObraVinculo = new HashSet<ObraVinculo>();
            Registro = new HashSet<Registro>();
            RequerenteObra = new HashSet<RequerenteObra>();
        }

        public int Id { get; set; }

        public int IdTenant { get; set; }

        public int IdGeneroObra { get; set; }

        public bool? EhRequerimento { get; set; }

        public bool? EhAverbacao { get; set; }

        public bool? EhInedita { get; set; }

        public bool? EhPublicada { get; set; }

        [Required]
        public string Titulo { get; set; }

        public string Grafica { get; set; }

        public string Editora { get; set; }

        public string Ano { get; set; }

        public string Volume { get; set; }

        public string Edicao { get; set; }

        public string LocalPublicacao { get; set; }

        public int? Paginas { get; set; }

        public string AdaptacaoTituloOriginal { get; set; }

        public string AdaptacaoAutorOriginal { get; set; }

        public string TraducaoTituloOriginal { get; set; }

        public string TraducaoAutorOriginal { get; set; }

        public string Observacoes { get; set; }

        public int CriadoPor { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime CriadoEm { get; set; }

        public int? AlteradoPor { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? AlteradoEm { get; set; }

        public virtual Usuario Usuario { get; set; }

        public virtual GeneroObra GeneroObra { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Arquivo> Arquivo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ObraVinculo> ObraVinculo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Registro> Registro { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RequerenteObra> RequerenteObra { get; set; }
    }
}
