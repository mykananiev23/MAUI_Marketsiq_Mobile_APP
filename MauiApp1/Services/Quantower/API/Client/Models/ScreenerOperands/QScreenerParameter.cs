using Newtonsoft.Json;

namespace MarketsIQ.Services.Quantower.API.Client.Models.ScreenerOperands
{
    public class QScreenerParameter
    {
        public const string GENERAL_GROUP = "General";

        public const string MAIN_GROUP = "main";

        [JsonProperty("type")]
        public QScreenerParameterType Type { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("group", Required = Required.Default)]
        public string Group { get; set; }
    }

    public class QScreenerParameter<T> : QScreenerParameter
    {
        [JsonProperty("defaultValue")]
        public T DefaultValue { get; set; }
    }
}
