using Google.Protobuf.Reflection;

namespace MarketsIQ.Services.QuantowerServer.Protocol.Client.Models
{
    public static class LogoutRequestMessageReflection
    {
        private static FileDescriptor descriptor;

        public static FileDescriptor Descriptor => descriptor;

        static LogoutRequestMessageReflection()
        {
            descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Chxsb2dvdXRfcmVxdWVzdF9tZXNzYWdlLnByb3RvIhYKFExvZ291dFJlcXVl" + "c3RNZXNzYWdlQimqAiZRdWFudG93ZXJTZXJ2ZXIuUHJvdG9jb2wuQ2xpZW50" + "Lk1vZGVsc2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, new GeneratedClrTypeInfo[1]
            {
            new GeneratedClrTypeInfo(typeof(LogoutRequestMessage), LogoutRequestMessage.Parser, null, null, null, null)
            }));
        }
    }
}
