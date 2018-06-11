using System;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using Common.Data.Infrastructure;
using Common.Domain;

namespace Common.Data.Repositories
{
    public interface IEntityRepository<TEntity> where TEntity : IEntityBase
    {
        IQueryable<TEntity> GetAll();
        IQueryable<TResult> GetAll<TResult>(Expression<Func<TEntity, TResult>> selector);
        bool Any(Expression<Func<TEntity, bool>> where);
        IQueryable<TEntity> GetMany(Expression<Func<TEntity, bool>> where);
        IQueryable<TResult> GetMany<TResult>(Expression<Func<TEntity, bool>> where, Expression<Func<TEntity, TResult>> selector);
        TResult SingleOrDefault<TResult>(Expression<Func<TEntity, bool>> where, Expression<Func<TEntity, TResult>> selector);
        TEntity FirstOrDefault(Expression<Func<TEntity, bool>> where);
    }

    public class EntityRepositoryBase<TEntity> : IEntityRepository<TEntity> where TEntity : class, IEntityBase
    {
        protected IDbContext DataContext { get; }
        protected DbSet<TEntity> Entities { get; }

        public EntityRepositoryBase(IDbFactory dbFactory)
        {
            DataContext = dbFactory.Get();
            Entities = DataContext.Set<TEntity>();
        }

        public IQueryable<TEntity> GetAll()
        {
            return Entities.AsQueryable();
        }

        public IQueryable<TResult> GetAll<TResult>(Expression<Func<TEntity, TResult>> selector)
        {
            return GetAll().Select(selector);
        }

        public bool Any(Expression<Func<TEntity, bool>> @where)
        {
            return GetAll().Any(where);
        }

        public IQueryable<TEntity> GetMany(Expression<Func<TEntity, bool>> where)
        {
            return GetAll().Where(where);
        }

        public IQueryable<TResult> GetMany<TResult>(Expression<Func<TEntity, bool>> where, Expression<Func<TEntity, TResult>> selector)
        {
            return GetAll().Where(where).Select(selector);
        }

        public TResult SingleOrDefault<TResult>(Expression<Func<TEntity, bool>> @where, Expression<Func<TEntity, TResult>> selector)
        {
            return GetMany(where, selector).SingleOrDefault();
        }

        public TEntity FirstOrDefault(Expression<Func<TEntity, bool>> where)
        {
            return GetAll().FirstOrDefault(where);
        }
    }
}