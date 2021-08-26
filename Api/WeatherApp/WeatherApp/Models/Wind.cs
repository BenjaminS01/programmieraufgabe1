using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WeatherApp.Models
{
    public class Wind
    {
        [Key]
        [ForeignKey("Place")]
        public int id { get; set; }

        [Range(0,360)]
        public int deg { get; set; }

        [Column(TypeName = "decimal(5, 2)")]
        public double speed { get; set; }

        public int placeId { get; set; }
        public Place place { get; set; }
    }
}
