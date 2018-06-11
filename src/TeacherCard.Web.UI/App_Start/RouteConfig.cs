using System.Web.Mvc;
using System.Web.Routing;

namespace TeacherCard.Web.UI
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Teacher", action = "Details", id = UrlParameter.Optional }
            );
        }
    }
}
