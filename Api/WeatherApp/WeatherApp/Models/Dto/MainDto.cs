using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeatherApp.Models.Dto
{
    public class MainDto
    {
        public int id { get; set; }

        public double feels_like { get; set; }

        public int humidity { get; set; }

        public int pressure { get; set; }

        public double temp { get; set; }

        public double temp_max { get; set; }

        public double temp_min { get; set; }

        public int placeId { get; set; }
    }
}
