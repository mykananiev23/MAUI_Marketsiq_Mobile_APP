using Google.Protobuf.Reflection;

namespace MarketsIQ.Services.QuantowerServer.Protocol.Shared.Models
{
    public static class OperationResultMessageReflection
    {
        private static FileDescriptor descriptor;

        public static FileDescriptor Descriptor => descriptor;

        static OperationResultMessageReflection()
        {
            descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch5vcGVyYXRpb25fcmVzdWx0X21lc3NhZ2UucHJvdG8aC2VudW1zLnByb3Rv" + "InUKFk9wZXJhdGlvblJlc3VsdE1lc3NhZ2USIAoGU3RhdHVzGAEgASgOMhAu" + "T3BlcmF0aW9uU3RhdHVzEhEKCUVycm9yQ29kZRgCIAEoBRIRCglFcnJvclRl" + "eHQYAyABKAkSEwoLUmVzdWx0VmFsdWUYBCABKAlCKaoCJlF1YW50b3dlclNl" + "cnZlci5Qcm90b2NvbC5TaGFyZWQuTW9kZWxzYgZwcm90bzM="), new FileDescriptor[1] { EnumsReflection.Descriptor }, new GeneratedClrTypeInfo(null, new GeneratedClrTypeInfo[1]
            {
            new GeneratedClrTypeInfo(typeof(OperationResultMessage), OperationResultMessage.Parser, new string[4] { "Status", "ErrorCode", "ErrorText", "ResultValue" }, null, null, null)
            }));
        }
    }
}
