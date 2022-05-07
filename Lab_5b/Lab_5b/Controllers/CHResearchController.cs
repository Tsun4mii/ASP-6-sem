using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab_5b.Controllers
{
    public class CHResearchController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        static int test = 4;
        [HttpGet]
        [OutputCache(Duration = 5, Location = System.Web.UI.OutputCacheLocation.Server)]
        public ActionResult AD()
        {
            test++;
            var time = DateTime.Now.ToString();
            return Content(time + "    " + test);
        }
        [HttpPost]
        [OutputCache(Duration = 7, Location = System.Web.UI.OutputCacheLocation.Any, VaryByParam = "a;b")]
        public ActionResult AP(string a, string b)
        {
            test++;

            var time = DateTime.Now.ToString();
            return Content(time + "    " + test + "    " + a + "    " + b);
        }
    }
}