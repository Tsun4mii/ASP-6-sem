using System;
using System.Net.WebSockets;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.WebSockets;

namespace Lab_1_a.Handlers
{
    public class SYO_Task7 : IHttpHandler
    {
        /// <summary>
        /// Вам потребуется настроить этот обработчик в файле Web.config вашего 
        /// веб-сайта и зарегистрировать его с помощью IIS, чтобы затем воспользоваться им.
        /// см. на этой странице: https://go.microsoft.com/?linkid=8101007
        /// </summary>
        #region Члены IHttpHandler

        public bool IsReusable
        {

            get { return false; }
        }

        WebSocket socket; 

        public void ProcessRequest(HttpContext context)
        {
            if(context.IsWebSocketRequest)
            {
                context.AcceptWebSocketRequest(WebSocketRequest);
            }
        }
        private async Task WebSocketRequest(AspNetWebSocketContext context)
        {
            socket = context.WebSocket;
            string message = await Receive();
            await Send(message);
            while (socket.State == WebSocketState.Open)
            {
                System.Threading.Thread.Sleep(2000);
                await Send("[" + DateTime.Now.ToString() + "]");
            }
            await socket.CloseAsync(WebSocketCloseStatus.Empty, "connection end", CancellationToken.None);

        }
        private async Task<string> Receive()
        {
            string rc = null;
            var buffer = new ArraySegment<byte>(new byte[512]);
            var result = await socket.ReceiveAsync(buffer, CancellationToken.None);
            rc = System.Text.Encoding.UTF8.GetString(buffer.Array, 0, result.Count);
            return rc;
        }
        private async Task Send(string s)
        {
            var sendbuffer = new ArraySegment<byte>(System.Text.Encoding.UTF8.GetBytes("response:" + s));
            await socket.SendAsync(sendbuffer, System.Net.WebSockets.WebSocketMessageType.Text,
            true, CancellationToken.None);
        }
        #endregion
    }
}
