using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShoppingCart_Team7B.Models
{
    public class Purchase : IComparable<Purchase>
    {
        public Purchase()
        {
            this.PurchaseGroups = new List<PurchaseGroup>();
            this.PurchaseDate = DateTime.Now.ToString("d MMM yyyy");
        }
        public int PurchaseId { get; set; }
        public string PurchaseDate { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<PurchaseGroup> PurchaseGroups { get; set; }
        public int CompareTo(Purchase other)
        {
            return other.PurchaseId.CompareTo(this.PurchaseId);
        }
    }
}