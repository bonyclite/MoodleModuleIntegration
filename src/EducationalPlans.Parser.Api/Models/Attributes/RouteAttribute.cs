using System;

namespace EducationalPlans.Parser.Api.Models.Attributes
{
    public class RouteAttribute : Attribute
    {
        public string Route { get; set; }

        public RouteAttribute(string route)
        {
            Route = route;
        }
    }
}