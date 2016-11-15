using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Mvc.Routing.Constraints;

namespace UrlsAndRoutes
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            //routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //routes.MapRoute(
            //    name: "Default",
            //    url: "{controller}/{action}/{id}",
            //    defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            //);

            //Route myRoute = new Route("{controller}/{action}", new MvcRouteHandler());
            //routes.Add("MyRoute", myRoute);

            routes.MapRoute("ShopSchema", "Shop/OldAction", new { Controller = "Home", Action = "Index" });

            routes.MapRoute("MyRoute", "{controller}/{action}");

            routes.MapRoute("", "Public/{controller}/{action}");

            routes.MapRoute("MyRoute2", "{controller}/{action}/{id}", new { Controller = "Home", Action = "Index", id = UrlParameter.Optional }, new { Controller = "^H.*", Action = "^Index$|^About$", HttpMethodConstraint = "GET", id = new  RangeRouteConstraint(10 ,20)}, new[] { "UrlsAndRoutes.AddtionalControllers" });
        }
    }
}
