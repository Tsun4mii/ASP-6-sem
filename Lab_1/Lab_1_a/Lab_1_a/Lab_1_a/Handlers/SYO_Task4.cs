using System;
using System.Web;

namespace Lab_1_a.Handlers
{
    public class SYO_Task4 : IHttpHandler
    {
        #region Члены IHttpHandler

        public bool IsReusable
        {
            // Верните значение false в том случае, если ваш управляемый обработчик не может быть повторно использован для другого запроса.
            // Обычно значение false соответствует случаю, когда некоторые данные о состоянии сохранены по запросу.
            get { return true; }
        }

        public void ProcessRequest(HttpContext context)
        {
            int x = Convert.ToInt32(context.Request.Form.Get("x"));
            int y = Convert.ToInt32(context.Request.Form.Get("y"));
            int sum = x + y;
            context.Response.Write(sum);
        }

        #endregion
    }
}
