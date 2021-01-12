using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Web.Models;
using Web.ViewModels;

namespace Web.Controllers
{
    public class ShopCartController : Controller
    {
        private  IAllComputers _proRep;
        private readonly ShopCart _shopcart;

        public ShopCartController(IAllComputers proRep, ShopCart shopCart)
        {
            _proRep = proRep;
            _shopcart = shopCart;
        }

        public ViewResult Index()
        {
            var items = _shopcart.getShopItems();
            _shopcart.listShopItems = items;


            var obj = new ShopCartViewModel
            {
                shopCart = _shopcart
        };
            return View(obj);
        }

        public RedirectToActionResult addToCart(int ComputerId)
        {
            var item = _proRep.Computers.FirstOrDefault(i => i.ComputerId == ComputerId);
            if(item != null)
            {
                _shopcart.AddToCart(item);
            }
            return RedirectToAction("Index");
        }
    }
}
