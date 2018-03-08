using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common.Data.Repositories;
using PersonnelSTU.Data.Infrastructure;
using PersonnelSTU.Domain;

namespace PersonnelSTU.Data.Repositories
{
    public interface IPersonRepository : IEntityRepository<Person>
    {

    }

    public class PersonRepository : PersonnelStuEntityRepositoryBase<Person>, IPersonRepository
    {
        public PersonRepository(IPersonnelStuDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}