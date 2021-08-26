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
        public int id { get; set; }

        [Range(-100, 100)]
        [Column(TypeName = "decimal(5, 2)")]
        public float feels_like { get; set; }

        [Range(0, 100)]
        public int humidity { get; set; }

        [Range(0, 10000)]
        public int pressure { get; set; }

        [Range(-100, 100)]
        [Column(TypeName = "decimal(5, 2)")]
        public float temp { get; set; }

        [Range(-100, 100)]
        [Column(TypeName = "decimal(5, 2)")]
        public float temp_max { get; set; }

        [Range(-100, 100)]
        [Column(TypeName = "decimal(5, 2)")]
        public float temp_min { get; set; }

        public virtual Place place { get; set; }

    }
}
