using Google.Protobuf.Reflection;

namespace MarketsIQ.Services.QuantowerServer.Protocol.Client.Models
{
    public static class LogonRequestMessageReflection
    {
        private static FileDescriptor descriptor;

        public static FileDescriptor Descriptor => descriptor;

        static LogonRequestMessageReflection()
        {
            descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Chtsb2dvbl9yZXF1ZXN0X21lc3NhZ2UucHJvdG8iJAoTTG9nb25SZXF1ZXN0" + "TWVzc2FnZRINCgVUb2tlbhgBIAEoCUIpqgImUXVhbnRvd2VyU2VydmVyLlBy" + "b3RvY29sLkNsaWVudC5Nb2RlbHNiBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, new GeneratedClrTypeInfo[1]
            {
            new GeneratedClrTypeInfo(typeof(LogonRequestMessage), LogonRequestMessage.Parser, new string[1] { "Token" }, null, null, null)
            }));
        }
    }
}
