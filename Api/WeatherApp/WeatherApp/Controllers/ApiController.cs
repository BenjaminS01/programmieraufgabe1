using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeatherApp.Models.Dto;
using WeatherApp.Repository;

namespace WeatherApp.Controllers
{
    [Route("/api/data")]
    public class ApiController : ControllerBase
    {

        public IPlaceRepository _placeRepository;
        public IWeatherRepository _weatherRepository;
        public IWindRepository _windRepository;


       public ApiController(IPlaceRepository placeRepository, IWeatherRepository weatherRepository, IWindRepository windRepository)
        {
            this._placeRepository = placeRepository;
            this._weatherRepository = weatherRepository;
            this._windRepository = windRepository;

            
        }


        [HttpGet]
        [Route("/place/{name}")]
        public async Task<object> Get(string name)
        {
            /**
            WindDto x = new WindDto();
                x.id = 1;
            x.placeId = 2;
            x.speed = 100;
            x.deg = 5;

            ResponseDto res = new ResponseDto();
            res.name = "test";
            res.wind = x;
            */

            PlaceDto placeDto = await _placeRepository.GetPlaceByName(name);
            // WeatherDto weatherDto = await _weatherRepository.GetWeatherByPlaceId(1);
            WindDto windDto = await _windRepository.GetWindByPlaceId(placeDto.id);



            return windDto;
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
