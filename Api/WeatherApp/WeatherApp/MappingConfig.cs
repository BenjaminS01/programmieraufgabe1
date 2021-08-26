using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeatherApp.Models;
using WeatherApp.Models.Dto;

namespace WeatherApp
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Place, PlaceDto>();
                cfg.CreateMap<Coord, CoordDto>();
                cfg.CreateMap<Weather, WeatherDto>();
                cfg.CreateMap<Wind, WindDto>();
                cfg.CreateMap<Main, MainDto>();
            });

           return config;
        }
    }
       
    
}
