using Microsoft.VisualStudio.TestTools.UnitTesting;
using ACM.BL;
using System;

namespace ACM.BLTEST
{
    [TestClass]
    public class OrderRepositoryTest
    {
        [TestMethod]
        public void RetriveValue()
        {
            var orderRepository = new BL.OrderRepository();
            var expected = new Order(1)

            {
                Customer = "Hardik",
                Order_Items = 2
            };

            var Actual = orderRepository.Retrive(1);

            Assert.AreEqual(expected.OrderId, Actual.OrderId);
            Assert.AreEqual(expected.Customer, Actual.Customer);
            Assert.AreEqual(expected.Order_Items, Actual.Order_Items);

        }
    }

}
