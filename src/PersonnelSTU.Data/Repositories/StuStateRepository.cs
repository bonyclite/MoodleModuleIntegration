using Common.Data.Infrastructure;
using Common.Data.Repositories;
using PersonnelSTU.Domain;

namespace PersonnelSTU.Data.Repositories
{
    public interface IStuStateRepository : IEntityRepository<StuState>
    {
        
    }

    public class StuStateRepository : EntityRepositoryBase<StuState>, IStuStateRepository
    {
        public StuStateRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}