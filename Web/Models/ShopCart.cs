using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Models
{
    public class ShopCart
    {
        private readonly ApplicationDBContext applicationDBContext;
        public ShopCart(ApplicationDBContext applicationDBContext)
        {
            this.applicationDBContext = applicationDBContext;
        }
        public string ShopCartId { get; set; }
        public List<ShopCartItem> listShopItems { get; set; }
        public static ShopCart GetCart(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;
            var context = services.GetService<ApplicationDBContext>();
            string shopCartId = session.GetString("CartId") ?? Guid.NewGuid().ToString();

            session.SetString("CartId", shopCartId);

            return new ShopCart(context) { ShopCartId = shopCartId };
        }

         public void AddToCart (Computer computer)
        {
           applicationDBContext.ShopCartItem.Add(new ShopCartItem
            {
                ShopCartId = ShopCartId,
                computer = computer,
                Price = computer.Price,

            });

            applicationDBContext.SaveChanges();
        }

        public List<ShopCartItem> getShopItems()
        {
            return applicationDBContext.ShopCartItem.Where(c => c.ShopCartId == ShopCartId).Include(s => s.computer).ToList();
        }
    }
}
