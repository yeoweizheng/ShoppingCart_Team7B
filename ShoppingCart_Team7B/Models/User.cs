using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Security.Cryptography;
using System.Text;

namespace ShoppingCart_Team7B.Models
{
	public class User
	{
        public User() { }
        public User(string name, string username, string password)
        {
            var sha1 = new SHA1CryptoServiceProvider();
            this.Name = name;
            this.Username = username;
            this.Password = Convert.ToBase64String(sha1.ComputeHash(Encoding.UTF8.GetBytes(password)));
            this.Cart= new Cart();
            this.Purchases = new List<Purchase>();
        }
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int CartId { get; set; }
        public virtual Cart Cart { get; set; }
        public virtual ICollection<Purchase> Purchases { get; set; }
	}
}