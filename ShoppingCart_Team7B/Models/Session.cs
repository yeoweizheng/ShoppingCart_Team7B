using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShoppingCart_Team7B.Models
{
    public class Session
    {
        public string SessionId { get; set; }

        public string UserID { get; set; }
        public User User { get; set; }
        
    }
}