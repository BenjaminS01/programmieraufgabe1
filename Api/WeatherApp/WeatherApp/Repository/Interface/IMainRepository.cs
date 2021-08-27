﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeatherApp.Models.Dto;

namespace WeatherApp.Repository
{
    public interface IMainRepository
    {
        Task<MainDto> GetMainByPlaceId(int placeId);
    }
}
