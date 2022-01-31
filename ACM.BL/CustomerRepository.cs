using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class CustomerRepository
    {
        public Customer Retrive(int CustomerId)
        {
            // Create an instance of customer class
            //Pass in the requested id (Customer Id)
            Customer customer = new Customer(CustomerId);

            if (CustomerId == 1)
            {
                customer.Firstname = "Frodo";
                customer.Lastname = "Baggins";
                customer.EmailAddress = "FBaggins@gmail.com";
            }

            return customer;
        }
        public bool Save()
        {
            return true;
        }

    }
}
