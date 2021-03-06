namespace foodary.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Foodevents")
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
