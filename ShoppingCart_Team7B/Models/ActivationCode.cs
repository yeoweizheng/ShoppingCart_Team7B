using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShoppingCart_Team7B.Models
{
    public class ActivationCode
    {
        public ActivationCode()
        {
            this.ActivationNumber = Guid.NewGuid().ToString();
        }
        public int ActivationCodeId { get; set; }
        public string ActivationNumber { get; set; }
        public int PurchaseGroupId { get; set; }
        public virtual PurchaseGroup PurchaseGroup { get; set; }
    }
}