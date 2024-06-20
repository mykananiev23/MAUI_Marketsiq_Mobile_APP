using Google.Protobuf;
using Google.Protobuf.Collections;
using MarketsIQ.Services.QuantowerServer.Protocol.Shared.Models;

namespace MarketsIQ.Services.QuantowerServer.Protocol.Shared
{
    public static class ProtocolHelper
    {
        public static byte[] SerializeMessage(IMessage message)
        {
            using MemoryStream memoryStream = new MemoryStream();
            message.WriteTo(memoryStream);
            return memoryStream.ToArray();
        }

        public static object GetValue(this CustomDataMessage data)
        {
            object result = null;
            switch (data.ValueCase)
            {
                case CustomDataMessage.ValueOneofCase.BooleanValue:
                    result = data.BooleanValue;
                    break;
                case CustomDataMessage.ValueOneofCase.IntegerValue:
                    result = data.IntegerValue;
                    break;
                case CustomDataMessage.ValueOneofCase.LongValue:
                    result = data.LongValue;
                    break;
                case CustomDataMessage.ValueOneofCase.DoubleValue:
                    result = data.DoubleValue;
                    break;
                case CustomDataMessage.ValueOneofCase.StringValue:
                    result = data.StringValue;
                    break;
            }

            return result;
        }

        public static void Add<TIndex, TValue>(this MapField<TIndex, CustomDataMessage> messageMap, TIndex index, TValue value)
        {
            object obj = value;
            if (typeof(TValue) == typeof(int))
            {
                messageMap.Add(index, new CustomDataMessage
                {
                    Type = CustomDataType.Integer,
                    IntegerValue = (int)obj
                });
                return;
            }

            if (typeof(TValue) == typeof(long))
            {
                messageMap.Add(index, new CustomDataMessage
                {
                    Type = CustomDataType.Long,
                    LongValue = (long)obj
                });
                return;
            }

            if (typeof(TValue) == typeof(string))
            {
                messageMap.Add(index, new CustomDataMessage
                {
                    Type = CustomDataType.String,
                    StringValue = (string)obj
                });
                return;
            }

            if (typeof(TValue) == typeof(bool))
            {
                messageMap.Add(index, new CustomDataMessage
                {
                    Type = CustomDataType.Boolean,
                    BooleanValue = (bool)obj
                });
                return;
            }

            if (typeof(TValue) == typeof(double))
            {
                messageMap.Add(index, new CustomDataMessage
                {
                    Type = CustomDataType.Double,
                    DoubleValue = (double)obj
                });
                return;
            }

            throw new Exception("Invalid value type");
        }
    }
}
