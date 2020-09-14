namespace foodary.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model3 : DbContext
    {
        public Model3()
            : base("name=Model3")
        {
        }

        public virtual DbSet<product> products { get; set; }
        public virtual DbSet<recipe> recipes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
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
                .HasPrecision(3, 1);

            modelBuilder.Entity<recipe>()
                .Property(e => e.author)
                .IsUnicode(false);

            modelBuilder.Entity<recipe>()
                .Property(e => e.img_url)
                .IsUnicode(false);

            modelBuilder.Entity<recipe>()
                .Property(e => e.category)
                .IsUnicode(false);
        }
    }
}
