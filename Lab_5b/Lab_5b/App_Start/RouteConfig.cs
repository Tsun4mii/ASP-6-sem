using Lab_5b.CustomEmailConstrain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Routing;
using System.Web.Routing;

namespace Lab_5b
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            var constraintsResolver = new DefaultInlineConstraintResolver();
            constraintsResolver.ConstraintMap.Add("CustomEmailConstrain", typeof(CustomEmailConstraint));
            routes.MapMvcAttributeRoutes(constraintsResolver);

            routes.MapRoute(
                name: "AResearch",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "AResearch", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "CHResearch",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "CHResearch", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
