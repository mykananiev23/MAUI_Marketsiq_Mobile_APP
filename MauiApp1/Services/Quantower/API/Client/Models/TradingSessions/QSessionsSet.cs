using System.Runtime.Serialization;

namespace MarketsIQ.Services.Quantower.API.Client.Models.TradingSessions
{
    [DataContract]
    public class QSessionsSet
    {
        [DataMember(Name = "sessions")]
        public IEnumerable<QSession> Sessions { get; set; }

        [DataMember(Name = "days")]
        public IEnumerable<DayOfWeek> Days { get; set; }

        [DataMember(Name = "certainDates")]
        public IEnumerable<DateTime> CertainDates { get; set; }
    }
}
