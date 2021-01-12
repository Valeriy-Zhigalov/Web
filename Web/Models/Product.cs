using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string CategoryProduct { get; set; }
        public List<Computer> Computers { get; set; }
        public List<Laptop> Laptops { get; set; }
        public List<Periphery> Peripheries { get; set; }
        public  List<Provider> Providers { get; set; }
    }
}
