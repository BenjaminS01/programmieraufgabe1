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
        public ICoordRepository _coordRepository;
        public IMainRepository _mainRepository;

        public ApiController(IPlaceRepository placeRepository, IWeatherRepository weatherRepository 
            ,IWindRepository windRepository, ICoordRepository coordRepository, IMainRepository mainRepository)
        {
            this._placeRepository = placeRepository;
            this._weatherRepository = weatherRepository;
            this._windRepository = windRepository;
            this._coordRepository = coordRepository;
            this._mainRepository = mainRepository;
            
        }


        [HttpGet]
        [Route("/place/{name}")]
        public async Task<object> Get(string name)
        {
            ResponseDto response = new ResponseDto();

            PlaceDto placeDto = await _placeRepository.GetPlaceByName(name);
            response.name = placeDto.name;

            response.weather = await _weatherRepository.GetWeatherById(placeDto.weatherId);
            response.wind = await _windRepository.GetWindByPlaceId(placeDto.id);
            response.coord = await _coordRepository.GetCoordByPlaceId(placeDto.id);
            response.main = await _mainRepository.GetMainByPlaceId(placeDto.id);

            Object data = response;
            return data;
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
