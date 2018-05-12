using Common.Data.Infrastructure;

namespace Moodle3KL.Data.Infrastructure
{
    public class Moodle3KLDbFactory : DbFactoryBase
    {
        protected override IDbContext Create()
        {
            var sdfsd = AppConfig.MoodleDecanatConnectionString;
            var moodle3KlDbContext = new Moodle3KLDbContext();
            //moodle3KlDbContext.Database.Connection.Open();

            return new DbContextAdapter(moodle3KlDbContext);
        }
    }
}