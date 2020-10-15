namespace foodary.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class FoodaryCloud : DbContext
    {
        public FoodaryCloud()
            : base("name=foodaryCloud")
        {
        }

        public virtual DbSet<product> products { get; set; }
        public virtual DbSet<recipes_budget> recipes_budget { get; set; }

    }
}
