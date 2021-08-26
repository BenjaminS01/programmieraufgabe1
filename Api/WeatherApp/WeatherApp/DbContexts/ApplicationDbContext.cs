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
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {
        }

        public DbSet<Coord> coord { get; set; }

        public DbSet<Main> main { get; set; }

        public DbSet<Place> place { get; set; }

        public DbSet<Weather> weather { get; set; }

        public DbSet<Wind> wind { get; set; }



    }

}
