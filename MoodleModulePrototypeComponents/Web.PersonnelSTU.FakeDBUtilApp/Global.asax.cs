using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace Web.PersonnelSTU.FakeDBUtilApp
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
        }
    }
}
