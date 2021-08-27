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
    public class MainRepository : IMainRepository
    {
        private readonly ApplicationDbContext _db;
        private IMapper _mapper;

        public MainRepository(ApplicationDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        public async Task<MainDto> GetMainByPlaceId(int placeId)
        {
            Main main = await _db.main.Where(x => x.placeId == placeId).FirstOrDefaultAsync();
            return _mapper.Map<MainDto>(main);
        }
    }
}
