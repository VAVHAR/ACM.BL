using Microsoft.VisualStudio.TestTools.UnitTesting;
using ACM.BL;
using System;

namespace ACM.BLTEST
{
    [TestClass]
    public class ProductRepositoryTest
    {
        [TestMethod]
        public void RetriveValue()
        {
            var productRepository = new ProductRepository();
            var expected = new Product(1)
            {
              ProductName = "p1",
              ProductDescription = "pd1"

            };

            var Actual = productRepository.Retrive(1);

            Assert.AreEqual(expected.ProductId, Actual.ProductId);
            Assert.AreEqual(expected.ProductName, Actual.ProductName);
            Assert.AreEqual(expected.ProductDescription, Actual.ProductDescription);
        }
    }
}
