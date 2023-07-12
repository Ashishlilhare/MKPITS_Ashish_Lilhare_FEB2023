using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace curd.Controllers
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<tblState> tblStates { get; set; }
        public virtual DbSet<tblCity> tblCities { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<tblState>()
                .HasMany(e => e.tblCities)
                .WithRequired(e => e.tblState)
                .WillCascadeOnDelete(false);
        }
    }
}
