using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace MarketsIQ.Services.Quantower.API.Client.Models.ScreenerOperands
{
    internal class QScreenerExpressionConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return true;
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            return null;
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            if (!(value is QScreenerExpression qScreenerExpression))
            {
                return;
            }

            JObject jObject = new JObject();
            if (qScreenerExpression.LeftOperand.WithFixedValue && qScreenerExpression.LeftOperand.Parameters.ContainsKey("Value"))
            {
                jObject.Add("leftValueOperand", JToken.FromObject(qScreenerExpression.LeftOperand.Parameters["Value"]));
            }
            else
            {
                jObject.Add("leftOperand", JToken.FromObject(qScreenerExpression.LeftOperand));
            }

            if (qScreenerExpression.Operator.HasValue)
            {
                if (qScreenerExpression.RightOperand.WithFixedValue && qScreenerExpression.RightOperand.Parameters.ContainsKey("Value"))
                {
                    jObject.Add("rightValueOperand", JToken.FromObject(qScreenerExpression.RightOperand.Parameters["Value"]));
                }
                else
                {
                    jObject.Add("rightOperand", JToken.FromObject(qScreenerExpression.RightOperand));
                }

                jObject.Add("operator", JToken.FromObject(qScreenerExpression.Operator));
            }

            jObject.WriteTo(writer);
        }
    }
}
