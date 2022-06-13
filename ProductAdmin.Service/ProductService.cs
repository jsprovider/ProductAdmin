using Microsoft.EntityFrameworkCore;
using ProductAdmin.DomainEntity;
using ProductAdmin.RepositoryInterface;
using ProductAdmin.ServiceInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductAdmin.Service
{
    public class ProductService:IProductService
    {
        private IUnitOfWork _unitOfWork;

        public ProductService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<IEnumerable<Product>> GetProductAll()
        {
            return await _unitOfWork.ProductRepository.GetAll();
        }

        public async Task<IEnumerable<Product>> GetProductById(int id)
        {
            return await _unitOfWork.ProductRepository.Get(r=> r.Id == id);
        }

        public int SaveProduct(Product product)
        {
            //int id = product.Id;
            //if (id > 0)
            //{
            //    _context.Entry(product).State = EntityState.Modified;
            //}
            //else
            //{
            //    _context.Products.Add(product);
            //}
            //try
            //{
            //    _context.SaveChanges();
            //}
            //catch (DbUpdateConcurrencyException)
            //{
            //    throw;
            //}
            //return product.Id;
            throw new NotImplementedException();
        }

        public bool DeleteProduct(int id)
        {
            //var product = _context.Products.Find(id);
            //if (product == null)
            //{
            //    return false;
            //}
            //_context.Products.Remove(product);
            //_context.SaveChanges();
            //return true;
            throw new NotImplementedException();
        }

        private bool ProductExists(int id)
        {
            //return _context.Products.Any(e => e.Id == id);
            throw new NotSupportedException();
        }

    }
}
