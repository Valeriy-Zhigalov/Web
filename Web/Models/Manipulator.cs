using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Models
{
    public class Manipulator
    {
        public int ManipulatorId { get; set; }
        public string Name { get; set; }
        public string Model { get; set; }
        public string TypeManipulator { get; set; }
        public decimal Price { get; set; }
        public byte[] Image { get; set; }
        public int PeripheryId { get; set; }
        public Periphery Periphery { get; set; }
    }
}
