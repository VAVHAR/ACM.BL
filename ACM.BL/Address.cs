using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Address
    {

        public Address()
        {

        }
        public Address(int addressId)
        {
            AddressId = addressId;
        }

        public int AddressId { get; set; }
        public string Street_line1 { get; set; }

        public string Street_line2 { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string PostalCode { get; set; }

        public string Country { get; set; }

        public int Address_type { get; set; }

        public bool Validate()
        {
            var isValid = true;

            if (PostalCode.Length != 6 || PostalCode == null) isValid = false;

            if (Address_type > 4) isValid = false;

            return isValid;
        }
    }
}
