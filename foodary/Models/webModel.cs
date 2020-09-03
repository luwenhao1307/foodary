namespace foodary.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class webModel : DbContext
    {
        public webModel()
            : base("name=webModel1")
        {
        }

        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<FoodEvents> FoodEvents { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FoodEvents>()
                .Property(e => e.Longitude)
                .HasPrecision(11, 8);

            modelBuilder.Entity<FoodEvents>()
                .Property(e => e.Latitude)
                .HasPrecision(10, 8);

            modelBuilder.Entity<FoodEvents>()
                .Property(e => e.Category)
                .IsUnicode(false);

            modelBuilder.Entity<FoodEvents>()
                .Property(e => e.Timetable)
                .IsUnicode(false);
        }
    }
}
