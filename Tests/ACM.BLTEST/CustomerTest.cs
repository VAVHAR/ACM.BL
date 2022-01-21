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

        public void FullNameEmpty()
        {
            // - Arrange
            Customer customer = new Customer
            {

                Firstname = "Bildo",
                Lastname = "Baggins"

            };

            // - Act

            // - Assert


        }
    }
}
