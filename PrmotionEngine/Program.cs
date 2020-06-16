using PromotionEngine.Models;
using PromotionEngine.Service;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PromotionEngine
{
    class Program
    {

        private static IProductCatalog _productCatalog = new ProductCatalog();
        private static IPromotionRules _productRules = new PromotionRules();
        static void Main(string[] args)
        {
            //Added product with price
            _productCatalog.AddProduct('A', 50);
            _productCatalog.AddProduct('B', 30);
            _productCatalog.AddProduct('C', 20);
            _productCatalog.AddProduct('D', 15);

            List<PromotionCart> promotionCartResults = new List<PromotionCart>();
            PromotionCart promotionCartResult = new PromotionCart();

            char[] userInput = { 'A', 'A', 'A', 'A', 'B', 'B', 'B', 'C', 'C', 'D', 'D' };

            //Verify all PromotionRules

            //3A rule
            promotionCartResult = _productRules.PromotionRules_3A(userInput.ToList());
            promotionCartResults.Add(promotionCartResult);
            //2B rule
            promotionCartResult = _productRules.PromotionRules_2B(promotionCartResult.RemainingProducts);
            promotionCartResults.Add(promotionCartResult);
            //CD rule
            promotionCartResult = _productRules.PromotionRules_CD(promotionCartResult.RemainingProducts);
            promotionCartResults.Add(promotionCartResult);
            //Remaing Products

            foreach (var item in promotionCartResult.RemainingProducts)
            {
                promotionCartResults.Add(new PromotionCart()
                {
                    PromotedProduct = item.ToString(),
                    NumberOfTimes = 1,
                    PromotionCartPrice = _productCatalog.GetPrice(item)
                });
            }


            foreach (var item in promotionCartResults)
            {
                Console.WriteLine("Price of {0}  {1} = {2}", item.NumberOfTimes, item.PromotedProduct, item.PromotionCartPrice);
            }
            double totalPrice = promotionCartResults.Sum(x => x.PromotionCartPrice);

            Console.WriteLine("Total price : " + totalPrice);
        }

    }
}
