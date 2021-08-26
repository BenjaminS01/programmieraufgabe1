using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeatherApp.Controllers
{
    [Route("/api/data")]
    public class ApiController : ControllerBase
    {
   
        [HttpGet]
        [Route("/place/{name}")]
        public IActionResult Get(string name)
        {
        }

        [HttpGet]
        [Route("/coord/{lat}/{lon}")]
        public IActionResult Get(double lat, double lon)
        {
        }
    }
