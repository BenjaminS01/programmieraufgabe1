using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeatherApp.DbContexts;
using WeatherApp.Models;
using WeatherApp.Models.Dto;

namespace WeatherApp.Repository
{
    public class WeatherRepository : IWeatherRepository
    {

        private readonly ApplicationDbContext _db;
        private IMapper _mapper;

        public WeatherRepository(ApplicationDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        public async Task<List<WeatherDto>> GetWeatherById(int id)
        {
            List<Weather> weather = await _db.weather.Where(x => x.id == id).ToListAsync();
            return _mapper.Map<List<WeatherDto>>(weather);
        }
    }
}
