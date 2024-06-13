using System.Runtime.Serialization;

namespace MarketsIQ.Services.Quantower.API.Client.Models.TradingSessions
{
    [DataContract]
    public class QHolidayInfo
    {
        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "date")]
        public DateTime Date { get; set; }
    }
}
