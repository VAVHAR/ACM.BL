using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ACM.BL;

namespace ACM.BLTEST
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void FullNameTestValid()
        {
            // - Arrange
            /* var customer is same
               var customer = new Customer();  */

            Customer customer = new Customer
            {

                Firstname = "Bildo",
                Lastname = "Baggins"


            };

            string expected = "Baggins,Bildo";

            // - Act

            string actual = customer.Fullname;

            // - Assert

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FullNameFirstNameEmpty()
        {
            // - Arrange

            Customer customer = new Customer
            {
                Lastname = "Baggins"
            };

            string expected = "Baggins";

            // - Act

            string actual = customer.Fullname;

            // - Assert

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]

        public void StaticTest()
        {
            // - Arrange 

            var c1 = new Customer();
            c1.Firstname = "Bilbo";
            Customer.InstanceCount += 1;

            var c2 = new Customer();
            c2.Firstname = "Frodo";
            Customer.InstanceCount += 1;

            var c3 = new Customer();
            c3.Firstname = "Rosie";
            Customer.InstanceCount += 1;

            // - Act

            // - Assert
            Assert.AreEqual(3, Customer.InstanceCount);

        }

        [TestMethod]

        public void ValidateValid()
        {
            // --Arrange

            var customer = new Customer()
            {
                Lastname = "Baggins",
                EmailAddress = "fbaggins@gmail.com"

            };

            var expected = true;

            // --Act

            var actual = customer.Validate();
            // --Assert

            Assert.AreEqual(expected, actual);
        }
    }
}
