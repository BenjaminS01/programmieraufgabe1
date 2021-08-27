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
    public class WindRepository : IWindRepository
    {
        private readonly ApplicationDbContext _db;
        private IMapper _mapper;

        public WindRepository(ApplicationDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }
        public async Task<WindDto> GetWindByPlaceId(int placeId)
        {
            Wind wind = await _db.wind.Where(x => x.placeId == placeId).FirstOrDefaultAsync();
            return _mapper.Map<WindDto>(wind);
        }
    }
}
