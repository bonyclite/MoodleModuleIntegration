using Common.Data.Infrastructure;

namespace Moodle3KL.Data.Infrastructure
{
    public interface IMoodle3KLDbFactory : IDbFactory
    {

    }

    public class Moodle3KLDbFactory : IMoodle3KLDbFactory
    {
        public IDbContext Get()
        {
            return new DbContextAdapter(new Moodle3KLDbContext());
        }
    }
}