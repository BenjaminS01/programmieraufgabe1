using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeatherApp.Models.Dto;

namespace WeatherApp.Repository
{
    public interface IWindRepository
    {
        Task<WindDto> GetWindByPlaceId(int placeId);
    }
}
