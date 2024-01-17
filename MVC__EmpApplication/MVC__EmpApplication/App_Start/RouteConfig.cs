using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVC__EmpApplication
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{EMPLOYEE_ID}",
                defaults: new { controller = "Home", action = "Index", EMPLOYEE_ID = UrlParameter.Optional }
            );
        }
    }
}
