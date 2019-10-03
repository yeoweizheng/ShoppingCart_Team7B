using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShoppingCart_Team7B.Models
{
    public class PurchaseGroup
    {
        public string PurchaseGroupId { get; set; }
        public int Quantity { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; }

        public virtual ICollection<ActivationCode> ActivationCodeId { get; set; }

    }
}