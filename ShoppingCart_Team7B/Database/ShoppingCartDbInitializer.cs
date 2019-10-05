using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using ShoppingCart_Team7B.Models;

namespace ShoppingCart_Team7B.Database
{
    public class ShoppingCartDbInitializer:DropCreateDatabaseIfModelChanges<ShoppingCartDbContext>
    {
        protected override void Seed(ShoppingCartDbContext context)
        {
            Product product1 = new Product(".NET Charts", 99, "Brings powerful charting capabilities to your .NET applications.");
            Product product2 = new Product(".NET PayPal", 69, "Integrate your .NET apps with PayPal the easy way!");
            Product product3 = new Product(".NET ML", 299, "Supercharged .NET machine learning libraries.");
            Product product4 = new Product(".NET Analytics", 299, "Performs data mining and analytics easily in .NET.");
            context.Product.Add(product1);
            context.Product.Add(product2);
            context.Product.Add(product3);
            context.Product.Add(product4);
            base.Seed(context);
        }
    }
}