using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeatherApp.Models;

namespace WeatherApp.DbContexts
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Coord> coord { get; set; }

        public DbSet<Main> main { get; set; }

        public DbSet<Place> place { get; set; }

        public DbSet<Weather> weather { get; set; }

        public DbSet<Wind> wind { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Place>().HasData(
               new Place
               {
                   id = 1,
                   name = "Erfurt",
                   weatherId = 2
               }
            );
            modelBuilder.Entity<Place>().HasData(
              new Place
              {
                  id = 2,
                  name = "Essen",
                  weatherId = 1
              }
           );
            modelBuilder.Entity<Place>().HasData(
            new Place
            {
                id = 3,
                name = "Eisenach",
                weatherId = 2
            }
         );

            modelBuilder.Entity<Place>().HasData(
            new Place
            {
                id = 4,
                name = "Stotternheim",
                weatherId = 5
            }
         );
            modelBuilder.Entity<Place>().HasData(
            new Place
            {
                id = 5,
                name = "Ibiza",
                weatherId = 5
            }
         );
            modelBuilder.Entity<Place>().HasData(
            new Place
            {
                id = 6,
                name = "Hanoi",
                weatherId = 4
            }
         );
            modelBuilder.Entity<Place>().HasData(
            new Place
            {
                id = 7,
                name = "New York",
                weatherId = 1
            }
         );
            modelBuilder.Entity<Place>().HasData(
            new Place
            {
                id = 8,
                name = "Ort",
                weatherId = 3
            }
         );
            modelBuilder.Entity<Place>().HasData(
            new Place
            {
                id = 9,
                name = "noch ein Ort",
                weatherId = 2
            }
         );
            modelBuilder.Entity<Place>().HasData(
            new Place
            {
                id = 10,
                name = "irgendwo",
                weatherId = 1
            }
         );


            ///////////////wind

            modelBuilder.Entity<Wind>().HasData(
            new Wind
            {
                id = 1,
                deg = 1,
                speed = 10,
                placeId = 1
            }
            );
            modelBuilder.Entity<Wind>().HasData(
              new Wind
              {
                  id = 2,
                  deg = 11,
                  speed = 101,
                  placeId = 2
              }
           );
            modelBuilder.Entity<Wind>().HasData(
            new Wind
            {
                id = 3,
                deg = 23,
                speed = 121,
                placeId = 3
            }
         );

            modelBuilder.Entity<Wind>().HasData(
            new Wind
            {
                id = 4,
                deg = 43,
                speed = 131,
                placeId = 4
            }
         );
            modelBuilder.Entity<Wind>().HasData(
            new Wind
            {
                id = 5,
                deg = 63,
                speed = 111,
                placeId = 5
            }
         );
            modelBuilder.Entity<Wind>().HasData(
            new Wind
            {
                id = 6,
                deg = 73,
                speed = 11,
                placeId = 6
            }
         );
            modelBuilder.Entity<Wind>().HasData(
            new Wind
            {
                id = 7,
                deg = 89,
                speed = 2,
                placeId = 7
            }
         );
            modelBuilder.Entity<Wind>().HasData(
            new Wind
            {
                id = 8,
                deg = 43,
                speed = 31,
                placeId = 8
            }
         );
            modelBuilder.Entity<Wind>().HasData(
            new Wind
            {
                id = 9,
                deg = 4,
                speed = 131,
                placeId = 9
            }
         );
            modelBuilder.Entity<Wind>().HasData(
            new Wind
            {
                id = 10,
                deg = 3,
                speed = 31,
                placeId = 10
            }
         );

            /////////////////////Main


            modelBuilder.Entity<Main>().HasData(
            new Main
            {
                id = 1,
                humidity = 55,
                pressure = 101,
                temp = 22.22,
                temp_max = 23.10,
                temp_min = 20.00,
                placeId = 1
            }
            );
            modelBuilder.Entity<Main>().HasData(
              new Main
              {
                  id = 2,
                  humidity = 55,
                  pressure = 101,
                  temp = 22.22,
                  temp_max = 232.11,
                  temp_min = 20.00,
                  placeId = 2
              }
           );
            modelBuilder.Entity<Main>().HasData(
            new Main
            {
                id = 3,
                humidity = 55,
                pressure = 1,
                temp = 2.22,
                temp_max = 132.11,
                temp_min = 20.00,
                placeId = 3
            }
         );

            modelBuilder.Entity<Main>().HasData(
            new Main
            {
                id = 4,
                humidity = 55,
                pressure = 11,
                temp = 22.23,
                temp_max = 232.11,
                temp_min = 20.10,
                placeId = 4
            }
         );
            modelBuilder.Entity<Main>().HasData(
            new Main
            {
                id = 5,
                humidity = 55,
                pressure = 101,
                temp = 21.22,
                temp_max = 32.11,
                temp_min = 20.00,
                placeId = 5
            }
         );
            modelBuilder.Entity<Main>().HasData(
            new Main
            {
                id = 6,
                humidity = 51,
                pressure = 23,
                temp = 22.22,
                temp_max = 232.11,
                temp_min = 22.00,
                placeId = 6
            }
         );
            modelBuilder.Entity<Main>().HasData(
            new Main
            {
                id = 7,
                humidity = 55,
                pressure = 1,
                temp = 2,
                temp_max = 232.11,
                temp_min = 20.00,
                placeId = 7
            }
         );
            modelBuilder.Entity<Main>().HasData(
            new Main
            {
                id = 8,
                humidity = 55,
                pressure = 101,
                temp = 22.22,
                temp_max = 34.11,
                temp_min = 2.00,
                placeId = 8
            }
         );
            modelBuilder.Entity<Main>().HasData(
            new Main
            {
                id = 9,
                humidity = 77,
                pressure = 10,
                temp = 22.22,
                temp_max = 232.11,
                temp_min = 20.00,
                placeId = 9
            }
         );
            modelBuilder.Entity<Main>().HasData(
            new Main
            {
                id = 10,
                humidity = 55,
                pressure = 101,
                temp = 22.22,
                temp_max = 232.11,
                temp_min = 20.00,
                placeId = 10
            }
         );


            /////////////weather
            ///
            modelBuilder.Entity<Weather>().HasData(
            new 
            {
                id = 1,
                description = "broken clouds",
                icon = "02",
                main = "Snow"
            }
            );
            modelBuilder.Entity<Weather>().HasData(
              new 
              {
                  id = 2,
                  description = "broken clouds",
                  icon = "01",
                  main = "Clouds"
              }
           );
            modelBuilder.Entity<Weather>().HasData(
            new 
            {
                id = 3,
                description = "broken clouds",
                icon = "02",
                main = "Clouds"
            }
         );

            modelBuilder.Entity<Weather>().HasData(
            new 
            {
                id = 4,
                description = "broken clouds",
                icon = "03",
                main = "Snow"
            }
         );
            modelBuilder.Entity<Weather>().HasData(
            new 
            {
                id = 5,
                description = "broken clouds",
                icon = "02",
                main = "Rain"
            }
         );
            modelBuilder.Entity<Weather>().HasData(
            new 
            {
                id = 6,
                description = "broken clouds",
                icon = "01",
                main = "Clouds"
            }
         );
            modelBuilder.Entity<Weather>().HasData(
            new 
            {
                id = 7,
                description = "broken clouds",
                icon = "04",
                main = "Rain"
            }
         );
            modelBuilder.Entity<Weather>().HasData(
            new 
            {
                id = 8,
                description = "broken clouds",
                icon = "03",
                main = "Sun"
            }
         );
            modelBuilder.Entity<Weather>().HasData(
            new 
            {
                id = 9,
                description = "broken clouds",
                icon = "02",
                main = "Clouds"
            }
         );
            modelBuilder.Entity<Weather>().HasData(
            new 
            {
                id = 10,
                description = "broken clouds",
                icon = "01",
                main = "Clouds"
            }
         );


            ///////////////Coord
            ///
            modelBuilder.Entity<Coord>().HasData(
             new
            {
                id = 1,
                 lat = 101.1,
                 lon = 104.2,
                 placeId = 1
            }
            );
            modelBuilder.Entity<Coord>().HasData(
              new
              {
                  id = 2,
                  lat = 210.1,
                  lon = 10.2,
                  placeId = 2
              }
           );
            modelBuilder.Entity<Coord>().HasData(
            new
            {
                id = 3,
                lat = 102.1,
                lon = 10.22,
                placeId = 3
            }
         );

            modelBuilder.Entity<Coord>().HasData(
            new
            {
                id = 4,
                lat = 102.1,
                lon = 102.2,
                placeId = 4
            }
         );
            modelBuilder.Entity<Coord>().HasData(
            new
            {
                id = 5,
                lat = 110.1,
                lon = 110.2,
                placeId = 5
            }
         );
            modelBuilder.Entity<Coord>().HasData(
            new
            {
                id = 6,
                lat = 10.12,
                lon = 141.2,
                placeId = 6
            }
         );
            modelBuilder.Entity<Coord>().HasData(
            new
            {
                id = 7,
                lat = 10.1,
                lon = 14.2,
                placeId = 7
            }
         );
            modelBuilder.Entity<Coord>().HasData(
            new
            {
                id = 8,
                lat = 12.1,
                lon = 10.2,
                placeId = 8
            }
         );
            modelBuilder.Entity<Coord>().HasData(
            new Coord
            {
                id = 9,
                lat = 11.1,
                lon = 11.2,
                placeId = 9
            }
         );
            modelBuilder.Entity<Coord>().HasData(
            new Coord
            {
                id = 10,
                lat = 10.1,
                lon = 10.2,
                placeId = 10
            }
         );

        }
    }

}
