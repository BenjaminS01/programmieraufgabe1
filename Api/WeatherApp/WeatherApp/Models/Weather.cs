using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WeatherApp.Models
{
    public class Weather
    {
        [Key]
        public int id { get; set; }

        [Column(TypeName = "varchar(100)")]
        public string description { get; set; }

        [Column(TypeName = "varchar(100)")]
        public string icon { get; set; }

        [Column(TypeName = "varchar(100)")]
        public string main { get; set; }

    }

}
