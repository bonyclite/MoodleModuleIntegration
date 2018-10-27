using Common.Data.Infrastructure;
using Common.Data.Repositories;
using PersonnelSTU.Domain;

namespace PersonnelSTU.Data.Repositories
{
    public interface IStudentStateRepository : IEntityRepository<StudentState>
    {

    }

    public class StudentStateRepository : EntityRepositoryBase<StudentState>, IStudentStateRepository
    {
        public StudentStateRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}