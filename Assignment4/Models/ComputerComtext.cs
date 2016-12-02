namespace Assignment4.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ComputerComtext : DbContext
    {
        public ComputerComtext()
            : base("name=ComputerConnection")
        {
        }

        public virtual DbSet<table> tables { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<table>()
                .Property(e => e.cost)
                .HasPrecision(19, 4);
        }
    }
}
