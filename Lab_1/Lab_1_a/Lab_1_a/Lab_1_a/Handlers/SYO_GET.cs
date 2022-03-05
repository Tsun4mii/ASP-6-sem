using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab_1_a.Handlers
{
    public class SYO_GET : IHttpHandler
    {
        public bool IsReusable
        {
            get { return false;}
        }

        public void ProcessRequest(HttpContext context)
        {
            string result = "GET-Http-SYO: ParamA = " + context.Request.Params[0] + ", ParamB = " + context.Request.Params[1];
            context.Response.Write(result);
        }
    }
}