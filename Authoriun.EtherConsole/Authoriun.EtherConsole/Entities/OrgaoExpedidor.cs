namespace Authoriun.EtherConsole.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Config.OrgaoExpedidor")]
    public partial class OrgaoExpedidor
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OrgaoExpedidor()
        {
            Documento = new HashSet<Documento>();
        }

        public int Id { get; set; }

        public int IdTenant { get; set; }

        [Required]
        public string Descricao { get; set; }

        public string Sigla { get; set; }

        public virtual Usuario Usuario { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Documento> Documento { get; set; }
    }
}
