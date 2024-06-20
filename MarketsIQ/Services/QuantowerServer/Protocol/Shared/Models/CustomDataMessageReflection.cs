using Google.Protobuf.Reflection;

namespace MarketsIQ.Services.QuantowerServer.Protocol.Shared.Models
{
    public static class CustomDataMessageReflection
    {
        private static FileDescriptor descriptor;

        public static FileDescriptor Descriptor => descriptor;

        static CustomDataMessageReflection()
        {
            descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChljdXN0b21fZGF0YV9tZXNzYWdlLnByb3RvGgtlbnVtcy5wcm90byKuAQoR" + "Q3VzdG9tRGF0YU1lc3NhZ2USHQoEVHlwZRgBIAEoDjIPLkN1c3RvbURhdGFU" + "eXBlEhYKDEJvb2xlYW5WYWx1ZRgDIAEoCEgAEhYKDEludGVnZXJWYWx1ZRgE" + "IAEoBUgAEhMKCUxvbmdWYWx1ZRgFIAEoA0gAEhUKC0RvdWJsZVZhbHVlGAYg" + "ASgBSAASFQoLU3RyaW5nVmFsdWUYByABKAlIAEIHCgVWYWx1ZUIpqgImUXVh" + "bnRvd2VyU2VydmVyLlByb3RvY29sLlNoYXJlZC5Nb2RlbHNiBnByb3RvMw=="), new FileDescriptor[1] { EnumsReflection.Descriptor }, new GeneratedClrTypeInfo(null, new GeneratedClrTypeInfo[1]
            {
            new GeneratedClrTypeInfo(typeof(CustomDataMessage), CustomDataMessage.Parser, new string[6] { "Type", "BooleanValue", "IntegerValue", "LongValue", "DoubleValue", "StringValue" }, new string[1] { "Value" }, null, null)
            }));
        }
    }
}
