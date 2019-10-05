using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShoppingCart_Team7B.Models
{
	public class User
	{
        public User() { }
        public User(string username, string password)
        {
            this.Username = username;
            this.Password = password;
            this.Cart= new Cart();
            this.Purchases = new List<Purchase>();
        }
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int CartId { get; set; }
        public virtual Cart Cart { get; set; }
        public virtual ICollection<Purchase> Purchases { get; set; }
	}
}