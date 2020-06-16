using PromotionEngine.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PromotionEngine.Service
{
    public class PromotionRules:IPromotionRules
    {
        public PromotionCart PromotionRules_3A(List<char> products)
        {
            PromotionCart promotionCartResult = new PromotionCart();
            while (true)
            {
                if (products.Count(x => x == 'A') >= 3)
                {
                    promotionCartResult.PromotedProduct = "3 * A";
                    promotionCartResult.PromotionCartPrice += ApplicationConstants.A_3;
                    promotionCartResult.NumberOfTimes += 1;
                    for (int i = 0; i < 3; i++)
                    {
                        products.Remove('A');
                    }
                }
                else
                {
                    break;
                }
            }
            promotionCartResult.RemainingProducts = products;

            return promotionCartResult;
        }

        public PromotionCart PromotionRules_2B(List<char> products)
        {
            PromotionCart promotionCartResult = new PromotionCart();
            while (true)
            {
                if (products.Count(x => x == 'B') >= 2)
                {
                    promotionCartResult.PromotedProduct = "2 * B";
                    promotionCartResult.PromotionCartPrice += ApplicationConstants.B_2;
                    promotionCartResult.NumberOfTimes += 1;

                    for (int i = 0; i < 2; i++)
                    {
                        products.Remove('B');
                    }
                }
                else
                {
                    break;
                }
            }
            promotionCartResult.RemainingProducts = products;

            return promotionCartResult;
        }

        public PromotionCart PromotionRules_CD(List<char> products)
        {
            PromotionCart promotionCartResult = new PromotionCart();
            while (true)
            {
                if (products.Any(x => x == 'C') && products.Any(x => x == 'D'))
                {
                    promotionCartResult.PromotedProduct = "C & D";
                    promotionCartResult.PromotionCartPrice += ApplicationConstants.C_D;
                    promotionCartResult.NumberOfTimes += 1;

                    products.Remove('C');
                    products.Remove('D');
                }
                else
                {
                    break;
                }
            }
            promotionCartResult.RemainingProducts = products;

            return promotionCartResult;
        }
    }
}
