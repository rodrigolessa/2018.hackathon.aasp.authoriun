namespace AuthoriunApi.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Admin.LogAuditoria")]
    public partial class LogAuditoria
    {
        public int Id { get; set; }

        public int IdTenant { get; set; }
    }
}
