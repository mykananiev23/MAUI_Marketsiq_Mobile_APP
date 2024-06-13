using Google.Protobuf.Reflection;

namespace MarketsIQ.Services.QuantowerServer.Protocol.Client.Models
{
    public static class PingMessageReflection
    {
        private static FileDescriptor descriptor;

        public static FileDescriptor Descriptor => descriptor;

        static PingMessageReflection()
        {
            descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChJwaW5nX21lc3NhZ2UucHJvdG8iDQoLUGluZ01lc3NhZ2VCKaoCJlF1YW50" + "b3dlclNlcnZlci5Qcm90b2NvbC5DbGllbnQuTW9kZWxzYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, new GeneratedClrTypeInfo[1]
            {
            new GeneratedClrTypeInfo(typeof(PingMessage), PingMessage.Parser, null, null, null, null)
            }));
        }
    }
}
