using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WeatherApp.Models
{
    public class Place
    {

        [Key]
        public int id { get; set; }

        [Column(TypeName = "varchar(100)")]
        public string name { get; set; }


        //foreign keys
        public virtual Main main { get; set; }

        public virtual Wind wind { get; set; }

        public ICollection<Weather> weather { get; set; }

        public virtual ICollection<Coord> coords { get; set; }


    }
}
