namespace foodary.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("product")]
    public partial class product
    {
        public int ID { get; set; }

        [Required]
        [StringLength(10)]
        public string category { get; set; }

        [Required]
        [StringLength(38)]
        public string name { get; set; }
    }
}
