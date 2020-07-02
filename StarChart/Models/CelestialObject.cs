﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StarChart.Models
{
    public class CelestialObject
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? OrbitedObjectId { get; set; }
        [NotMapped]
        public List<CelestialObject> Satellites;
        public TimeSpan OrbitalPeriod;
    }
}
