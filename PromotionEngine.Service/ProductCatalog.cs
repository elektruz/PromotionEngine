using System;
using System.Collections.Generic;
using System.Text;

namespace PromotionEngine.Service
{
    public class ProductCatalog:IProductCatalog
    {
        private IDictionary<char, double> _productPriceMap = new SortedDictionary<char, double>();
        public void AddProduct(char product, double price)
        {
            _productPriceMap.Add(product, price);
        }

        public double GetPrice(char product)
        {
            if (!_productPriceMap.ContainsKey(product))
            {
                return 0;
            }
            else
            {
                return _productPriceMap[product];
            }
        }
    }
}
