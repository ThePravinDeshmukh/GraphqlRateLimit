using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace CarvedRockApi.Repositories
{
    public interface IRepository<TEntity, TKey>
    {
        Task<IQueryable<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> predicate = null);

        Task<IQueryable<TEntity>> GetAllAsync<TProperty>(
            Expression<Func<TEntity, bool>> predicate = null, 
            Expression<Func<TEntity, TProperty>> navigationPropertyPath = null);

        Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> predicate);

        Task<TEntity> GetAsync(TKey id);
    }
}
