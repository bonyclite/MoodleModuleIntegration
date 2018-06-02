using Common.Data.Infrastructure;

namespace Moodle3KL.Data.Infrastructure
{
    public interface IMoodle3KLUnitOfWork : IUnitOfWork
    {

    }

    public class Moodle3KLUnitOfWork : UnitOfWork<IMoodle3KLDbFactory>, IMoodle3KLUnitOfWork
    {
        public Moodle3KLUnitOfWork(IMoodle3KLDbFactory databaseFactory) : base(databaseFactory)
        {
        }
    }
}