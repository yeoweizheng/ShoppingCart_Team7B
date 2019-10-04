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
        // GET: Product
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ListProducts()
        {
            /*
                var db = new ShoppingCartDbContext();

                List<Product> ListProduct = new List<Product>();
                
                      var details = new Product();

 = 

                        details.ProductId = (int)["ProductId"];
                        details.ProductName = (string) ["ProductName"].ToString();
                        details.Price = (double)["Price"];
                        details.Description =["Description"].ToString();
                        
                    

                        ListProduct.Add(details);

                    }  ViewData["details"] = ListProduct;

                } return View();
            } */
            var db = new ShoppingCartDbContext();
            var productList = db.Product.ToList();
            ViewData["productList"] = productList;      
            /*
              using (SqlConnection connection=new SqlConnection("Server=wzyeo.net; Database=ShoppingCart_Team7B; User Id=Team7B; Password=Team7BRocks"))
              {
                  connection.Open();
                  string sql = @"SELECT Products.ProductId, Products.ProductName, Products.Price, Products.Description
                              FROM Products";
                  SqlCommand cmd = new SqlCommand(sql, connection);
                  SqlDataReader reader = cmd.ExecuteReader();

                  List<Product> ListProduct = new List<Product>();

                  while (reader.Read())
                  {
                      var details = new Product();

                      details.ProductId = (int)reader["ProductId"];
                      details.ProductName = reader["ProductName"].ToString();
                      details.Price = (double)reader["Price"];
                      details.Description = reader["Description"].ToString();

                      ListProduct.Add(details);
                  }

                  ViewData["details"] = ListProduct;

              } */
            return View(); 
              


        }
        public ActionResult LogOut() // to link to User Login Page
        {
            
            return RedirectToAction("Login","Login");
        }
    }
}