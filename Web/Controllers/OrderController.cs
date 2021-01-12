using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Models;

namespace Web.Controllers
{
    public class OrderController : Controller
    {

        private readonly IAllOrders allorders;
        private readonly ShopCart shopCart;

        public OrderController(IAllOrders allorders, ShopCart shopCart)
        {
            this.allorders = allorders;
            this.shopCart = shopCart;
        }

        public IActionResult Checkout()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult Checkout(Order order)
        {
            shopCart.listShopItems = shopCart.getShopItems();

            if(shopCart.listShopItems.Count == 0)
            {
                ModelState.AddModelError("", "У вас отсутствуют товары в корзине!");
            }
            if (ModelState.IsValid)
            {
                allorders.createOrder(order);
                return RedirectToAction("Complete");
            }
            return View(order);
        }

        public IActionResult Complete()
        {
            ViewBag.Message = "Заказ Выполнен! Уважаемый Клиент, спешим сообщить, что теперь Вам доступно техническое обслуживание!";
            return View();
        }

    }
}
