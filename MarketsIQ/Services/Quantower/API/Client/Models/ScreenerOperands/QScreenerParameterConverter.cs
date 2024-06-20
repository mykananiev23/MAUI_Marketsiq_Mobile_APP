using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace MarketsIQ.Services.Quantower.API.Client.Models.ScreenerOperands
{
    public class QScreenerParameterConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return true;
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            try
            {
                JContainer jContainer = serializer.Deserialize<JContainer>(reader);
                string text = jContainer.Value<string>("type");
                if (1 == 0)
                {
                }

                object result = text switch
                {
                    "Number" => jContainer.ToObject<QScreenerNumberParameter>(),
                    "Boolean" => jContainer.ToObject<QScreenerParameter<bool>>(),
                    "Selector" => jContainer.ToObject<QScreenerSelectorParameter>(),
                    "Period" => jContainer.ToObject<QScreenerParameter<string>>(),
                    _ => jContainer.ToObject<QScreenerParameter<string>>(),
                };
                if (1 == 0)
                {
                }

                return result;
            }
            catch
            {
            }

            return null;
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
        }
    }
}
