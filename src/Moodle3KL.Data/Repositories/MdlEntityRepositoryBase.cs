using System.Linq;
using Common.Data.Infrastructure;
using Common.Data.Repositories;
using Moodle3KL.Domain;

namespace Moodle3KL.Data.Repositories
{
    public interface IMdlEntityRepositoryBase<TEntity> : IEntityRepository<TEntity> where TEntity : mdl_entity_base
    {
        TEntity GetById(long id);
    }

    public class MdlEntityRepositoryBase<TEntity> : EntityRepositoryBase<TEntity>, IMdlEntityRepositoryBase<TEntity> where TEntity : mdl_entity_base
    {
        public MdlEntityRepositoryBase(IDbFactory dbFactory) : base(dbFactory)
        {
        }

        public TEntity GetById(long id)
        {
            return Entities.Single(e => e.id == id);
        }
    }
}