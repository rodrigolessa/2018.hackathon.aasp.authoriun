namespace Authoriun.EtherConsole.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Core.RequerenteObra")]
    public partial class RequerenteObra
    {
        public int Id { get; set; }

        public int IdTenant { get; set; }

        public int IdRequerente { get; set; }

        public int IdObra { get; set; }

        public bool? EhAutor { get; set; }

        public bool? EhAdaptador { get; set; }

        public bool? EhCessionario { get; set; }

        public bool? EhTradutor { get; set; }

        public bool? EhIlustrador { get; set; }

        public bool? EhOrganizador { get; set; }

        public bool? EhFotografo { get; set; }

        public bool? EhRepresentante { get; set; }

        public bool? EhCedente { get; set; }

        public bool? EhHerdeiro { get; set; }

        public bool? EhInventariante { get; set; }

        public bool? EhEditor { get; set; }

        public int CriadoPor { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime CriadoEm { get; set; }

        public int? AlteradoPor { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? AlteradoEm { get; set; }

        public virtual Usuario Usuario { get; set; }

        public virtual Obra Obra { get; set; }

        public virtual Requerente Requerente { get; set; }
    }
}
