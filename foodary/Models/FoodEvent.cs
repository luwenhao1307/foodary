namespace foodary.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FoodEvent
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string What { get; set; }

        public string Address { get; set; }

        public string Suburb { get; set; }

        public long Phone { get; set; }

        public string Website { get; set; }

        public string Monday { get; set; }

        public string Tuesday { get; set; }

        public string Wednesday { get; set; }

        public string Thursday { get; set; }

        public string Friday { get; set; }

        public string Saturday { get; set; }

        public string Sunday { get; set; }

        public string Public_holidays { get; set; }

        public string Cost { get; set; }

        public decimal Longitude { get; set; }

        public decimal Latitude { get; set; }

        public string Geocoded_location { get; set; }
    }
}
