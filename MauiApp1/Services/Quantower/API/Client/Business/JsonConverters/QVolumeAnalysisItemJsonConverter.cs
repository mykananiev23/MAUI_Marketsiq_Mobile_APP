using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketsIQ.Services.Quantower.API.Client.Business.JsonConverters
{
    public class QVolumeAnalysisItemJsonConverter : JsonConverter<QVolumeAnalysisItem>
    {
        public override bool CanWrite => false;

        public override void WriteJson(JsonWriter writer, QVolumeAnalysisItem value, JsonSerializer serializer)
        {
        }

        public override QVolumeAnalysisItem ReadJson(JsonReader reader, Type objectType, QVolumeAnalysisItem existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            JArray jArray = serializer.Deserialize<JArray>(reader);
            if (existingValue == null)
            {
                existingValue = new QVolumeAnalysisItem();
            }

            existingValue.Volume = jArray[0].Value<double>();
            existingValue.BuyVolume = jArray[1].Value<double>();
            existingValue.SellVolume = jArray[2].Value<double>();
            existingValue.MaxOneTradeVolume = jArray[3].Value<double>();
            existingValue.Trades = jArray[4].Value<int>();
            existingValue.BuyTrades = jArray[5].Value<int>();
            existingValue.SellTrades = jArray[6].Value<int>();
            return existingValue;
        }
    }
}
