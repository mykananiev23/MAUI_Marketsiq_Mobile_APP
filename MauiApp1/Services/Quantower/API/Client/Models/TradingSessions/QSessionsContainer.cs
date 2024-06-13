using System.Runtime.Serialization;

namespace MarketsIQ.Services.Quantower.API.Client.Models.TradingSessions
{
    [DataContract]
    public class QSessionsContainer
    {
        [DataMember(Name = "id")]
        public int Id { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "description")]
        public string Description { get; set; }

        [DataMember(Name = "holidays")]
        public IEnumerable<QHolidayInfo> Holidays { get; set; }

        [DataMember(Name = "sessionSets")]
        public IEnumerable<QSessionsSet> SessionsSets { get; set; }
    }
}
