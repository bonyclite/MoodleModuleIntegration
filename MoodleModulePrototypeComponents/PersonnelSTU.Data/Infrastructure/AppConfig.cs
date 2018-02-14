using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;

namespace PersonnelSTU.Data.Infrastructure
{
    public static class AppConfig
    {
        public static string FakePersonnelSTUDbName => ConfigurationManager.AppSettings["FakePersonnelSTUDb"];

        public static string PersonnelSTUDbName => ConfigurationManager.AppSettings["PersonnelSTUDbName"];

        public static string FakePersonnelSTUDbConnectionString => ConfigurationManager.ConnectionStrings["FakePersonnelSTUDb"].ConnectionString;

        public static string PersonnelSTUDbConnectionString => ConfigurationManager.ConnectionStrings["PersonnelSTUDb"].ConnectionString;
    }
}