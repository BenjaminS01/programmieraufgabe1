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
    public class PlaceRepository : IPlaceRepository
    {
        private readonly ApplicationDbContext _db;
        private IMapper _mapper;

        public PlaceRepository(ApplicationDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }


        public async Task<PlaceDto> GetPlaceByName(string placeName)
        {
            Place place = await _db.place.Where(x => EF.Functions.Like(x.name , placeName)).FirstOrDefaultAsync();
            return _mapper.Map<PlaceDto>(place);
        }

        public async Task<PlaceDto> GetPlaceById(int id)
        {
            Place place = await _db.place.Where(x => x.id == id).FirstOrDefaultAsync();
            return _mapper.Map<PlaceDto>(place);
        }
    }
}
