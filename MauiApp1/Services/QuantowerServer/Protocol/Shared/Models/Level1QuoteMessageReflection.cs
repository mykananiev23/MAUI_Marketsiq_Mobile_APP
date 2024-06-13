using Google.Protobuf.Reflection;

namespace MarketsIQ.Services.QuantowerServer.Protocol.Shared.Models
{
    public static class Level1QuoteMessageReflection
    {
        private static FileDescriptor descriptor;

        public static FileDescriptor Descriptor => descriptor;

        static Level1QuoteMessageReflection()
        {
            descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChpsZXZlbDFfcXVvdGVfbWVzc2FnZS5wcm90byJaChJMZXZlbDFRdW90ZU1l" + "c3NhZ2USEAoIQmlkUHJpY2UYASABKAESDwoHQmlkU2l6ZRgCIAEoARIQCghB" + "c2tQcmljZRgDIAEoARIPCgdBc2tTaXplGAQgASgBQimqAiZRdWFudG93ZXJT" + "ZXJ2ZXIuUHJvdG9jb2wuU2hhcmVkLk1vZGVsc2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, new GeneratedClrTypeInfo[1]
            {
            new GeneratedClrTypeInfo(typeof(Level1QuoteMessage), Level1QuoteMessage.Parser, new string[4] { "BidPrice", "BidSize", "AskPrice", "AskSize" }, null, null, null)
            }));
        }
    }
}
