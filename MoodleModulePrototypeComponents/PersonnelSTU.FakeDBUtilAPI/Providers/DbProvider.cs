using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PersonnelSTU.FakeDBUtilAPI.Providers
{
    public interface IDbProvider
    {
        IReadOnlyCollection<string> GetViews();
    }

    public class DbProvider : IDbProvider
    {
        public IReadOnlyCollection<string> GetViews()
        {
            throw new NotImplementedException();
        }
    }
}