using System.Web.Mvc;
using System.Web.Routing;

namespace EducationalPlans.Parser.UI.App
{
    public class RouteConfig
    {
        public static void RegisterRoutes()
        {
            RouteTable.Routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}