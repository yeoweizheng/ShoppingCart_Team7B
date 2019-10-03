using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ShoppingCart_Team7B.Models;

namespace ShoppingCart_Team7B.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ListProducts()
        {
            List<Product> ListProducts = new List<Product>();

            ViewBag.ListProducts = new List<Product>();

            return View();
        }
    }
}