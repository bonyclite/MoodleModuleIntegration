using Common.Data.Infrastructure;
using Common.Data.Repositories;
using PersonnelSTU.Domain;

namespace PersonnelSTU.Data.Repositories
{
    public interface IPersonRepository : IEntityRepository<Person>
    {

    }

    public class PersonRepository : EntityRepositoryBase<Person>, IPersonRepository
    {
        public PersonRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}