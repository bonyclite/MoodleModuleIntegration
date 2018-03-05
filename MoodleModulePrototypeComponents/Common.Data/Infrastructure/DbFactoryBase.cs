namespace Common.Data.Infrastructure
{
    public interface IDbFactory
    {
        IDbContext Get();
    }

    public abstract class DbFactoryBase : IDbFactory
    {
        private IDbContext _dbContext;

        public IDbContext Get()
        {
            return _dbContext ?? (_dbContext = Create());
        }

        protected abstract IDbContext Create();
    }
}