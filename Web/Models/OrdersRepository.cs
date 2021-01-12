using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Models
{
    public class OrdersRepository : IAllOrders
    {
        private readonly ApplicationDBContext applicationDBContext;
        private readonly ShopCart shopCart;

        public OrdersRepository(ApplicationDBContext applicationDBContext, ShopCart shopCart)
        {
            this.applicationDBContext = applicationDBContext;
            this.shopCart = shopCart;
        }

        public void createOrder(Order order)
        {
            order.Date = DateTime.Now;
            applicationDBContext.Orders.Add(order);


            var items = shopCart.listShopItems;

            //foreach (var el in items)
            //{
            //    var orderDetail = new OrderDetail()
            //    {
            //        ComputerId = el.computer.ComputerId,
            //        //OrderId = order.OrderId,
            //        Price = el.computer.Price,
            //    };

            //    applicationDBContext.OrderDetail.Add(orderDetail);
            //}
            applicationDBContext.SaveChanges();
        }
    }
}
