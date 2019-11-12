using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using ShoppingCart_Team7B.Models;
using ShoppingCart_Team7B.Database;

namespace ShoppingCart_Team7B.Database
{
    public class ShoppingCartDbContext:DbContext
    {
        public ShoppingCartDbContext() : base("Server=******; Database=ShoppingCart_Team7B; User Id=******; Password=******")
        {
            System.Data.Entity.Database.SetInitializer(new ShoppingCartDbInitializer());
            this.Configuration.LazyLoadingEnabled = true;
        }
        public DbSet<User> User { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<Cart> Cart { get; set; }
        public DbSet<CartGroup> CartGroup { get; set; }
        public DbSet<Purchase> Purchase { get; set; }
        public DbSet<PurchaseGroup> PurchaseGroup { get; set; }
        public DbSet<ActivationCode> ActivationCode { get; set; }
        public DbSet<Session> Session { get; set; }
    }
}
