using Common.Data.Infrastructure;
using Common.Data.Repositories;
using PersonnelSTU.Domain;

namespace PersonnelSTU.Data.Repositories
{
    public interface IFacultyRepository : IEntityRepository<Faculty>
    {

    }

    public class FacultyRepository : EntityRepositoryBase<Faculty>, IFacultyRepository
    {
        public FacultyRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}