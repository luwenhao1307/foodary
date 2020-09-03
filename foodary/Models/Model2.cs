namespace foodary.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model2 : DbContext
    {
        public Model2()
            : base("name=Model2")
        {
        }

        public virtual DbSet<FoodEventSet> FoodEventSet { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FoodEventSet>()
                .Property(e => e.Longitude)
                .HasPrecision(18, 10);

            modelBuilder.Entity<FoodEventSet>()
                .Property(e => e.Latitude)
                .HasPrecision(18, 10);

            modelBuilder.Entity<FoodEventSet>()
                .Property(e => e.Timetable)
                .IsUnicode(false);

            modelBuilder.Entity<FoodEventSet>()
                .Property(e => e.Category)
                .IsUnicode(false);
        }
    }
}
