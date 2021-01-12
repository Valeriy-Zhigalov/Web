using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Web.Models;

namespace Web.ViewModels
{
    public class ComputerViewModel 
    {

        public int ComputerId { get; set; }
        
        public string Name { get; set; }
        
        public string Model { get; set; }
        
        public string CPU { get; set; }
        
        public string MotherBoard { get; set; }
        
        public string GraphicsCard { get; set; }
        
        public string HardDisk { get; set; }
        
        public decimal Price { get; set; }
        public IFormFile Image { get; set; }
    }
}
