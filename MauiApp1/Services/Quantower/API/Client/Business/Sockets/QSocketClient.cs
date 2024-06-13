using System.Diagnostics;
using System.Net.Sockets;
using System.Net;
using MarketsIQ.Services.Quantower.Utilities.ResponseWaiter;

namespace MarketsIQ.Services.Quantower.API.Client.Business.Sockets
{
    public abstract class QSocketClient
    {
        private class RequestWrapper : IRequest<int>
        {
            private readonly int key;

            int IRequest<int>.ResponseKey => key;

            public RequestWrapper(int key)
            {
                this.key = key;
            }
        }

        private class ResponseWrapper : IResponse<int>
        {
            int IResponse<int>.Key => Response?.RequestId ?? (-1);

            public ServerMessage Response { get; }

            public ResponseWrapper(ServerMessage response)
            {
                Response = response;
            }
        }

        private const int ESTABLISH_CONNECT_ATTEMPTS = 5;

        private readonly TimeSpan TIMER_PERIOD = TimeSpan.FromSeconds(1.0);

        private readonly TimeSpan PING_PERIOD = TimeSpan.FromSeconds(10.0);

        private readonly int pingCheckingPeriod;

        private int pingCounter;

        private readonly IStream stream;

        private readonly ResponseWaiter<int> responseWaiter;

        private int requestIdCounter;

        private readonly Timer timer;

        private readonly Stopwatch stopwatch;

        public QClientConnectionState ConnectionState => Convert(stream.State);

        public TimeSpan Ping { get; private set; }

        public event EventHandler<QSocketEventArgs> ConnectionStateChanged;

        protected QSocketClient()
        {
            stream = new SyncSocketStream<ProtobufPacketSeparator>();
            stream.DataReceived += Stream_DataReceived;
            stream.StateChanged += Stream_StateChanged;
            responseWaiter = new ResponseWaiter<int>(TimeSpan.FromSeconds(5.0));
            timer = new Timer(TimerCallback);
            stopwatch = new Stopwatch();
            pingCheckingPeriod = (int)(PING_PERIOD.Ticks / TIMER_PERIOD.Ticks);
        }

        public void Connect(EndPoint endPoint, CancellationToken cancellationToken)
        {
            stream.Connect(endPoint);
            for (int i = 0; i < 5; i++)
            {
                TimeSpan value = TimeSpan.FromSeconds(Math.Pow(2.0, i));
                ClientMessage clientMessage = new ClientMessage
                {
                    ConnectMessage = new ConnectMessage()
                };
                if (SendRequest(clientMessage, cancellationToken, value)?.ConnectMessage != null)
                {
                    timer.Change(TIMER_PERIOD, TIMER_PERIOD);
                    return;
                }
            }

            throw new InvalidOperationException("Can't establish connection with quotes server");
        }

        public void Logout()
        {
            ClientMessage clientMessage = new ClientMessage
            {
                LogoutRequest = new LogoutRequestMessage()
            };
            SendMessage(clientMessage);
            timer.Change(-1, -1);
        }

        private void Disconnect()
        {
            stream.Disconnect();
            responseWaiter.Clear();
        }

        protected ServerMessage SendRequest(ClientMessage clientMessage, CancellationToken token, TimeSpan? timeout = null)
        {
            int num = Interlocked.Increment(ref requestIdCounter);
            clientMessage.RequestId = num;
            RequestWrapper request = new RequestWrapper(num);
            if (!responseWaiter.WaitResponseAfter(delegate
            {
                SendMessage(clientMessage);
            }, request, out var response, token, timeout))
            {
                return null;
            }

            if (!(response is ResponseWrapper responseWrapper))
            {
                return null;
            }

            return responseWrapper.Response;
        }

        protected void SendMessage(ClientMessage clientMessage)
        {
            if (clientMessage == null)
            {
                throw new ArgumentNullException("clientMessage");
            }

            try
            {
                byte[] data = PrepareMessage(clientMessage);
                stream.SendData(data);
            }
            catch (Exception)
            {
            }
        }

        protected abstract void ProcessServerMessage(ServerMessage serverMessage);

        private void Stream_DataReceived(object sender, StreamEventArgs e)
        {
            try
            {
                ServerMessage serverMessage = ClientProtocolHelper.DeserializeServerData(e.Data, 4, e.DataLength - 4);
                ResponseWrapper response = new ResponseWrapper(serverMessage);
                if (!responseWaiter.CheckResponse(response))
                {
                    ProcessServerMessage(serverMessage);
                }
            }
            catch (Exception)
            {
            }
        }

        private void Stream_StateChanged(object sender, StreamEventArgs e)
        {
            OnConnectionStateChanged(Convert(e.StreamState));
            if (e.StreamState == StreamState.Disconnected)
            {
                Disconnect();
            }
        }

        private void TimerCallback(object state)
        {
            if (ConnectionState != QClientConnectionState.Connected)
            {
                return;
            }

            if (pingCounter++ >= pingCheckingPeriod)
            {
                pingCounter = 0;
                Task.Factory.StartNew(delegate
                {
                    stopwatch.Reset();
                    stopwatch.Start();
                    ServerMessage serverMessage = SendRequest(new ClientMessage
                    {
                        PingMessage = new PingMessage()
                    }, CancellationToken.None);
                    stopwatch.Stop();
                    Ping = stopwatch.Elapsed;
                });
            }

            try
            {
                OnTimerTick();
            }
            catch
            {
            }
        }

        protected virtual void OnTimerTick()
        {
        }

        private byte[] PrepareMessage(ClientMessage clientMessage)
        {
            try
            {
                byte[] data = ProtocolHelper.SerializeMessage(clientMessage);
                return ProtobufPacketSeparator.AddDataLengthToHeader(data);
            }
            catch (Exception)
            {
            }

            return null;
        }

        private static IPAddress GetLocalIPAddress()
        {
            IPHostEntry hostEntry = Dns.GetHostEntry(Dns.GetHostName());
            IPAddress[] addressList = hostEntry.AddressList;
            foreach (IPAddress iPAddress in addressList)
            {
                if (iPAddress.AddressFamily == AddressFamily.InterNetwork)
                {
                    return iPAddress;
                }
            }

            throw new Exception("No network adapters with an IPv4 address in the system!");
        }

        private void OnConnectionStateChanged(QClientConnectionState connectionState)
        {
            this.ConnectionStateChanged?.Invoke(this, new QSocketEventArgs
            {
                ConnectionState = connectionState
            });
        }

        private static QClientConnectionState Convert(StreamState streamState)
        {
            return streamState switch
            {
                StreamState.Idle => QClientConnectionState.Idle,
                StreamState.Connecting => QClientConnectionState.Connecting,
                StreamState.Connected => QClientConnectionState.Connected,
                StreamState.Disconnected => QClientConnectionState.Disconnected,
                _ => throw new ArgumentException(string.Format("Unknown {0} - {1}", "StreamState", streamState)),
            };
        }
    }
}
