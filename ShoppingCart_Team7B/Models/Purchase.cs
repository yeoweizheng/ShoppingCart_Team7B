using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShoppingCart_Team7B.Models
{
    public class Purchase
    {
        public string PurchaseId { get; set; }
        public float PurchaseDate { get; set; }
        public virtual ICollection<PurchaseGroup> PurchaseGroupId { get; set; }
    }
}