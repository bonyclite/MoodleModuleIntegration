using System;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using PersonnelSTU.Core.Data.Infrastructure;
using PersonnelSTU.Core.Domain;

namespace PersonnelSTU.Core.Data.Repositories
{
    public interface IPersonnelSTUCoreEntityRepository<TEntity> where TEntity : EntityBase
    {
        IQueryable<TEntity> GetAll();
        IQueryable<TResult> GetAll<TResult>(Expression<Func<TEntity, TResult>> selector);
        IQueryable<TEntity> GetMany(Expression<Func<TEntity, bool>> where);
        IQueryable<TResult> GetMany<TResult>(Expression<Func<TEntity, bool>> where, Expression<Func<TEntity, TResult>> selector); 
    }

    public class PersonnelSTUCoreEntityRepository<TEntity> : IPersonnelSTUCoreEntityRepository<TEntity> where TEntity : EntityBase
    {
        protected PersonnelStuCoreDbContext DbContext { get; }
        protected DbSet<TEntity> Entities { get; }
        
        public PersonnelSTUCoreEntityRepository(PersonnelStuCoreDbContext dbContext)
        {
            DbContext = dbContext;
            Entities = DbContext.Set<TEntity>();
        }

        public IQueryable<TEntity> GetAll()
        {
            return Entities.AsQueryable();
        }

        public IQueryable<TResult> GetAll<TResult>(Expression<Func<TEntity, TResult>> selector)
        {
            return GetAll().Select(selector);
        }

        public IQueryable<TEntity> GetMany(Expression<Func<TEntity, bool>> @where)
        {
            return GetAll().Where(where);
        }

        public IQueryable<TResult> GetMany<TResult>(Expression<Func<TEntity, bool>> @where, Expression<Func<TEntity, TResult>> selector)
        {
            return GetAll().Where(where).Select(selector);
        }
    }
}