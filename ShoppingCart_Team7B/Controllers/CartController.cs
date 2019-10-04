using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ShoppingCart_Team7B.Models;
using ShoppingCart_Team7B.Database;
using System.Data.Entity;

namespace ShoppingCart_Team7B.Controllers
{
    public class CartController : Controller
    {
        // GET: Cart
        public ActionResult ViewCart()
        {
            User user = UserController.GetUserFromCookie(Request.Cookies["ShoppingCart_Team7B"]);
            if (user == null) return RedirectToAction("Login", "User");
            ViewData["user"] = user;
            return View();
        }
        public ActionResult UpdateCartGroup(int cartGroupId, int quantity)
        {
            var db = new ShoppingCartDbContext();
            CartGroup cartGroup = db.CartGroup.Where(x => x.CartGroupId == cartGroupId).FirstOrDefault();
            cartGroup.Quantity = quantity;
            db.SaveChanges();
            return new HttpStatusCodeResult(200);
        }
        public ActionResult GetCartTotal(int cartId)
        {
            var db = new ShoppingCartDbContext();
            Cart cart = db.Cart.Where(x => x.CartId == cartId).FirstOrDefault();
            double totalSum = 0;
            foreach(var cartGroup in cart.CartGroups)
            {
                totalSum += cartGroup.Product.Price * cartGroup.Quantity;
            }
            return Content(totalSum.ToString("0.00"));
        }
        public ActionResult GetCartQuantity(int cartId)
        {
            var db = new ShoppingCartDbContext();
            Cart cart = db.Cart.Where(x => x.CartId == cartId).FirstOrDefault();
            int totalQuantity = 0;
            foreach(var cartGroup in cart.CartGroups)
            {
                totalQuantity += cartGroup.Quantity;
            }
            return Content(totalQuantity.ToString());
        }
        public ActionResult RemoveFromCart(int cartGroupId)
        {
            var db = new ShoppingCartDbContext();
            CartGroup cartGroup = db.CartGroup.Where(x => x.CartGroupId == cartGroupId).FirstOrDefault();
            db.CartGroup.Remove(cartGroup);
            db.SaveChanges();
            return new HttpStatusCodeResult(200);
        }
    }
}