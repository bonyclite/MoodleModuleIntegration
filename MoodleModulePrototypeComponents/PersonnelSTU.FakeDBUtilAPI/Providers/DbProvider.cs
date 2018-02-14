using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PersonnelSTU.Data.Infrastructure;
using PersonnelSTU.Data.Providers;

namespace PersonnelSTU.FakeDBUtilAPI.Providers
{
    public interface IDbProvider
    {
        IReadOnlyCollection<string> GetViews();
    }

    public class DbProvider : IDbProvider
    {
        public ISqlProvider SqlProvider { get; set; }

        public IReadOnlyCollection<string> GetViews()
        {
            SqlProvider.OpenConnection(AppConfig.PersonnelSTUDbConnectionString);
            var sqlReader = SqlProvider.ExecuteReader($@"Use {AppConfig.PersonnelSTUDbName} SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE = 'VIEW'");
            
            var views = new List<string>();

            while (sqlReader.Read())
            {
                views.Add(sqlReader["TABLE_NAME"].ToString());
            }

            SqlProvider.CloseLastOpenedConnection();

            return views;
        }
    }
}