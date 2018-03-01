using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using PersonnelSTU.Data.Infrastructure;
using PersonnelSTU.Data.Providers;

namespace PersonnelSTU.FakeDBUtilAPI.Providers
{
    public interface IFakeDbProvider : IDbProvider
    {
        void CreateFakeDb(IEnumerable<string> viewNames);
    }

    [SuppressMessage("ReSharper", "ClassNeverInstantiated.Global")]
    [SuppressMessage("ReSharper", "UnusedMember.Global")]
    [SuppressMessage("ReSharper", "MemberCanBePrivate.Global")]
    [SuppressMessage("ReSharper", "UnusedAutoPropertyAccessor.Global")]
    public class FakeDbProvider : IFakeDbProvider
    {
        public ISqlProvider SqlProvider { get; set; }

        public IReadOnlyCollection<string> GetViews()
        {
            return Enumerable.Range(0, 10).Select(i => Guid.NewGuid().ToString()).ToArray();
            SqlProvider.OpenConnection(AppConfig.FakePersonnelSTUDbConnectionString);
            var sqlReader = SqlProvider.ExecuteReader(
                $@"Use {
                        AppConfig.PersonnelSTUDbName
                    } SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE = 'VIEW'");

            var views = new List<string>();

            while (sqlReader.Read())
            {
                views.Add(sqlReader["TABLE_NAME"].ToString());
            }

            SqlProvider.CloseLastOpenedConnection();

            return views;
        }

        public void CreateFakeDb(IEnumerable<string> viewNames)
        {
        }

        private void CreateTable()
        {
        }
    }
}