using System;
using System.Collections.Generic;
using System.Text;

namespace PromotionEngine.Service
{
    public interface IProductCatalog
    {
        double GetPrice(char product);
        void AddProduct(char product, double price);
    }
}
