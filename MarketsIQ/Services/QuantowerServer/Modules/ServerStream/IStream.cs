using System;
using System.Net;

namespace MarketsIQ.Services.QuantowerServer.Modules.ServerStream
{
    public interface IStream
    {
        int Id { get; }

        StreamState State { get; set; }

        event EventHandler<StreamEventArgs> StateChanged;

        event EventHandler<StreamEventArgs> DataReceived;

        void Connect(EndPoint endPoint);

        void Disconnect(Exception exception = null);

        void SendData(byte[] data);
    }
}
