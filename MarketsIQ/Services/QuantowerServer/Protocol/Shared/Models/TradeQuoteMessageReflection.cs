using Google.Protobuf.Reflection;

namespace MarketsIQ.Services.QuantowerServer.Protocol.Shared.Models
{
    public static class TradeQuoteMessageReflection
    {
        private static FileDescriptor descriptor;

        public static FileDescriptor Descriptor => descriptor;

        static TradeQuoteMessageReflection()
        {
            descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Chl0cmFkZV9xdW90ZV9tZXNzYWdlLnByb3RvGgtlbnVtcy5wcm90byJtChFU" + "cmFkZVF1b3RlTWVzc2FnZRINCgVQcmljZRgBIAEoARIMCgRTaXplGAIgASgB" + "EhQKDE9wZW5JbnRlcmVzdBgDIAEoARIlCg1BZ2dyZXNzb3JGbGFnGAQgASgO" + "Mg4uQWdncmVzc29yRmxhZ0IpqgImUXVhbnRvd2VyU2VydmVyLlByb3RvY29s" + "LlNoYXJlZC5Nb2RlbHNiBnByb3RvMw=="), new FileDescriptor[1] { EnumsReflection.Descriptor }, new GeneratedClrTypeInfo(null, new GeneratedClrTypeInfo[1]
            {
            new GeneratedClrTypeInfo(typeof(TradeQuoteMessage), TradeQuoteMessage.Parser, new string[4] { "Price", "Size", "OpenInterest", "AggressorFlag" }, null, null, null)
            }));
        }
    }
}
