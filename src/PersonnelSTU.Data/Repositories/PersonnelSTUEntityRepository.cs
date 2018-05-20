using Common.Data.Repositories;
using Common.Domain;
using PersonnelSTU.Data.Infrastructure;

namespace PersonnelSTU.Data.Repositories
{
    public interface IPersonnelSTUEntityRepository<TEntity> : IEntityRepository<TEntity> where TEntity : IEntityBase
    {

    }

    public class PersonnelSTUEntityRepository<TEntity> : EntityRepositoryBase<TEntity>, IPersonnelSTUEntityRepository<TEntity> where TEntity : EntityBase
    {
        public PersonnelSTUEntityRepository(IPersonnelStuDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}