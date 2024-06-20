using Google.Protobuf.Reflection;

namespace MarketsIQ.Services.QuantowerServer.Protocol.Shared.Models
{
    public static class DaybarQuoteMessageReflection
    {
        private static FileDescriptor descriptor;

        public static FileDescriptor Descriptor => descriptor;

        static DaybarQuoteMessageReflection()
        {
            descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChpkYXliYXJfcXVvdGVfbWVzc2FnZS5wcm90bxoLZW51bXMucHJvdG8ixAIK" + "EkRheUJhclF1b3RlTWVzc2FnZRIQCghCaWRQcmljZRgBIAEoARIPCgdCaWRT" + "aXplGAIgASgBEhAKCEFza1ByaWNlGAMgASgBEg8KB0Fza1NpemUYBCABKAES" + "EgoKVHJhZGVQcmljZRgFIAEoARIRCglUcmFkZVNpemUYBiABKAESFAoMT3Bl" + "bkludGVyZXN0GAcgASgBEgwKBE9wZW4YCCABKAESDAoESGlnaBgJIAEoARIL" + "CgNMb3cYCiABKAESEQoJUHJldkNsb3NlGAsgASgBEg4KBlZvbHVtZRgMIAEo" + "ARINCgVUaWNrcxgNIAEoAxIOCgZUcmFkZXMYDiABKAMSGwoTRXhwaXJhdGlv" + "bkRhdGVUaWNrcxhkIAEoAxIjCgxTZXNzaW9uU3RhdGUYbiABKA4yDS5TZXNz" + "aW9uU3RhdGVCKaoCJlF1YW50b3dlclNlcnZlci5Qcm90b2NvbC5TaGFyZWQu" + "TW9kZWxzYgZwcm90bzM="), new FileDescriptor[1] { EnumsReflection.Descriptor }, new GeneratedClrTypeInfo(null, new GeneratedClrTypeInfo[1]
            {
            new GeneratedClrTypeInfo(typeof(DayBarQuoteMessage), DayBarQuoteMessage.Parser, new string[16]
            {
                "BidPrice", "BidSize", "AskPrice", "AskSize", "TradePrice", "TradeSize", "OpenInterest", "Open", "High", "Low",
                "PrevClose", "Volume", "Ticks", "Trades", "ExpirationDateTicks", "SessionState"
            }, null, null, null)
            }));
        }
    }
}
