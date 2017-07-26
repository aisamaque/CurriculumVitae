﻿using System.Web.Mvc;
using System.Web.Routing;

namespace CurriculumVitae.MVC
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.IgnoreRoute("");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Profile", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
