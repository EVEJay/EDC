﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EveDataCollator.Eve
{
    public class SolarSystem
    {
        public string Name { get; set; } = String.Empty;
        public int  Id { get; set; }

        public List<Planet> Planets { get; set; } = new();
    }
}
