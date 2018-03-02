using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common.Data.Infrastructure;

namespace PersonnelSTU.Data.Infrastructure
{
    public interface IPersonnelStuDbFactory : IDbFactory
    {
        
    }

    public class PersonnelStuDbFactory : DbFactoryBase, IPersonnelStuDbFactory
    {
        protected override IDbContext Create()
        {
            return new DbContextAdapter(new PersonnelStuDbContext());
        }
    }
}