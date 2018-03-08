using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common.Data.Repositories;
using PersonnelSTU.Data.Infrastructure;
using PersonnelSTU.Domain;

namespace PersonnelSTU.Data.Repositories
{
    public interface IFacultyRepository : IEntityRepository<Faculty>
    {

    }

    public class FacultyRepository : PersonnelStuEntityRepositoryBase<Faculty>, IFacultyRepository
    {
        public FacultyRepository(IPersonnelStuDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}