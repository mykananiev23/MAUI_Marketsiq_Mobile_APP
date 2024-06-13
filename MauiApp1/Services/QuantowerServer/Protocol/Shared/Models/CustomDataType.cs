using Google.Protobuf.Reflection;

namespace MarketsIQ.Services.QuantowerServer.Protocol.Shared.Models
{
    public enum CustomDataType
    {
        [OriginalName("BOOLEAN")]
        Boolean,
        [OriginalName("INTEGER")]
        Integer,
        [OriginalName("LONG")]
        Long,
        [OriginalName("DOUBLE")]
        Double,
        [OriginalName("STRING")]
        String
    }
}
