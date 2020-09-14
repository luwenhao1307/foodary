namespace foodary.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class food_price_model : DbContext
    {
        public food_price_model()
            : base("name=food_price_model")
        {
        }

        public virtual DbSet<food_price> food_price { get; set; }

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
                .Property(e => e.Price)
                .HasPrecision(12, 1);
        }
    }
}
