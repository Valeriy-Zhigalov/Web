using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Models
{
    public class ShopCartItem
    {
        public int ShopCartItemId { get; set; }
        public Computer computer { get; set; }
        public decimal Price { get; set; }
        public virtual Order order { get; set; }
        public string ShopCartId { get; set; }
        
    }
}
