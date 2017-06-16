﻿using simpleBlog.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace simpleBlog
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            string[] namespaces = new[] { typeof(PostsController).Namespace };

            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute("Login", "login",
                new { controller = "Auth", action = "Login" },
                namespaces);

            routes.MapRoute("Home", "",
                new { controller = "Posts", action = "Index" },
                namespaces);
        }
    }
}
