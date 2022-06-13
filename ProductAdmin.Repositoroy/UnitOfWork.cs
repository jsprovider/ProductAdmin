using Microsoft.EntityFrameworkCore;
using ProductAdmin.RepositoryInterface;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductAdmin.Repositoroy
{
    // public class UnitOfWork<CloudPortalContext> : IUnitOfWork<TContext>, IDisposable where TContext : CloudPortalContext, new()
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private ProductDbContext _context;
        private readonly IProductRepository _productRepository;
        private bool disposed;

        public UnitOfWork(ProductDbContext context, IProductRepository repository)
        {
            _context = context;
            _productRepository = repository;

        }
        public IProductRepository ProductRepository => _productRepository;
       
        public void Complete()
        {
            _context.Database.CommitTransaction();
        }

        public void CreateTransaction()
        {
            _context.Database.BeginTransaction();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public void Rollback()
        {
            _context.Database.RollbackTransaction();
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Upate<T>(T entity) where T : class
        {
            _context.Update<T>(entity);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
                if (disposing)
                    _context.Dispose();
            disposed = true;
        }
    }
}
