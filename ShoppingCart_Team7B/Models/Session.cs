using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShoppingCart_Team7B.Models
{
    public class Session
    {
        public int SessionId { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        
    }
}