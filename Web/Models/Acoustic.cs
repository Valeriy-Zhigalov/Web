using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Models
{
    public class Acoustic
    {
        public int AcousticId { get; set; }
        public string TypeAcoustic { get; set; }
        public int PeripheryId { get; set; }
        public Periphery Periphery { get; set; }
    }
}
