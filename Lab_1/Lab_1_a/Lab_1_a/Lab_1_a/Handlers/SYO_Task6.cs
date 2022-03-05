using System;
using System.Web;

namespace Lab_1_a.Handlers
{
    public class SYO_Task6 : IHttpHandler
    {
        /// <summary>
        /// Вам потребуется настроить этот обработчик в файле Web.config вашего 
        /// веб-сайта и зарегистрировать его с помощью IIS, чтобы затем воспользоваться им.
        /// см. на этой странице: https://go.microsoft.com/?linkid=8101007
        /// </summary>
        #region Члены IHttpHandler

        public bool IsReusable
        {
            get { return true; }
        }

        public void ProcessRequest(HttpContext context)
        {
            if (context.Request.HttpMethod == "GET")
            {
                var res = context.Response;
                res.WriteFile("Task6.html");
            }
            else if (context.Request.HttpMethod == "POST")
            {
                var x = Convert.ToInt32(context.Request.Form.Get("x"));
                var y = Convert.ToInt32(context.Request.Form.Get("y"));

                var res = context.Response;
                res.ContentType = "text/plain";
                res.Write(x * y);
            }
        }

        #endregion
    }
}
