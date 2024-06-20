using Google.Protobuf.Reflection;

namespace MarketsIQ.Services.QuantowerServer.Protocol.Shared.Models
{
    public static class MarketQuoteMessageReflection
    {
        private static FileDescriptor descriptor;

        public static FileDescriptor Descriptor => descriptor;

        static MarketQuoteMessageReflection()
        {
            descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChptYXJrZXRfcXVvdGVfbWVzc2FnZS5wcm90bxoLZW51bXMucHJvdG8aGmxl" + "dmVsMV9xdW90ZV9tZXNzYWdlLnByb3RvGhpsZXZlbDJfcXVvdGVfbWVzc2Fn" + "ZS5wcm90bxoXZG9tX3F1b3RlX21lc3NhZ2UucHJvdG8aGXRyYWRlX3F1b3Rl" + "X21lc3NhZ2UucHJvdG8aGmRheWJhcl9xdW90ZV9tZXNzYWdlLnByb3RvIpwC" + "ChJNYXJrZXRRdW90ZU1lc3NhZ2USHgoEVHlwZRgBIAEoDjIQLk1hcmtldFF1" + "b3RlVHlwZRIUCgxJbnN0cnVtZW50SWQYAiABKAUSDAoEVGltZRgDIAEoAxIl" + "CgZMZXZlbDEYCiABKAsyEy5MZXZlbDFRdW90ZU1lc3NhZ2VIABIlCgZMZXZl" + "bDIYCyABKAsyEy5MZXZlbDJRdW90ZU1lc3NhZ2VIABIfCgNEb20YDCABKAsy" + "EC5Eb21RdW90ZU1lc3NhZ2VIABIjCgVUcmFkZRgNIAEoCzISLlRyYWRlUXVv" + "dGVNZXNzYWdlSAASJQoGRGF5QmFyGA4gASgLMhMuRGF5QmFyUXVvdGVNZXNz" + "YWdlSABCBwoFcXVvdGVCKaoCJlF1YW50b3dlclNlcnZlci5Qcm90b2NvbC5T" + "aGFyZWQuTW9kZWxzYgZwcm90bzM="), new FileDescriptor[6]
            {
            EnumsReflection.Descriptor,
            Level1QuoteMessageReflection.Descriptor,
            Level2QuoteMessageReflection.Descriptor,
            DomQuoteMessageReflection.Descriptor,
            TradeQuoteMessageReflection.Descriptor,
            DaybarQuoteMessageReflection.Descriptor
            }, new GeneratedClrTypeInfo(null, new GeneratedClrTypeInfo[1]
            {
            new GeneratedClrTypeInfo(typeof(MarketQuoteMessage), MarketQuoteMessage.Parser, new string[8] { "Type", "InstrumentId", "Time", "Level1", "Level2", "Dom", "Trade", "DayBar" }, new string[1] { "Quote" }, null, null)
            }));
        }
    }
}
