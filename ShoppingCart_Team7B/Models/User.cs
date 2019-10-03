using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShoppingCart_Team7B.Models
{
	public class User
	{
        public string UserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public string CartId { get; set; }
        public Cart Cart { get; set; }

        public virtual ICollection<Purchase> PurchaseId { get; set; }
	}
}