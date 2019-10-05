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
    public class PurchasesController : Controller
    {
        // GET: Purchases
        public ActionResult ViewPurchases()
        {
            User user = UserController.GetUserFromCookie(Request.Cookies["ShoppingCart_Team7B"]);
            if (user == null) return RedirectToAction("Login", "User");
            ViewData["user"] = user;
            List<Purchase> purchases = (List<Purchase>) user.Purchases.ToList();
            purchases.Sort();
            ViewData["purchases"] = purchases;
            return View();
        }
    }
}