using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Models
{
    public class Computer
    {
        
        public int ComputerId { get; set; }
        public string Name { get; set; }
        public string Model { get; set; }
        public string CPU { get; set; }
        public string MotherBoard { get; set; }
        public string GraphicsCard { get; set; }
        public string HardDisk { get; set; }
        public decimal Price { get; set; }
        public byte[] Image { get; set; }
        public Product Products { get; set; }

    }
}
