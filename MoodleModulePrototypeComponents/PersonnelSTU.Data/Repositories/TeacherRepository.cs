using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common.Data.Repositories;
using PersonnelSTU.Data.Infrastructure;
using PersonnelSTU.Domain;

namespace PersonnelSTU.Data.Repositories
{
    public interface ITeacherRepository : IEntityRepository<Teacher>
    {
        
    }

    public class TeacherRepository : PersonnelStuEntityRepositoryBase<Teacher>, ITeacherRepository
    {
        public TeacherRepository(IPersonnelStuDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}