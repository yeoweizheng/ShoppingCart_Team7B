using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShoppingCart_Team7B.Models
{
    public class ActivationCode
    {
        public int ActivationCodeId { get; set; }
        public float ActivationNumber { get; set; }
        public string PurchaseGroupId { get; set; }
        public PurchaseGroup PurchaseGroup { get; set; }
    }
}