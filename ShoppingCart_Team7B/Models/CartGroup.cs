﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShoppingCart_Team7B.Models
{
    public class CartGroup
    {
        public CartGroup(int quantity, Product product)
        {
            this.Quantity = quantity;
            this.Product = product;
        }
        public int CartGroupId {get; set;}
        public int Quantity { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int CartId { get; set; }
        public Cart Cart { get; set; }
        
    }
}