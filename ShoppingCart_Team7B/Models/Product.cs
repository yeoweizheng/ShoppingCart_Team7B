using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShoppingCart_Team7B.Models
{
    public class Product
    {
        public Product() { }
        public Product(string productName, double price, string description)
        {
            this.ProductName = productName;
            this.Price = price;
            this.Description = description;
        }
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }


    }
}