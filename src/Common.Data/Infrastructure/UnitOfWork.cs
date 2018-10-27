using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common.Data.Infrastructure
{
    public interface IUnitOfWork
    {
        void Commit();
    }

    public class UnitOfWork : IUnitOfWork
    {
        private readonly IDbContext _dbContext;

        public UnitOfWork(IDbFactory databaseFactory)
        {
            _dbContext = databaseFactory.Get();
        }

        public void Commit()
        {
            _dbContext.SaveChanges();
        }
    }
}