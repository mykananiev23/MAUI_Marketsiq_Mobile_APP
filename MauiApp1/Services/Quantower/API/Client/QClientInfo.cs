namespace MarketsIQ.Services.Quantower.API.Client
{
    public class QClientInfo
    {
        public Func<DateTime> GetClientTime;

        public string Id { get; set; }

        public string Branding { get; set; }

        public Version Version { get; set; }

        public QClientInfo()
        {
            GetClientTime = () => DateTime.UtcNow;
        }
    }
}
