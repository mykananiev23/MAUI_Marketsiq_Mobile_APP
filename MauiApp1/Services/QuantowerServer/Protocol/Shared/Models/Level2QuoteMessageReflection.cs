using Google.Protobuf.Reflection;

namespace MarketsIQ.Services.QuantowerServer.Protocol.Shared.Models
{
    public static class Level2QuoteMessageReflection
    {
        private static FileDescriptor descriptor;

        public static FileDescriptor Descriptor => descriptor;

        static Level2QuoteMessageReflection()
        {
            descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChpsZXZlbDJfcXVvdGVfbWVzc2FnZS5wcm90bxoLZW51bXMucHJvdG8ibAoS" + "TGV2ZWwyUXVvdGVNZXNzYWdlEgwKBE1taWQYASABKAkSGQoEVHlwZRgCIAEo" + "DjILLkxldmVsMlR5cGUSEAoIaXNDbG9zZWQYAyABKAgSDQoFUHJpY2UYBCAB" + "KAESDAoEU2l6ZRgFIAEoAUIpqgImUXVhbnRvd2VyU2VydmVyLlByb3RvY29s" + "LlNoYXJlZC5Nb2RlbHNiBnByb3RvMw=="), new FileDescriptor[1] { EnumsReflection.Descriptor }, new GeneratedClrTypeInfo(null, new GeneratedClrTypeInfo[1]
            {
            new GeneratedClrTypeInfo(typeof(Level2QuoteMessage), Level2QuoteMessage.Parser, new string[5] { "Mmid", "Type", "IsClosed", "Price", "Size" }, null, null, null)
            }));
        }
    }
}
