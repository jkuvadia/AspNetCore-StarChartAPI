using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StarChart.Models
{
    public class CelestialObject
    {
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }
        public int? OrbitedObject { get; set; }
        [NotMapped]
        public List<CelestialObject> Satellites { get; set; }
        public TimeSpan OribitalPeriod { get; set; }

    }
}
