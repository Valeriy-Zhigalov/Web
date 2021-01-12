using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Models
{
    public class Provider
    {
        public int ProviderId { get; set; }
        public string CompanyName { get; set; }
        public string Country { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public Product Products { get; set; }
    }
}
