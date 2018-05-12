using Common.Data.Infrastructure;
using Common.Data.Repositories;
using Moodle3KL.Domain;

namespace Moodle3KL.Data.Repositories
{
    public class MdlEntityRepositoryBase<TEntity> : EntityRepositoryBase<TEntity> where TEntity : mdl_entity_base
    {
        public MdlEntityRepositoryBase(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}