using NUnit.Framework;
using PromotionEngine.Service;

namespace PromotionEngine.Test
{
    [TestFixture]
    public class ProductCatalogTest
    {
        [TestCase]
        public void ProductCatalog_ShouldReturnZero_When_ProductNotFound()
        {
            ProductCatalog productCatalog = new ProductCatalog();
            productCatalog.AddProduct('A', 30);
            var price = productCatalog.GetPrice('B');

            Assert.AreEqual(price, 0);
        }
        [TestCase]
        public void ProductCatalog_ShouldReturn_ProductPrice_ByPassingProductName()
        {
            ProductCatalog productCatalog = new ProductCatalog();
            productCatalog.AddProduct('A', 30);
            var price = productCatalog.GetPrice('A');

            Assert.AreEqual(price, 30);
        }
    }
}
