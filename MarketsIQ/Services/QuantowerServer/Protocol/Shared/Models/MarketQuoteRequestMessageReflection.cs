using Google.Protobuf.Reflection;

namespace MarketsIQ.Services.QuantowerServer.Protocol.Shared.Models
{
    public static class MarketQuoteRequestMessageReflection
    {
        private static FileDescriptor descriptor;

        public static FileDescriptor Descriptor => descriptor;

        static MarketQuoteRequestMessageReflection()
        {
            descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiJtYXJrZXRfcXVvdGVfcmVxdWVzdF9tZXNzYWdlLnByb3RvGgtlbnVtcy5w" + "cm90byJxChlNYXJrZXRRdW90ZVJlcXVlc3RNZXNzYWdlEhQKDEluc3RydW1l" + "bnRJZBgBIAEoBRIpCg9NYXJrZXRRdW90ZVR5cGUYAiABKA4yEC5NYXJrZXRR" + "dW90ZVR5cGUSEwoLaXNTdWJzY3JpYmUYAyABKAhCKaoCJlF1YW50b3dlclNl" + "cnZlci5Qcm90b2NvbC5TaGFyZWQuTW9kZWxzYgZwcm90bzM="), new FileDescriptor[1] { EnumsReflection.Descriptor }, new GeneratedClrTypeInfo(null, new GeneratedClrTypeInfo[1]
            {
            new GeneratedClrTypeInfo(typeof(MarketQuoteRequestMessage), MarketQuoteRequestMessage.Parser, new string[3] { "InstrumentId", "MarketQuoteType", "IsSubscribe" }, null, null, null)
            }));
        }
    }
}
