using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CollabClient
{
    public class WebSocket
    {
        // Fields
        private ClientWebSocket socket;
        private Uri uri;
        private string[] protocols;
        private bool closeHandled = false;

        // Properties
        
        public string Uri => uri.ToString();
        public string[] Protocols => protocols.ToArray();
        public Dictionary<string,string> Headers { get; set; }

        // Events
        public event EventHandler<WebSocketCloseEventArgs> OnClose;
        public event EventHandler OnOpen;
        public event EventHandler<string> OnTextMessage;
        public event EventHandler<byte[]> OnBinaryMessage;

        // Methods
        public WebSocket(string url, params string[] protocols)
        {
            this.uri = new Uri(url);
            this.protocols = protocols;
            this.Headers = new Dictionary<string, string>();
            // Register dummy handlers on events to prevent NullReferenceException
            OnClose += (s, e) => { };
            OnOpen += (s, e) => { };
            OnTextMessage += (s, e) => { };
            OnBinaryMessage += (s, e) => { };

        }

        public void Close(WebSocketCloseStatus status = WebSocketCloseStatus.NormalClosure, string reason = "")
        {
            if (this.socket.State != WebSocketState.Open) return;
            closeHandled = true;
            this.socket.CloseAsync(status, reason, CancellationToken.None).GetAwaiter().GetResult();
            this.socket.Dispose();
            this.socket = null;
            OnClose.Invoke(this, new WebSocketCloseEventArgs
            {
                Code = status,
                Reason = WebSocketCloseReason.CloseByClient,
                Message = reason,
            });
            closeHandled = false;
        }

        public async Task Connect()
        {
            if (this.socket != null && this.socket.State == WebSocketState.Open) Close();
            this.socket = new ClientWebSocket();
            foreach (string protocol in this.protocols) this.socket.Options.AddSubProtocol(protocol);
            foreach (KeyValuePair<string, string> header in Headers) this.socket.Options.SetRequestHeader(header.Key, header.Value);
            await this.socket.ConnectAsync(this.uri, CancellationToken.None);
            messageLoop();
            this.OnOpen.Invoke(this, new EventArgs());

        }

        public bool Send(string msg)
        {
            return Send(Encoding.UTF8.GetBytes(msg), WebSocketMessageType.Text);
        }

        public bool Send(byte[] msg, WebSocketMessageType type = WebSocketMessageType.Binary)
        {
            if (this.socket == null || this.socket.State != WebSocketState.Open) return false;
            this.socket.SendAsync(new ArraySegment<byte>(msg), type, true, CancellationToken.None).GetAwaiter().GetResult();
            return true;
        }

        private async void messageLoop()
        {
            ArraySegment<byte> recieveBuffer = new ArraySegment<byte>(new byte[8192]);
            do
            {
                using (var ms = new MemoryStream())
                {
                    WebSocketReceiveResult res;
                    do
                    {
                        try
                        {
                            res = await socket.ReceiveAsync(recieveBuffer, CancellationToken.None);
                        }
                        catch (WebSocketException ex)
                        {
                            if (this.socket == null || closeHandled) return;
                            this.socket.Dispose();
                            this.socket = null;
                            this.OnClose.Invoke(this, new WebSocketCloseEventArgs
                            {
                                Code = null,
                                Reason = WebSocketCloseReason.Error,
                                Message = ex.Message,
                            });
                            return;
                        }
                        if (res.MessageType == WebSocketMessageType.Close)
                        {
                            if (this.socket == null || closeHandled) return;
                            this.socket.Dispose();
                            this.socket = null;
                            this.OnClose.Invoke(this, new WebSocketCloseEventArgs
                            {
                                Code = res.CloseStatus,
                                Reason = WebSocketCloseReason.CloseByServer,
                                Message = res.CloseStatusDescription
                            });
                            return;
                        }
                        await ms.WriteAsync(recieveBuffer.Array, 0, res.Count);
                    } while (!res.EndOfMessage);
                    byte[] msgbytes = ms.ToArray();
                    if (res.MessageType == WebSocketMessageType.Binary) this.OnBinaryMessage.Invoke(this, msgbytes);
                    else if (res.MessageType == WebSocketMessageType.Text) this.OnTextMessage.Invoke(this, Encoding.UTF8.GetString(msgbytes));
                }
            } while (socket.State == WebSocketState.Open);
            if (this.socket == null || closeHandled) return;
            // this shouldn't happen I don't think but we'll handle it anyway
            this.socket.Dispose();
            this.socket = null;
            this.OnClose.Invoke(this, new WebSocketCloseEventArgs
            {
                Code = null,
                Reason = WebSocketCloseReason.CloseByServer,
                Message = ""
            });
            return;
        }
    }

    public class WebSocketCloseEventArgs
    {
        /// <summary>
        /// Closure code provided by the server, or null if the connection closed uncleanly
        /// </summary>
        public WebSocketCloseStatus? Code { get; set; }
        /// <summary>
        /// The reason for the closure
        /// </summary>
        public WebSocketCloseReason Reason { get; set; }
        public string Message { get; set; }
    }

    public enum WebSocketCloseReason
    {
        CloseByClient,
        CloseByServer,
        Error
    }
}
