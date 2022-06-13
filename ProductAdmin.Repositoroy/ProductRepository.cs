using Microsoft.EntityFrameworkCore;
using ProductAdmin.DomainEntity;
using ProductAdmin.RepositoryInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductAdmin.Repositoroy
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        public ProductRepository(ProductDbContext context) : base(context)
        {
        }
    }
}
