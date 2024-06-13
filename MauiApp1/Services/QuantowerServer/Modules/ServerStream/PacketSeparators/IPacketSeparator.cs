namespace MarketsIQ.Services.QuantowerServer.Modules.ServerStream.PacketSeparators
{
    public interface IPacketSeparator
    {
        int HeaderLength { get; }

        int GetPacketLength(byte[] header);
    }
}
