using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeatherApp.DbContexts;
using WeatherApp.Models.Dto;

namespace WeatherApp.Repository
{
    public class CoordRepository : ICoordRepository
    {
        private readonly ApplicationDbContext _db;
        private IMapper _mapper;

        public CoordRepository(ApplicationDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        public async Task<CoordDto> GetCoordByLatAndLon(int lat, int lon)
        {
            throw new NotImplementedException();
        }
    }
}
