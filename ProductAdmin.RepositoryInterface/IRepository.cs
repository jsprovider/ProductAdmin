using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ProductAdmin.RepositoryInterface
{
    public interface IRepository<T> where T: class  
    {
        //Retreviwal interfaces...
        Task<T> FirstOrDefault(Expression<Func<T, bool>> predicate);
        Task<IEnumerable<T>> GetAll();
        Task<IEnumerable<T>> Get(Expression<Func<T, bool>> predicate);
        Task<int> Count();
        Task<int> Count(Expression<Func<T, bool>> predicate);
        //Update interfaces...
        Task<T> Add(T entity);
        void Remove(T entity);
    }
}
