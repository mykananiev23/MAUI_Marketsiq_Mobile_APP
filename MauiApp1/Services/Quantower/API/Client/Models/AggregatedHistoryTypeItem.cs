namespace MarketsIQ.Services.Quantower.API.Client.Models
{
    public class AggregatedHistoryTypeItem
    {
        public string period { get; set; }

        public int multiplier { get; set; }

        public QHistoryType type { get; set; }
    }
}
