using System.Diagnostics.CodeAnalysis;
using Common.Data.Infrastructure;

namespace PersonnelSTU.Data.Infrastructure
{
    [SuppressMessage("ReSharper", "ClassNeverInstantiated.Global")]
    public class PersonnelStuDbFactory : DbFactoryBase
    {
        protected override IDbContext Create()
        {
            return new DbContextAdapter(new PersonnelStuDbContext(AppConfig.FakePersonnelSTUDbConnectionString));
        }
    }
}