using Google.Protobuf.Reflection;

namespace MarketsIQ.Services.QuantowerServer.Protocol.Shared.Models
{
    public static class RequestResponseMessageReflection
    {
        private static FileDescriptor descriptor;

        public static FileDescriptor Descriptor => descriptor;

        static RequestResponseMessageReflection()
        {
            descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch5yZXF1ZXN0X3Jlc3BvbnNlX21lc3NhZ2UucHJvdG8aGWN1c3RvbV9kYXRh" + "X21lc3NhZ2UucHJvdG8aC2VudW1zLnByb3RvIvkBChZSZXF1ZXN0UmVzcG9u" + "c2VNZXNzYWdlEhEKCU1lc3NhZ2VJZBgCIAEoBRIRCglSZXF1ZXN0SWQYAyAB" + "KAkSIgoETW9kZRgEIAEoDjIULlJlcXVlc3RSZXNwb25zZU1vZGUSEQoJRXJy" + "b3JUZXh0GAUgASgJEjsKCkN1c3RvbURhdGEYBiADKAsyJy5SZXF1ZXN0UmVz" + "cG9uc2VNZXNzYWdlLkN1c3RvbURhdGFFbnRyeRpFCg9DdXN0b21EYXRhRW50" + "cnkSCwoDa2V5GAEgASgNEiEKBXZhbHVlGAIgASgLMhIuQ3VzdG9tRGF0YU1l" + "c3NhZ2U6AjgBQimqAiZRdWFudG93ZXJTZXJ2ZXIuUHJvdG9jb2wuU2hhcmVk" + "Lk1vZGVsc2IGcHJvdG8z"), new FileDescriptor[2]
            {
            CustomDataMessageReflection.Descriptor,
            EnumsReflection.Descriptor
            }, new GeneratedClrTypeInfo(null, new GeneratedClrTypeInfo[1]
            {
            new GeneratedClrTypeInfo(typeof(RequestResponseMessage), RequestResponseMessage.Parser, new string[5] { "MessageId", "RequestId", "Mode", "ErrorText", "CustomData" }, null, null, new GeneratedClrTypeInfo[1])
            }));
        }
    }
}
