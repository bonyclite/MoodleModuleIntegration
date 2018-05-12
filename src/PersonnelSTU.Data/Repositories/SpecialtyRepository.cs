using Common.Data.Infrastructure;
using Common.Data.Repositories;
using PersonnelSTU.Domain;

namespace PersonnelSTU.Data.Repositories
{
    public interface ISpecialtyRepository : IEntityRepository<Specialty>
    {

    }

    public class SpecialtyRepository : EntityRepositoryBase<Specialty>, ISpecialtyRepository
    {
        public SpecialtyRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}