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
            var db = new ShoppingCartDbContext();
            User user = db.User.Where(x => x.Username == "admin").FirstOrDefault();
            ViewData["user"] = user;
            return View();
        }
    }
}