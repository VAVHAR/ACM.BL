using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Customer
    {

        public int CustomerId { get; private set; }
        public string EmailAddress { get; set; }
        public string Firstname { get; set; }
        public string Fullname
        {
            get
            {
                return Lastname + "," + Firstname;
            }
        }

        private string _lastname; public string Lastname
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
    }
}
