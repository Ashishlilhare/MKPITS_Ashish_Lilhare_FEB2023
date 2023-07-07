namespace dropdownex2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Producttbl")]
    public partial class Producttbl
    {
        [Key]
        public int ProdcuctId { get; set; }

        [StringLength(50)]
        public string Prodname { get; set; }

        [StringLength(50)]
        public string categoryId { get; set; }
    }
}
