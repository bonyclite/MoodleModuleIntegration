using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PersonnelSTU.FakeDBUtilAPI.Providers
{
    public interface IFakeDbProvider : IDbProvider
    {
        void CreateFakeDb(string dbName);
    }

    public class FakeDbProvider : IFakeDbProvider
    {
        public IDbProvider DbProvider { get; set; }

        public IReadOnlyCollection<string> GetViews()
        {
            return Enumerable.Empty<string>().ToArray();
        }

        public void CreateFakeDb(string dbName)
        {
            throw new NotImplementedException();
        }
    }
}