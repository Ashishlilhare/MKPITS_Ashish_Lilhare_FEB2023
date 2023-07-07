using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace dropdownex2.Models
{
    public partial class StoreModel1 : DbContext
    {
        public StoreModel1()
            : base("name=StoreModel1")
        {
        }

        public virtual DbSet<Categorytbl> Categorytbls { get; set; }
        public virtual DbSet<Producttbl> Producttbls { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
