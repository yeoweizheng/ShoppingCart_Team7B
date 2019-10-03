using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShoppingCart_Team7B.Models
{
    public class Cart
    {
        public Cart()
        {
            this.CartGroups = new List<CartGroup>();
        }
        public int CartId { get; set; }

        public virtual ICollection <CartGroup> CartGroups { get; set; }
    }
}