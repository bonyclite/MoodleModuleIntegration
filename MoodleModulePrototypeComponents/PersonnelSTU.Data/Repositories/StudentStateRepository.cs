using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common.Data.Repositories;
using PersonnelSTU.Data.Infrastructure;
using PersonnelSTU.Domain;

namespace PersonnelSTU.Data.Repositories
{
    public interface IStudentStateRepository : IEntityRepository<StudentState>
    {

    }

    public class StudentStateRepository : PersonnelStuEntityRepositoryBase<StudentState>, IStudentStateRepository
    {
        public StudentStateRepository(IPersonnelStuDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}