using ProductAdmin.DomainEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductAdmin.ServiceInterface
{
    public interface IProductService
    {

        Task<IEnumerable<Product>> GetProductAll();

        Task<IEnumerable<Product>> GetProductById(int id);

        int SaveProduct(Product product);

        bool DeleteProduct(int id);
        
    }
}
