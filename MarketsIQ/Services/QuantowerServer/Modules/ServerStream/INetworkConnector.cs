using System;
using System.Net;

namespace MarketsIQ.Services.QuantowerServer.Modules.ServerStream
{
    public interface INetworkConnector : IDisposable
    {
        int OnlineClients { get; }

        int IncomingConnectionsQueueDepth { get; }

        event EventHandler<StreamEventArgs> StreamConnected;

        event EventHandler<StreamEventArgs> StreamDataReceived;

        event EventHandler<StreamEventArgs> StreamStateChanged;

        void Initialize(EndPoint endPoint);

        void Disconnect(int connectionIndex, string reason);

        void SendData(byte[] data, int connectionIndex);
    }
}
