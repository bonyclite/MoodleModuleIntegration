using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace Common.Data.Infrastructure
{
    public interface IDbContext
    {
        EntityState GetEntityState<TEntity>(TEntity entity) where TEntity : class;
        TEntity AttachEntity<TEntity>(TEntity entity, EntityState? withState = null) where TEntity : class;
        DbSet<TEntity> Set<TEntity>() where TEntity : class;
        void SaveChanges();
    }

    public class DbContextAdapter : IDbContext
    {
        private readonly DbContext _dbContext;

        public DbContextAdapter(DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public EntityState GetEntityState<TEntity>(TEntity entity) where TEntity : class
        {
            return _dbContext.Entry(entity).State;
        }

        public TEntity AttachEntity<TEntity>(TEntity entity, EntityState? withState = null) where TEntity : class
        {
            var attachedEntity = _dbContext.Set<TEntity>().Attach(entity);
            if (withState.HasValue)
                _dbContext.Entry(entity).State = withState.Value;

            return attachedEntity;
        }

        public DbSet<TEntity> Set<TEntity>() where TEntity : class
        {
            return _dbContext.Set<TEntity>();
        }

        public void SaveChanges()
        {
            _dbContext.SaveChanges();
        }
    }
}