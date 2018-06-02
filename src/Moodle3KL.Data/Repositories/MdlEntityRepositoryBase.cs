using System;
using System.Linq;
using System.Linq.Expressions;
using Common.Data.Repositories;
using Moodle3KL.Data.Infrastructure;
using Moodle3KL.Domain;

namespace Moodle3KL.Data.Repositories
{
    public interface IMdlEntityRepositoryBase<TEntity> : IEntityRepository<TEntity> where TEntity : mdl_entity_base
    {
        TEntity GetById(long id);
        TResult GetById<TResult>(long id, Expression<Func<TEntity, TResult>> selector);
        void Save(TEntity entity);
    }

    public class MdlEntityRepositoryBase<TEntity> : EntityRepositoryBase<TEntity>, IMdlEntityRepositoryBase<TEntity> where TEntity : mdl_entity_base
    {
        public MdlEntityRepositoryBase(IMoodle3KLDbFactory dbFactory) : base(dbFactory)
        {
        }

        public TEntity GetById(long id)
        {
            return Entities.Single(e => e.id == id);
        }

        public TResult GetById<TResult>(long id, Expression<Func<TEntity, TResult>> selector)
        {
            var result = GetMany(e => e.id == id, selector).Take(1).ToArray();

            return result.FirstOrDefault();
        }

        public void Save(TEntity entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));

            Entities.Add(entity);
        }
    }
}