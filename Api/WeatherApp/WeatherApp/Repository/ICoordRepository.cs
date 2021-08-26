using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeatherApp.Models.Dto;

namespace WeatherApp.Repository
{
    interface ICoordRepository
    {
        Task<CoordDto> GetCoordByPlaceid(int placeid);
    }
}
