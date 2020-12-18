﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using UrlsAndRoutes.Infrastructure;

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
            //routes.MapRoute("ShopSchema2", "Shop/OldAction", new { controller = "Home", action = "Index" });

            //routes.MapRoute("ShopSchema", "Shop/{action}", new { controller = "Home" });

            //routes.MapRoute("", "X{controller}/{action}");

            //routes.MapRoute("MyRoute", "{controller}/{action}", new { controller = "Home", action = "Index" });

            //routes.MapRoute("", "Public/{controller}/{action}", new { controller = "Home", action = "Index" });

            //routes.MapRoute("MyRoute", "{controller}/{action}/{id}", 
            //    new { controller = "Home", action = "Index", id = "DefaultId" });

            //routes.MapRoute("MyRoute", "{controller}/{action}/{id}",
            //    new { controller = "Home", action = "Index", id = UrlParameter.Optional });

            // If a matching controller cannot be found, then the framework will not search elsewhere.
            //Route myRoute = routes.MapRoute("MyRoute", "{controller}/{action}/{id}/{*catchall}",
            //    new { controller = "Home", action = "Index", id = UrlParameter.Optional },
            //    new[] { "URLsAndRoutes.AdditionalControllers" });
            //myRoute.DataTokens["UseNamespaceFallback"] = false;

            // Constrain a route using a regular expression
            //routes.MapRoute("MyRoute", "{controller}/{action}/{id}/{*catchall}",
            //    new { controller = "Home", action = "Index", id = UrlParameter.Optional },
            //    new { controller = "^H.*", action = "Index|About", httpMethod = new HttpMethodConstraint("GET", "POST") },
            //    new[] { "URLsAndRoutes.Controllers" });

            // Apply a custom constraint in a route
            routes.MapRoute("ChromeRoute", "{*catchall}",
                new { controller = "Home", action = "Index" },
                new { customConstraint = new UserAgentConstraint("Chrome") },
                new[] { "URLsAndRoutes.AdditionalControllers" });

            routes.MapRoute("MyRoute", "{controller}/{action}/{id}/{*catchall}",
                new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                new[] { "URLsAndRoutes.Controllers" });
        }
    }
}
