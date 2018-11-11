namespace AuthoriunApi.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Admin.LogAcao")]
    public partial class LogAcao
    {
        public int Id { get; set; }

        public int IdTenant { get; set; }
    }
}
