using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Models
{
    public class Monitor
    {
        public int MonitorId { get; set; }
        public string Name { get; set; }
        public string Model { get; set; }
        public string TypeMonitor { get; set; }
        public string Diagonal { get; set; }
        public decimal Price { get; set; }
        public byte[] Image { get; set; }
        public int PeripheryId { get; set; }
        public Periphery Periphery { get; set; }
    }
}
