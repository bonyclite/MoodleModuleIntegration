using Common.Data.Infrastructure;

namespace Moodle3KL.Data.Infrastructure
{
    public class Moodle3KLDbFactory : DbFactoryBase
    {
        protected override IDbContext Create()
        {
            return new DbContextAdapter(new Moodle3KLDbContext());
        }
    }
}