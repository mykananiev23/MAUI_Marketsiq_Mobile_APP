using MarketsIQ.Services.QuantowerServer.Protocol.Client.Models;

namespace MarketsIQ.Services.QuantowerServer.Protocol.Client
{
    public static class ClientProtocolHelper
    {
        public static ClientMessage DeserializeClientData(byte[] data, int offset, int dataLength)
        {
            return ClientMessage.Parser.ParseFrom(data, offset, dataLength);
        }

        public static ServerMessage DeserializeServerData(byte[] data, int offset, int dataLength)
        {
            return ServerMessage.Parser.ParseFrom(data, offset, dataLength);
        }
    }
}
