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
            context.Product.Add(new Product(".NET Charts", 99, "Brings powerful charting capabilities to your .NET applications."));
            context.Product.Add(new Product(".NET PayPal", 69, "Integrate your .NET apps with PayPal the easy way!"));
            context.Product.Add(new Product(".NET ML", 299, "Supercharged .NET machine learning libraries."));
            context.Product.Add(new Product(".NET Analytics", 299, "Performs data mining and analytics easily in .NET."));
            context.Product.Add(new Product(".NET Logger", 49, "Logs and aggregates events easily in your .NET apps."));
            context.Product.Add(new Product(".NET Numerics", 199, "Powerful numerical methods for your .NET simulations."));
            base.Seed(context);
        }
    }
}