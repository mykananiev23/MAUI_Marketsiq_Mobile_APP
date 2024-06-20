using Google.Protobuf.Reflection;

namespace MarketsIQ.Services.QuantowerServer.Protocol.Client.Models
{
    public static class DisconnectMessageReflection
    {
        private static FileDescriptor descriptor;

        public static FileDescriptor Descriptor => descriptor;

        static DisconnectMessageReflection()
        {
            descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChhkaXNjb25uZWN0X21lc3NhZ2UucHJvdG8iIwoRRGlzY29ubmVjdE1lc3Nh" + "Z2USDgoGUmVhc29uGAEgASgJQimqAiZRdWFudG93ZXJTZXJ2ZXIuUHJvdG9j" + "b2wuQ2xpZW50Lk1vZGVsc2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, new GeneratedClrTypeInfo[1]
            {
            new GeneratedClrTypeInfo(typeof(DisconnectMessage), DisconnectMessage.Parser, new string[1] { "Reason" }, null, null, null)
            }));
        }
    }
}
