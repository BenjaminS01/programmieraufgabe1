﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeatherApp.Models.Dto;

namespace WeatherApp.Repository
{
    public interface ICoordRepository
    {
        Task<CoordDto> GetCoordByLatAndLon(double lat, double lon);

        Task<CoordDto> GetCoordByPlaceId(int placeId);
    }
}
