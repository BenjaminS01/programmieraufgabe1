using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeatherApp.Models.Dto;

namespace WeatherApp.Controllers
{
    [Route("/api/data")]
    public class ApiController : ControllerBase
    {

        [HttpGet]
        [Route("/place/{name}")]
        public ResponseDto Get(string name)
        {
            WindDto x = new WindDto();
                x.id = 1;
            x.placeId = 2;
            x.speed = 100;
            x.deg = 5;

            ResponseDto res = new ResponseDto();
            res.name = "test";
            res.wind = x;

            return res;
        }

        [HttpGet]
        [Route("/coord/{lat}/{lon}")]
        public ResponseDto Get(double lat, double lon)
        {
            ResponseDto res = new ResponseDto();
            res.name = "test";

            return res;
        }
    }
}
