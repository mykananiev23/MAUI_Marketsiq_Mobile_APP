using Google.Protobuf.Reflection;

namespace MarketsIQ.Services.QuantowerServer.Protocol.Client.Models
{
    public static class ConnectMessageReflection
    {
        private static FileDescriptor descriptor;

        public static FileDescriptor Descriptor => descriptor;

        static ConnectMessageReflection()
        {
            descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChVjb25uZWN0X21lc3NhZ2UucHJvdG8iEAoOQ29ubmVjdE1lc3NhZ2VCKaoC" + "JlF1YW50b3dlclNlcnZlci5Qcm90b2NvbC5DbGllbnQuTW9kZWxzYgZwcm90" + "bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, new GeneratedClrTypeInfo[1]
            {
            new GeneratedClrTypeInfo(typeof(ConnectMessage), ConnectMessage.Parser, null, null, null, null)
            }));
        }
    }
}
