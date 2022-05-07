using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab_5b.Controllers
{
    [RoutePrefix("it")]
    public class MResearchController : Controller
    {
            public ActionResult Index()
            {
                return Content("GET:MResearch/Index");
            }
            
            [HttpPut]
            [Route("test/")]
            public ActionResult M06()
            {
            return Content("TEST");
            }

            [HttpGet]
            [Route("{n:int}/{name}")]
            public ActionResult M01B(int n, string name)
            {
                return Content("GET:M01:/" + n.ToString() + "/" + name);
            }
            [AcceptVerbs("GET", "POST")]
            [Route("{b:bool}/{letters:alpha}")]
            public ActionResult M02(bool b, string letters)
            {
                return Content(HttpContext.Request.HttpMethod + ":M02:/" + b.ToString() + "/" + letters);
            }

            [AcceptVerbs("GET", "DELETE")]
            [Route("{f:float}/{name:length(2,5)}")]
            public ActionResult M03(float f, string name)
            {
                return Content(HttpContext.Request.HttpMethod + ":M03:/" + f.ToString() + "/" + name);
            }
            [HttpPut]
            [Route("{letters:alpha}/{id:int:range(100,200)}")]
            public ActionResult M04(string letters, int id)
            {
                return Content(HttpContext.Request.HttpMethod + ":M04:/" + letters + "/" + id.ToString());
            }
            
            [HttpPost]
            [Route("{mail:regex(^\\w+@\\w+)}")]
            //[Route("{mail:CustomEmailConstrain}/")]
            public ActionResult M05(string mail)
            {
                return Content(HttpContext.Request.HttpMethod + ":M05:/" + mail);
            }
    }   
}