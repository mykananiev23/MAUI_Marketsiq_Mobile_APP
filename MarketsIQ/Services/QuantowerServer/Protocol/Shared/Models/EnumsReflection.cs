using Google.Protobuf.Reflection;

namespace MarketsIQ.Services.QuantowerServer.Protocol.Shared.Models
{
    public static class EnumsReflection
    {
        private static FileDescriptor descriptor;

        public static FileDescriptor Descriptor => descriptor;

        static EnumsReflection()
        {
            descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CgtlbnVtcy5wcm90byoqCg9PcGVyYXRpb25TdGF0dXMSCwoHU1VDQ0VTUxAA" + "EgoKBkZBSUxFRBABKjcKFU1hcmtldERhdGFSZXF1ZXN0VHlwZRINCglTVUJT" + "Q1JJQkUQABIPCgtVTlNVQlNDUklCRRABKkoKD01hcmtldFF1b3RlVHlwZRIK" + "CgZMRVZFTDEQABIKCgZMRVZFTDIQARIJCgVUUkFERRACEgcKA0RPTRADEgsK" + "B0RBWV9CQVIQBCpMCg5DdXN0b21EYXRhVHlwZRILCgdCT09MRUFOEAASCwoH" + "SU5URUdFUhABEggKBExPTkcQAhIKCgZET1VCTEUQAxIKCgZTVFJJTkcQBCo8" + "ChNSZXF1ZXN0UmVzcG9uc2VNb2RlEgsKB1JFUVVFU1QQABIMCghSRVNQT05T" + "RRABEgoKBkRJUkVDVBACKjkKDUFnZ3Jlc3NvckZsYWcSBwoDQlVZEAASCAoE" + "U0VMTBABEggKBE5PTkUQAhILCgdOT1RfU0VUEAMqHgoKTGV2ZWwyVHlwZRIH" + "CgNCSUQQABIHCgNBU0sQASo1CgxTZXNzaW9uU3RhdGUSDQoJVU5ERUZJTkVE" + "EAASCgoGT1BFTkVEEAESCgoGQ0xPU0VEEAJCKaoCJlF1YW50b3dlclNlcnZl" + "ci5Qcm90b2NvbC5TaGFyZWQuTW9kZWxzYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[8]
            {
            typeof(OperationStatus),
            typeof(MarketDataRequestType),
            typeof(MarketQuoteType),
            typeof(CustomDataType),
            typeof(RequestResponseMode),
            typeof(AggressorFlag),
            typeof(Level2Type),
            typeof(SessionState)
            }, null));
        }
    }
}
