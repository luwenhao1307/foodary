namespace foodary.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class food_price
    {
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Country { get; set; }

        [Required]
        [StringLength(40)]
        public string Product { get; set; }

        [Required]
        [StringLength(5)]
        public string Currency { get; set; }

        [Required]
        [StringLength(20)]
        public string Measure { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Price_local { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Price { get; set; }

        [Required]
        [StringLength(20)]
        public string Category { get; set; }
    }
}
