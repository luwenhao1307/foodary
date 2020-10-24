namespace foodary.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class final : DbContext
    {
        public final()
            : base("name=final")
        {
        }

        public virtual DbSet<food_price> food_price { get; set; }
        public virtual DbSet<FoodEventSet> FoodEventSets { get; set; }
        public virtual DbSet<product> products { get; set; }
        public virtual DbSet<recipe> recipes { get; set; }
        public virtual DbSet<recipes_budget> recipes_budget { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<food_price>()
                .Property(e => e.Country)
                .IsUnicode(false);

            modelBuilder.Entity<food_price>()
                .Property(e => e.Product)
                .IsUnicode(false);

            modelBuilder.Entity<food_price>()
                .Property(e => e.Currency)
                .IsUnicode(false);

            modelBuilder.Entity<food_price>()
                .Property(e => e.Measure)
                .IsUnicode(false);

            modelBuilder.Entity<food_price>()
                .Property(e => e.Price_local)
                .HasPrecision(12, 2);

            modelBuilder.Entity<food_price>()
                .Property(e => e.Price)
                .HasPrecision(12, 2);

            modelBuilder.Entity<food_price>()
                .Property(e => e.Category)
                .IsUnicode(false);

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

            modelBuilder.Entity<product>()
                .Property(e => e.category)
                .IsUnicode(false);

            modelBuilder.Entity<product>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<recipe>()
                .Property(e => e.recipe_name)
                .IsUnicode(false);

            modelBuilder.Entity<recipe>()
                .Property(e => e.total_time_str)
                .IsUnicode(false);

            modelBuilder.Entity<recipe>()
                .Property(e => e.ingredients)
                .IsUnicode(false);

            modelBuilder.Entity<recipe>()
                .Property(e => e.directions)
                .IsUnicode(false);

            modelBuilder.Entity<recipe>()
                .Property(e => e.cost)
                .HasPrecision(8, 1);

            modelBuilder.Entity<recipe>()
                .Property(e => e.author)
                .IsUnicode(false);

            modelBuilder.Entity<recipe>()
                .Property(e => e.img_url)
                .IsUnicode(false);

            modelBuilder.Entity<recipe>()
                .Property(e => e.category)
                .IsUnicode(false);

            modelBuilder.Entity<recipes_budget>()
                .Property(e => e.recipe_name)
                .IsUnicode(false);

            modelBuilder.Entity<recipes_budget>()
                .Property(e => e.total_time_str)
                .IsUnicode(false);

            modelBuilder.Entity<recipes_budget>()
                .Property(e => e.ingredients)
                .IsUnicode(false);

            modelBuilder.Entity<recipes_budget>()
                .Property(e => e.directions)
                .IsUnicode(false);

            modelBuilder.Entity<recipes_budget>()
                .Property(e => e.cost)
                .HasPrecision(5, 1);

            modelBuilder.Entity<recipes_budget>()
                .Property(e => e.cost_p_s)
                .HasPrecision(5, 1);

            modelBuilder.Entity<recipes_budget>()
                .Property(e => e.author)
                .IsUnicode(false);

            modelBuilder.Entity<recipes_budget>()
                .Property(e => e.img_url)
                .IsUnicode(false);

            modelBuilder.Entity<recipes_budget>()
                .Property(e => e.category)
                .IsUnicode(false);

            modelBuilder.Entity<recipes_budget>()
                .Property(e => e.is_breakfast)
                .IsUnicode(false);
        }
    }
}
