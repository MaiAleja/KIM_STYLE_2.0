using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace KIM_STYLE
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "User",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "User", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Administrator",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Administrator", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Customer",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Customer", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Employee",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Employee", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
