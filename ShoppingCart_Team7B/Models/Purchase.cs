using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShoppingCart_Team7B.Models
{
    public class Purchase
    {
        public Purchase()
        {
            this.PurchaseGroups = new List<PurchaseGroup>();
        }
        public int PurchaseId { get; set; }
        public float PurchaseDate { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<PurchaseGroup> PurchaseGroups { get; set; }
    }
}