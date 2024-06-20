using Google.Protobuf.Reflection;

namespace MarketsIQ.Services.QuantowerServer.Protocol.Shared.Models
{
    public enum OperationStatus
    {
        [OriginalName("SUCCESS")]
        Success,
        [OriginalName("FAILED")]
        Failed
    }
}
