using System.Diagnostics.CodeAnalysis;
using Common.Data.Infrastructure;

namespace PersonnelSTU.Data.Infrastructure
{
    public interface IPersonnelStuDbFactory : IDbFactory
    {

    }

    [SuppressMessage("ReSharper", "ClassNeverInstantiated.Global")]
    public class PersonnelStuDbFactory : DbFactoryBase, IPersonnelStuDbFactory
    {
        protected override IDbContext Create()
        {
            return new DbContextAdapter(new PersonnelStuDbContext(AppConfig.FakePersonnelSTUDbConnectionString));
        }
    }
}