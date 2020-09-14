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

        [StringLength(49)]
        public string recipe_name { get; set; }

        public int? total_time_min { get; set; }

        [StringLength(8)]
        public string total_time_str { get; set; }

        [StringLength(703)]
        public string ingredients { get; set; }

        [StringLength(997)]
        public string directions { get; set; }

        public int? servings { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? cost { get; set; }

        [StringLength(27)]
        public string author { get; set; }

        [StringLength(148)]
        public string img_url { get; set; }

        [StringLength(14)]
        public string category { get; set; }
    }
}
