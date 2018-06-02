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

    public abstract class UnitOfWork<TDbFactory> : IUnitOfWork where TDbFactory : IDbFactory
    {
        private readonly IDbContext _dbContext;

        protected UnitOfWork(TDbFactory databaseFactory)
        {
            _dbContext = databaseFactory.Get();
        }

        public void Commit()
        {
            _dbContext.SaveChanges();
        }
    }
}