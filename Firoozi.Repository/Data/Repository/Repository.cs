using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Firoozi.Repository.Data.Repository
{
    public class Repository<TEntity,TKey> : IRepository<TEntity,TKey> where TEntity : class
    {
        
        protected readonly FirooziDbContext _context;


       public Repository(FirooziDbContext context)
        {
            _context = context;
        }
        public void Add(TEntity entity)
        {
            _context.Set<TEntity>().Add(entity);
        }

        public Task AddAsync(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task AddOrUpdate(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task<TEntity> AddOrUpdateAsync(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public void AddRange(IEnumerable<TEntity> entities)
        {
            _context.Set<TEntity>().AddRange(entities);
        }

        public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
        {
            return _context.Set<TEntity>().Where(predicate);
        }

        public TEntity FirstOrDefault(TKey id)
        {
            return GetAll().FirstOrDefault(CreateEqualityExpressionForId(id));
        }

        public TEntity FirstOrDefault(Expression<Func<TEntity, bool>> predicate)
        {
            return GetAll().FirstOrDefault(predicate);
        }

        public Task<TEntity> FirstOrDefaultAsync(TKey id)
        {
            return Task.FromResult(FirstOrDefault(id));
        }

        public Task<TEntity> FirstOrDefaultAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return Task.FromResult(FirstOrDefault(predicate));
        }

        public TEntity Get(TKey id)
        {
            return _context.Set<TEntity>().Find(id);
        }

        public IQueryable<TEntity> GetAll()
        {
            return _context.Set<TEntity>();
        }

        public List<TEntity> GetAllList(Expression<Func<TEntity, bool>> predicate)
        {
            return _context.Set<TEntity>().ToList();
        }

        public Task<List<TEntity>> GetAllListAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return Task.FromResult(_context.Set<TEntity>().ToList());
        }

        public virtual async Task<TEntity> GetAsync(TKey id)
        {
            return await FirstOrDefaultAsync(id);
           
        }

        public void Remove(TEntity entity)
        {
            _context.Set<TEntity>().Remove(entity);
        }

        public Task RemoveAsync(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public void RemoveRange(IEnumerable<TEntity> entities)
        {
            _context.Set<TEntity>().RemoveRange(entities);
        }

        public Task RemoveRangeAsync(IEnumerable<TEntity> entities)
        {
            throw new NotImplementedException();
        }

        public TEntity Single(Expression<Func<TEntity, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<TEntity> SingleAsync(Expression<Func<TEntity, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        protected virtual Expression<Func<TEntity, bool>> CreateEqualityExpressionForId(TKey id)
        {
            var lambdaParam = Expression.Parameter(typeof(TEntity));

            var lambdaBody = Expression.Equal(
                Expression.PropertyOrField(lambdaParam, "Id"),
                Expression.Constant(id, typeof(TKey))
                );

            return Expression.Lambda<Func<TEntity, bool>>(lambdaBody, lambdaParam);
        }
    }
}
