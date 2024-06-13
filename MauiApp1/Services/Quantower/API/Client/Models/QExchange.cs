using System.Runtime.Serialization;

namespace MarketsIQ.Services.Quantower.API.Client.Models
{
    [DataContract]
    public class QExchange
    {
        [DataMember(Name = "id")]
        public int Id { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "description")]
        public string Description { get; set; }

        [DataMember(Name = "sessionsContainerId")]
        public int SessionsContainerId { get; set; }
    }
}
