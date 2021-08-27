using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeatherApp.Models.Dto
{
    public class WeatherDto
    {

        public int id { get; set; }

        public string description { get; set; }

        public string icon { get; set; }

        public string main { get; set; }
    }
}
