﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeatherApp.Models.Dto
{
    public class PlaceDto
    {
        public int id { get; set; }

        public string name { get; set; }

        public Main main { get; set; }

    }
}
