using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeatherApp.Models.Dto
{
    public class WindDto
    {    
        public int id { get; set; }

        public int deg { get; set; }

        public float speed { get; set; }

        public int placeId { get; set; }

    }
}
