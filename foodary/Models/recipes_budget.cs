namespace foodary.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class recipes_budget
    {
        public int ID { get; set; }

        [StringLength(100)]
        public string recipe_name { get; set; }

        public int? total_time_min { get; set; }

        [StringLength(20)]
        public string total_time_str { get; set; }

        [StringLength(1500)]
        public string ingredients { get; set; }

        [StringLength(1500)]
        public string directions { get; set; }

        public int? servings { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? cost { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? cost_p_s { get; set; }

        [StringLength(50)]
        public string author { get; set; }

        [StringLength(200)]
        public string img_url { get; set; }

        [StringLength(25)]
        public string category { get; set; }

        [StringLength(10)]
        public string is_breakfast { get; set; }

    }
}
