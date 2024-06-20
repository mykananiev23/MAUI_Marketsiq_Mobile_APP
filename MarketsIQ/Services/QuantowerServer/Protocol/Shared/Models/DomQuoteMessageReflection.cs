using Google.Protobuf.Reflection;

namespace MarketsIQ.Services.QuantowerServer.Protocol.Shared.Models
{
    public static class DomQuoteMessageReflection
    {
        private static FileDescriptor descriptor;

        public static FileDescriptor Descriptor => descriptor;

        static DomQuoteMessageReflection()
        {
            descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Chdkb21fcXVvdGVfbWVzc2FnZS5wcm90bxoabGV2ZWwyX3F1b3RlX21lc3Nh" + "Z2UucHJvdG8iVwoPRG9tUXVvdGVNZXNzYWdlEiEKBEJpZHMYASADKAsyEy5M" + "ZXZlbDJRdW90ZU1lc3NhZ2USIQoEQXNrcxgCIAMoCzITLkxldmVsMlF1b3Rl" + "TWVzc2FnZUIpqgImUXVhbnRvd2VyU2VydmVyLlByb3RvY29sLlNoYXJlZC5N" + "b2RlbHNiBnByb3RvMw=="), new FileDescriptor[1] { Level2QuoteMessageReflection.Descriptor }, new GeneratedClrTypeInfo(null, new GeneratedClrTypeInfo[1]
            {
            new GeneratedClrTypeInfo(typeof(DomQuoteMessage), DomQuoteMessage.Parser, new string[2] { "Bids", "Asks" }, null, null, null)
            }));
        }
    }
}
