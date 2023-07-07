namespace dropdownex2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Categorytbl")]
    public partial class Categorytbl
    {
        [Key]
        public int categoryId { get; set; }

        [StringLength(50)]
        public string category { get; set; }
    }
}
