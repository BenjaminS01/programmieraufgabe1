using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WeatherApp.Models
{
    public class Main
    {
        [Key]
        [ForeignKey("Place")]
        public int id { get; set; }

        [Range(-100, 100)]
        [Column(TypeName = "decimal(5, 2)")]
        public double feels_like { get; set; }

        [Range(0, 100)]
        public int humidity { get; set; }

        [Range(0, 10000)]
        public int pressure { get; set; }

        [Range(-100, 100)]
        [Column(TypeName = "decimal(5, 2)")]
        public double temp { get; set; }

        [Range(-100, 100)]
        [Column(TypeName = "decimal(5, 2)")]
        public double temp_max { get; set; }

        [Range(-100, 100)]
        [Column(TypeName = "decimal(5, 2)")]
        public double temp_min { get; set; }

        public int placeId { get; set; }
        public Place place { get; set; }


    }
}
