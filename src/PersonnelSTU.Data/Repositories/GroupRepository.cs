using Common.Data.Infrastructure;
using Common.Data.Repositories;
using PersonnelSTU.Domain;

namespace PersonnelSTU.Data.Repositories
{
    public interface IGroupRepository : IEntityRepository<Group>
    {

    }

    public class GroupRepository : EntityRepositoryBase<Group>, IGroupRepository
    {
        public GroupRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}