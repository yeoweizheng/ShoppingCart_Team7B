using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace ShoppingCart_Team7B.Database
{
    public class ShoppingCartDbInitializer:DropCreateDatabaseIfModelChanges<ShoppingCartDbContext>
    {
        protected override void Seed(ShoppingCartDbContext context)
        {
            base.Seed(context);
        }
    }
}