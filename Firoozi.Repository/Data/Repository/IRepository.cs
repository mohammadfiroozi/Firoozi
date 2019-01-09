using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Firoozi.Repository.Data.Repository
{
    public interface IRepository<TEntity, TKey> where TEntity : class
    {
        #region Select

        TEntity Get(TKey id);
        Task<TEntity> GetAsync(TKey id);
        IQueryable<TEntity> GetAll();
        List<TEntity> GetAllList(Expression<Func<TEntity, bool>> predicate);
        Task<List<TEntity>> GetAllListAsync(Expression<Func<TEntity, bool>> predicate);
      
        TEntity Single(Expression<Func<TEntity, bool>> predicate);
        Task<TEntity> SingleAsync(Expression<Func<TEntity, bool>> predicate);
        TEntity FirstOrDefault(TKey id);
        Task<TEntity> FirstOrDefaultAsync(TKey id);
        TEntity FirstOrDefault(Expression<Func<TEntity, bool>> predicate);
        Task<TEntity> FirstOrDefaultAsync(Expression<Func<TEntity, bool>> predicate);

        #endregion


        #region Insert
        void Add(TEntity entity);
        Task AddAsync(TEntity entity);
        void AddRange(IEnumerable<TEntity> entities);
        Task AddOrUpdate(TEntity entity);
        Task<TEntity> AddOrUpdateAsync(TEntity entity);

        #endregion

        #region Remove
        void Remove(TEntity entity);
        Task RemoveAsync(TEntity entity);
        void RemoveRange(IEnumerable<TEntity> entities);
        Task RemoveRangeAsync(IEnumerable<TEntity> entities);
        #endregion


      
    }
}
