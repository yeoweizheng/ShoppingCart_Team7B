using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ShoppingCart_Team7B.Models;
using System.Data.SqlClient;
using ShoppingCart_Team7B.Database;
using System.Data.Entity;
using System.Data.Entity.Core.EntityClient;
using System.Data;

namespace ShoppingCart_Team7B.Controllers
{
    public class ProductController : Controller
    {
        public ActionResult ListProducts(string searchStr)
        {
            User user = UserController.GetUserFromCookie(Request.Cookies["ShoppingCart_Team7B"]);
            if (user == null) return RedirectToAction("Login", "User");
            ViewData["user"] = user;
            var db = new ShoppingCartDbContext();
            var productList = db.Product.ToList();
            if(searchStr == null || searchStr == "")
            {
                ViewData["productList"] = productList;
            }
            else
            {
                var filteredProductList = new List<Product>();
                searchStr = searchStr.ToLower();
                foreach(var product in productList)
                {
                    if(product.ProductName.ToLower().Contains(searchStr) || product.Description.ToLower().Contains(searchStr))
                    {
                        filteredProductList.Add(product);
                    }
                }
                ViewData["productList"] = filteredProductList;
                ViewData["searchStr"] = searchStr;
            }
            return View(); 
        }

        public ActionResult AddToCart(int userId, int productId)
        {
            var db = new ShoppingCartDbContext();
            User user = db.User.Where(x => x.UserId == userId).FirstOrDefault();
            Product product = db.Product.Where(x => x.ProductId == productId).FirstOrDefault();
            Cart cart = user.Cart;
            bool match = false;
            foreach(var cartGroup in cart.CartGroups)
            {
                if(cartGroup.Product.ProductId == product.ProductId)
                {
                    cartGroup.Quantity++;
                    match = true;
                    break;
                }
            }
            if (!match)
            {
                cart.CartGroups.Add(new CartGroup(1, product));
            }
            db.SaveChanges();
            return new HttpStatusCodeResult(200);
        }

    }
}