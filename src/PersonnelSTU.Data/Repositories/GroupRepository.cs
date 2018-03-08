using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common.Data.Repositories;
using PersonnelSTU.Data.Infrastructure;
using PersonnelSTU.Domain;

namespace PersonnelSTU.Data.Repositories
{
    public interface IGroupRepository : IEntityRepository<Group>
    {

    }

    public class GroupRepository : PersonnelStuEntityRepositoryBase<Group>, IGroupRepository
    {
        public GroupRepository(IPersonnelStuDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}