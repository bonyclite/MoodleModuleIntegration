using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common.Data.Repositories;
using PersonnelSTU.Data.Infrastructure;
using PersonnelSTU.Domain;

namespace PersonnelSTU.Data.Repositories
{
    public interface IStuStateRepository : IEntityRepository<StuState>
    {
        
    }

    public class StuStateRepository : PersonnelStuEntityRepositoryBase<StuState>, IStuStateRepository
    {
        public StuStateRepository(IPersonnelStuDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}