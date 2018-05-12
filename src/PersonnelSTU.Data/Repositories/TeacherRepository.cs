using Common.Data.Infrastructure;
using Common.Data.Repositories;
using PersonnelSTU.Domain;

namespace PersonnelSTU.Data.Repositories
{
    public interface ITeacherRepository : IEntityRepository<Teacher>
    {
        
    }

    public class TeacherRepository : EntityRepositoryBase<Teacher>, ITeacherRepository
    {
        public TeacherRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}