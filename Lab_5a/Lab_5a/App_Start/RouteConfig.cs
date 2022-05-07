using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Lab_5a
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapMvcAttributeRoutes();
            //GET M01
            routes.MapRoute("M010", "MResearch", new { controller = "MResearch", action = "M01" });
            routes.MapRoute("M011", "MResearch/M01/1", new { controller = "MResearch", action = "M01" });
            routes.MapRoute("M012", "MResearch/M01", new { controller = "MResearch", action = "M01" });
            routes.MapRoute("M013", "", new { controller = "MResearch", action = "M01" });
            routes.MapRoute("M014", "V2/MResearch/M01", new { controller = "MResearch", action = "M01" });
            routes.MapRoute("M015", "V3/MResearch/X/M01", new { controller = "MResearch", action = "M01" });
            //GET M02
            routes.MapRoute("M021", "V2", new { controller = "MResearch", action = "M02" });
            routes.MapRoute("M022", "V2/MResearch", new { controller = "MResearch", action = "M02" });
            routes.MapRoute("M023", "V2/MResearch/M02", new { controller = "MResearch", action = "M02" });
            routes.MapRoute("M024", "MResearch/M02", new { controller = "MResearch", action = "M02" });
            routes.MapRoute("M025", "V3/MResearch/X/M02", new { controller = "MResearch", action = "M02" });
            //GET M03
            routes.MapRoute("M031", "V3", new { controller = "MResearch", action = "M03" });
            routes.MapRoute("M032", "V3/MResearch/X/", new { controller = "MResearch", action = "M03" });
            routes.MapRoute("M033", "V3/MResearch/X/M03", new { controller = "MResearch", action = "M03" });
            //GET C01
            routes.MapRoute("C011", "CResearch", new { controller = "CResearch", action = "C01" });
            routes.MapRoute("C012", "CResearch/C01", new { controller = "CResearch", action = "C01" });
            routes.MapRoute("C021", "CResearch/C02", new { controller = "CResearch", action = "C02" });

            routes.MapRoute(
            name: "Default",
            url: "{controller}/{action}/{id}",
            defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
