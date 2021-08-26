using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeatherApp.Models.Dto;

namespace WeatherApp.Repository
{
    interface IWeatherRepository
    {
        Task<WeatherDto> GetWeatherByPlaceid(int placeid);
    }
}
