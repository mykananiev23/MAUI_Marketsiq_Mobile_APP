using System.Runtime.Serialization;

namespace MarketsIQ.Services.Quantower.API.Client.Models.TradingSessions
{
    [DataContract]
    public class QSession
    {
        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "openTime")]
        public TimeSpan OpenTime { get; set; }

        [DataMember(Name = "closeTime")]
        public TimeSpan CloseTime { get; set; }

        [DataMember(Name = "type")]
        public QSessionType SessionType { get; set; }
    }
}
