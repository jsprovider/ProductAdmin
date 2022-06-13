using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using ProductAdmin.RepositoryInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ProductAdmin.Repositoroy
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity:class 
    {
        DbContext _context = null;
        public DbSet<TEntity> CurrentRepository { get; } = null;
        public Repository(DbContext context)
        {
            _context = context;
            CurrentRepository = _context.Set<TEntity>();
        }

        public async Task<TEntity> Add(TEntity entity)
        {
           var createdResult = await CurrentRepository.AddAsync(entity);
           return createdResult?.Entity;
        }

        public async Task<int> Count()
        {
            return await CurrentRepository.CountAsync();
        }

        public async Task<int> Count(Expression<Func<TEntity, bool>> predicate)
        {
            return await CurrentRepository.CountAsync(predicate);
        }

        public async Task<TEntity> FirstOrDefault(Expression<Func<TEntity, bool>> predicate)
        {
            return await CurrentRepository.FirstOrDefaultAsync(predicate);
        }

        public async Task<IEnumerable<TEntity>> GetAll()
        {
            return await CurrentRepository.ToListAsync();
        }

        public async Task<IEnumerable<TEntity>> Get(Expression<Func<TEntity, bool>> predicate)
        {
            return await CurrentRepository.Where(predicate).ToListAsync();
        }
        public void Remove(TEntity entity)
        {
            CurrentRepository.Remove(entity);
        }
    }
}
