using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Models
{
    public class ProductRepository : IComputersProducts
    {
        private readonly ApplicationDBContext applicationDBContext;

        public ProductRepository(ApplicationDBContext applicationDBContext)
        {
            this.applicationDBContext = applicationDBContext;
        }
        public IEnumerable<Product> AllProducts => applicationDBContext.Products;
    }
}
