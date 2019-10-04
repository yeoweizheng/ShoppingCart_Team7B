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
        public ActionResult ListProducts()
        {
            var db = new ShoppingCartDbContext();
            var productList = db.Product.ToList();
            ViewData["productList"] = productList;      
            return View(); 
        }
    }
}