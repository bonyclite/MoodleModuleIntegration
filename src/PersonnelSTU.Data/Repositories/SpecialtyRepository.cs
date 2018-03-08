using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common.Data.Repositories;
using PersonnelSTU.Data.Infrastructure;
using PersonnelSTU.Domain;

namespace PersonnelSTU.Data.Repositories
{
    public interface ISpecialtyRepository : IEntityRepository<Specialty>
    {

    }

    public class SpecialtyRepository : PersonnelStuEntityRepositoryBase<Specialty>, ISpecialtyRepository
    {
        public SpecialtyRepository(IPersonnelStuDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}