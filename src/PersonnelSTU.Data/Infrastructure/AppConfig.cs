using System.Configuration;
using System.Diagnostics.CodeAnalysis;

namespace PersonnelSTU.Data.Infrastructure
{
    [SuppressMessage("ReSharper", "InconsistentNaming")]
    public static class AppConfig
    {
        public static string FakePersonnelSTUDbName => ConfigurationManager.AppSettings["FakePersonnelSTUDb"];

        public static string PersonnelSTUDbName => ConfigurationManager.AppSettings["PersonnelSTUDbName"];

        public static string FakePersonnelSTUDbConnectionString =>
            ConfigurationManager.ConnectionStrings["FakePersonnelSTUDb"].ConnectionString;

        public static string PersonnelSTUDbConnectionString =>
            ConfigurationManager.ConnectionStrings["PersonnelSTUDb"].ConnectionString;
    }
}