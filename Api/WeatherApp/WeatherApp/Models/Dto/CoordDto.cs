using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeatherApp.Models.Dto
{
    public class CoordDto
    {
        public int id { get; set; }

        public double lat { get; set; }

        public double lon { get; set; }

        public int placeId { get; set; }
    }
}
