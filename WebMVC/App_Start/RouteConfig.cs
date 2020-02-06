using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WebMVC
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.MapMvcAttributeRoutes();
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapRoute(
                name: "Default_1",
                url: "{step}/{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "Default_2",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "Default_3",
                url: "{controller}/{action}/{year}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                constraints: new { year = @"\d+" }

            );
            routes.MapRoute(
                name: "Default_4",
                url: "{controller}/{action}/{year}/{month}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                constraints: new { year = @"\d+", month = @"\d+" }

            );
            routes.MapRoute(
                name: "Default_5",
                url: "{controller}/{action}/{year}/{month}/{date}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                constraints: new { year = @"\d+", month = @"\d+", date = @"\d+" }

            );

        }
    }
}
