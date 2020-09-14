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
        [StringLength(9)]
        public string Country { get; set; }

        [Required]
        [StringLength(14)]
        public string Product { get; set; }

        [Required]
        [StringLength(4)]
        public string Currency { get; set; }

        [Required]
        [StringLength(5)]
        public string Measure { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Price { get; set; }
    }
}
