using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Shopping_app.Data.Interfaces;
using Shopping_app.Data.Models;

namespace Shopping_app.Controllers
{
    public class OrderController : Controller
    {
        private readonly IAllOrders allOrders;
        private readonly ShopCart shopCart;

        public OrderController(IAllOrders allOrders, ShopCart shopCart)
        {

            this.allOrders = allOrders;
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
                ModelState.AddModelError("", "You should have a product in order to continue");
            }

            if(ModelState.IsValid)
            {
                allOrders.createOrder(order);

                return RedirectToAction("Complete");
            }
            return View(order);
        }

        public IActionResult Complete()
        {
            ViewBag.Message = "Order completed successfully";
            return View();
        }

    }
}