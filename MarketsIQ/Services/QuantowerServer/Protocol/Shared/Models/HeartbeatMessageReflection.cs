using Google.Protobuf.Reflection;

namespace MarketsIQ.Services.QuantowerServer.Protocol.Shared.Models
{
    public static class HeartbeatMessageReflection
    {
        private static FileDescriptor descriptor;

        public static FileDescriptor Descriptor => descriptor;

        static HeartbeatMessageReflection()
        {
            descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChdoZWFydGJlYXRfbWVzc2FnZS5wcm90byISChBIZWFydGJlYXRNZXNzYWdl" + "QimqAiZRdWFudG93ZXJTZXJ2ZXIuUHJvdG9jb2wuU2hhcmVkLk1vZGVsc2IG" + "cHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, new GeneratedClrTypeInfo[1]
            {
            new GeneratedClrTypeInfo(typeof(HeartbeatMessage), HeartbeatMessage.Parser, null, null, null, null)
            }));
        }
    }
}
