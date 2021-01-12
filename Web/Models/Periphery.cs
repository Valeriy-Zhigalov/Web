using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Models
{
    public class Periphery
    {
        public int PeripheryId { get; set; }
        public string Name { get; set; }
        public string Model { get; set; }
        public decimal Price { get; set; }
        public List<Manipulator> Manipulators { get; set; }
        public List<Monitor> Monitors { get; set; }
        public List<Acoustic> Acoustics { get; set; }
        public Product Products { get; set; }


    }
}
