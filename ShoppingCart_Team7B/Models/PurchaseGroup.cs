using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShoppingCart_Team7B.Models
{
    public class PurchaseGroup
    {
        public PurchaseGroup()
        {
            this.ActivationCodes = new List<ActivationCode>();
        }
        public PurchaseGroup(int quantity, Product product)
        {
            this.ActivationCodes = new List<ActivationCode>();
            this.Quantity = quantity;
            this.Product = product;
            for(int i = 0; i < quantity; i++)
            {
                this.ActivationCodes.Add(new ActivationCode());
            }
        }
        public int PurchaseGroupId { get; set; }
        public int Quantity { get; set; }
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
        public int PurchaseId { get; set; }
        public virtual Purchase Purchase { get; set; }
        public virtual ICollection<ActivationCode> ActivationCodes { get; set; }

    }
}