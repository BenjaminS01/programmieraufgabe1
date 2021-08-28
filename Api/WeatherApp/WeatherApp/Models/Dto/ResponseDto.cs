using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeatherApp.Models.Dto
{
    public class ResponseDto
    {
        public string name { get; set; }

        public string country { get; set; }

        public int cod { get; set; } = 200;
        
        public WindDto wind { get; set; }

        public MainDto main { get; set; }

        public CoordDto coord { get; set; }

        public List<WeatherDto> weather { get; set; }

        public List<string> errorMessages { get; set; }

    }
}
