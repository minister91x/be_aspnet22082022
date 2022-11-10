﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WebApplicationDemoMVC
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
               name: "MyRouter1",
               url: "trang-chi-tiet-{name}/{id}",
               defaults: new { controller = "Home", action = "MyAction", name = UrlParameter.Optional, id = UrlParameter.Optional }
               );

            routes.MapRoute(
            name: "Chi-Tiet-Hoc-Vien",
            url: "thong-tin-hoc-vien/{name}-{id}",
            defaults: new { controller = "Home", action = "StudentInsertUpdate", name = UrlParameter.Optional, id = UrlParameter.Optional }
            );

            //routes.MapRoute(
            //    name: "MyRouter",
            //    url: "{controller}/{action}/{name}/{id}",
            //    defaults: new { controller = "Home", action = "MyAction", name = UrlParameter.Optional, id = UrlParameter.Optional }
            //    );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );


        }
    }
}
