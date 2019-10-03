using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using ShoppingCart_Team7B.Models;

namespace ShoppingCart_Team7B.Database
{
    public class ShoppingCartDbInitializer:DropCreateDatabaseAlways<ShoppingCartDbContext>
    {
        protected override void Seed(ShoppingCartDbContext context)
        {
            User user1 = new User("admin", "admin");
            Product product1 = new Product(".NET Charts", 99, "Brings powerful charting capabilities to your .NET applications.");
            user1.Cart = new Cart();
            user1.Cart.CartGroups.Add(new CartGroup(2, product1));

            context.User.Add(user1);
            context.Product.Add(product1);
            base.Seed(context);
        }
    }
}