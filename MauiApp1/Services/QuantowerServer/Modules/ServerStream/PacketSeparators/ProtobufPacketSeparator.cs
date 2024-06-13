namespace MarketsIQ.Services.QuantowerServer.Modules.ServerStream.PacketSeparators
{
    public class ProtobufPacketSeparator : IPacketSeparator
    {
        public const int HEADER_LENGTH = 4;

        public int HeaderLength => 4;

        public int GetPacketLength(byte[] header)
        {
            return BitConverter.ToInt32(header, 0);
        }

        public static byte[] AddDataLengthToHeader(byte[] data)
        {
            int num = data.Length + 4;
            byte[] bytes = BitConverter.GetBytes(num);
            byte[] array = new byte[num];
            Buffer.BlockCopy(bytes, 0, array, 0, 4);
            Buffer.BlockCopy(data, 0, array, 4, data.Length);
            return array;
        }
    }
}
