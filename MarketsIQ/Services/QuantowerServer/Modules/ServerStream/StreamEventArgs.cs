namespace MarketsIQ.Services.QuantowerServer.Modules.ServerStream
{
    public class StreamEventArgs : EventArgs
    {
        public StreamState StreamState { get; }

        public int StreamId { get; }

        public byte[] Data { get; }

        public int DataLength { get; }

        public StreamEventArgs(StreamState streamState, int streamId, byte[] data = null, int dataLength = 0)
        {
            StreamState = streamState;
            StreamId = streamId;
            Data = data;
            DataLength = dataLength;
        }
    }
}
