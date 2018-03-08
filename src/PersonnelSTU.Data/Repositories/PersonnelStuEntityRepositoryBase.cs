using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common.Data.Repositories;
using Common.Domain;
using PersonnelSTU.Data.Infrastructure;

namespace PersonnelSTU.Data.Repositories
{
    public class PersonnelStuEntityRepositoryBase<TEntityBase> : EntityRepositoryBase<TEntityBase, IPersonnelStuDbFactory> where TEntityBase : EntityBase
    {
        public PersonnelStuEntityRepositoryBase(IPersonnelStuDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}