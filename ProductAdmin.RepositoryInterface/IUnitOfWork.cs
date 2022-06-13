
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductAdmin.RepositoryInterface
{
    
    public interface IUnitOfWork
    {
       // TContext Context { get; }
        void CreateTransaction();
        void Complete();
        void Rollback();
        void Save();
        void Upate<T>(T entity) where T : class;
        IProductRepository ProductRepository { get; }
        
    }
}
