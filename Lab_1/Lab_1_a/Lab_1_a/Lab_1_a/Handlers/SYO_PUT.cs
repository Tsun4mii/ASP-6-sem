using System;
using System.Web;

namespace Lab_1_a.Handlers
{
    public class SYO_PUT : IHttpHandler
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
            string result = "Put-Http-SYO: ParamA = " + context.Request.Form.Get("ParamA") + ", ParamB = " + context.Request.Form.Get("ParamB");
            context.Response.Write(result);
        }

        #endregion
    }
}
