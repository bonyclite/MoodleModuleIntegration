using Common.Data.Infrastructure;

namespace Moodle3KL.Data.Infrastructure
{
    public interface IMoodle3KLDbFactory : IDbFactory
    {

    }

    public class Moodle3KLDbFactory : DbFactoryBase, IMoodle3KLDbFactory
    {
        protected override IDbContext Create()
        {
            return new DbContextAdapter(new Moodle3KLDbContext());
        }
    }
}