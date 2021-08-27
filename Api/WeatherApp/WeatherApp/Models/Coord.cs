using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WeatherApp.Models
{
    public class Coord
    {
        [Key]
        public int id { get; set; }

        [Range(0, 360)]
        [Column(TypeName = "decimal(7, 4)")]
        public double lat { get; set; }

        [Column(TypeName = "decimal(7, 4)")]
        public double lon { get; set; }

        public Place place { get; set; }

        public int placeId { get; set; }

        
    }
}
