using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeatherApp.Models.Dto
{
    public class ResponseDto
    {
        public string name { get; set; }
        
        public WindDto wind { get; set; }

    }
}
