using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ACM.BLTEST
{
    [TestClass]
    public class CustomerRepositoryTest
    {
        [TestMethod]
        public void RetriveValue()
        {
            //Arrange

            var customerRepository = new CustomerRepository();
            var expected = new Customer(1)
            {
                Firstname = "Frodo",
                Lastname = "Baggins",
                EmailAddress = "FBaggins@gmail.com"
            };

            //Act

            var Actual = customerRepository.Retrive(1);


            //Assert

            Assert.AreEqual(expected.CustomerId, Actual.CustomerId);
            Assert.AreEqual(expected.Firstname, Actual.Firstname);
            Assert.AreEqual(expected.Lastname, Actual.Lastname);
            Assert.AreEqual(expected.EmailAddress, Actual.EmailAddress);
        }
    }
}
