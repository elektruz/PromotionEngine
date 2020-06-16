using System;
using System.Collections.Generic;

namespace PromotionEngine.Models
{
    public class PromotionCart
    {
        public PromotionCart()
        {
            RemainingProducts = new List<char>();
            PromotedProduct = string.Empty;
        }
        public double PromotionCartPrice { get; set; }

        public List<char> RemainingProducts { get; set; }

        public string PromotedProduct { get; set; }

        public int NumberOfTimes { get; set; }
    }
}
