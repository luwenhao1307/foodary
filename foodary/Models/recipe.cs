namespace foodary.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class recipe
    {
        public int ID { get; set; }

        [StringLength(100)]
        public string recipe_name { get; set; }

        public int? total_time_min { get; set; }

        [StringLength(20)]
        public string total_time_str { get; set; }

        [StringLength(1000)]
        public string ingredients { get; set; }

        [StringLength(1200)]
        public string directions { get; set; }

        public int? servings { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? cost { get; set; }

        [StringLength(50)]
        public string author { get; set; }

        [StringLength(200)]
        public string img_url { get; set; }

        [StringLength(25)]
        public string category { get; set; }
    }
}
