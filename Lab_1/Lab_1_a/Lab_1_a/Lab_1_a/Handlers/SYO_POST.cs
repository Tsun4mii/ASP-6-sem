using System;
using System.Web;

namespace Lab_1_a.Handlers
{
    public class SYO_POST : IHttpHandler
    {

        public bool IsReusable
        {
            get { return true; }
        }

        public void ProcessRequest(HttpContext context)
        {
            string result = "POST-Http-SYO: ParamA = " + context.Request.Form.Get("ParamA") + " , ParamB = " + context.Request.Form.Get("ParamB");
            context.Response.Write(result);
        }

    }
}
