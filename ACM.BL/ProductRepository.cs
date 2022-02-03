using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class ProductRepository
    {
        public Product Retrive(int ProductId)
        {
            Product product = new Product(ProductId);

            if (ProductId == 1)
            {
                product.ProductName = "p1";
                product.ProductDescription = "pd1";
            }
            return product;
        }

        public bool Save()
        {
            return true;
        }
    }
}
