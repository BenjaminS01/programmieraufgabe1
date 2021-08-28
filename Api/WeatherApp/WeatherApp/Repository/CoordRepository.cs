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
    public class CoordRepository : ICoordRepository
    {
        private readonly ApplicationDbContext _db;
        private IMapper _mapper;

        public CoordRepository(ApplicationDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        public async Task<CoordDto> GetCoordByLatAndLon(double lat, double lon)
        {
            ////////////////// attempt 1: only exact coords
            //Coord coord = await _db.coord.Where(x => x.lat == lat && x.lon == lon).FirstOrDefaultAsync(); 
            //////////////////////////////////////////


            //////////// attempt 2 (doesn't work):  search a coord which fall within a radius of a central point 
            /*
             * https://stackoverflow.com/questions/7783684/select-coordinates-which-fall-within-a-radius-of-a-central-point
             * 
             SELECT * FROM Table1 a 
                WHERE (
                 acos(sin(a.Latitude * 0.0175) * sin(YOUR_LATITUDE_X * 0.0175) 
                   + cos(a.Latitude * 0.0175) * cos(YOUR_LATITUDE_X * 0.0175) *    
                 cos((YOUR_LONGITUDE_Y * 0.0175) - (a.Longitude * 0.0175))
              ) * 3959 <= YOUR_RADIUS_INMILES
             )

            const int radius = 200; // in Miles

            Coord coord = await _db.coord.Where(x => MathF.Acos(MathF.Sin((float)(x.lat * 0.0175)) * MathF.Sin((float)(lat * 0.0175))
               + MathF.Cos((float)(x.lat * 0.0175)) * MathF.Cos((float)(lat * 0.0175)) *
                 MathF.Cos((float)((lon * 0.0175) - (x.lon * 0.0175)))
              ) * 3959 <= radius).FirstOrDefaultAsync(); 
            */




            // attempt 3: calculate the distance between the points and the centre of a square

            const int distance = 10; // in degrees

            Coord coord = await _db.coord.Where(x => lon < x.lon + distance && lon > x.lon - distance &&
            lat < x.lat + distance && lat > x.lat - distance).FirstOrDefaultAsync();

           
            return _mapper.Map<CoordDto>(coord);


        }

        public async Task<CoordDto> GetCoordByPlaceId(int placeId)
        {
            Coord coord = await _db.coord.Where(x => x.placeId == placeId).FirstOrDefaultAsync();
            return _mapper.Map<CoordDto>(coord);
        }
    }
}
