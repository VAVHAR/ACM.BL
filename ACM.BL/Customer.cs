using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Customer
    {

        public Customer()
        {

        }

        public Customer(int customerId)
        {
            CustomerId = customerId;
        }

        public int CustomerId { get; private set; }
        public string EmailAddress { get; set; }
        public string Firstname { get; set; }
        public string Fullname
        {
            get
            {
                string fullName = Lastname;

                if (!string.IsNullOrWhiteSpace(Firstname))
                {
                    if (!string.IsNullOrWhiteSpace(fullName))
                    {
                        //fullName = fullName + ",";
                        fullName += ",";
                    }

                    fullName += Firstname;
                }

                return fullName;
            }
        }

        public static int InstanceCount { get; set; }

        private string _lastname;
        public string Lastname
        {
            get
            {

                return _lastname;
            }
            set
            {
                _lastname = value;
            }
        }

        public bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(Lastname)) isValid = false;

            if (string.IsNullOrWhiteSpace(EmailAddress)) isValid = false;

            return isValid;
        }

        // method to retrive new customer
        public Customer Retrieve(int CustomerId)
        {
            // code that retrive new customer will be coded here
            return new Customer();
        }

        //method to retrive all cutomers / list of customers

        public List<Customer> Retrieve()
        {
            return new List<Customer>();
        }

        public bool Save()
        {
            // Code ton save curret customer will be codded later with UI

            return true;
        }
    }
}
