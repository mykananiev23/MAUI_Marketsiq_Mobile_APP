using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace MarketsIQ.Services.QuantowerServer.Protocol.Shared.Models
{
    public sealed class CustomDataMessage : IMessage<CustomDataMessage>, IMessage, IEquatable<CustomDataMessage>, IDeepCloneable<CustomDataMessage>
    {
        public enum ValueOneofCase
        {
            None = 0,
            BooleanValue = 3,
            IntegerValue = 4,
            LongValue = 5,
            DoubleValue = 6,
            StringValue = 7
        }

        private static readonly MessageParser<CustomDataMessage> _parser = new MessageParser<CustomDataMessage>(() => new CustomDataMessage());

        private UnknownFieldSet _unknownFields;

        public const int TypeFieldNumber = 1;

        private CustomDataType type_;

        public const int BooleanValueFieldNumber = 3;

        public const int IntegerValueFieldNumber = 4;

        public const int LongValueFieldNumber = 5;

        public const int DoubleValueFieldNumber = 6;

        public const int StringValueFieldNumber = 7;

        private object value_;

        private ValueOneofCase valueCase_;

        [DebuggerNonUserCode]
        public static MessageParser<CustomDataMessage> Parser => _parser;

        [DebuggerNonUserCode]
        public static MessageDescriptor Descriptor => CustomDataMessageReflection.Descriptor.MessageTypes[0];

        [DebuggerNonUserCode]
        MessageDescriptor IMessage.Descriptor => Descriptor;

        [DebuggerNonUserCode]
        public CustomDataType Type
        {
            get
            {
                return type_;
            }
            set
            {
                type_ = value;
            }
        }

        [DebuggerNonUserCode]
        public bool BooleanValue
        {
            get
            {
                if (valueCase_ != ValueOneofCase.BooleanValue)
                {
                    return false;
                }

                return (bool)value_;
            }
            set
            {
                value_ = value;
                valueCase_ = ValueOneofCase.BooleanValue;
            }
        }

        [DebuggerNonUserCode]
        public int IntegerValue
        {
            get
            {
                if (valueCase_ != ValueOneofCase.IntegerValue)
                {
                    return 0;
                }

                return (int)value_;
            }
            set
            {
                value_ = value;
                valueCase_ = ValueOneofCase.IntegerValue;
            }
        }

        [DebuggerNonUserCode]
        public long LongValue
        {
            get
            {
                if (valueCase_ != ValueOneofCase.LongValue)
                {
                    return 0L;
                }

                return (long)value_;
            }
            set
            {
                value_ = value;
                valueCase_ = ValueOneofCase.LongValue;
            }
        }

        [DebuggerNonUserCode]
        public double DoubleValue
        {
            get
            {
                if (valueCase_ != ValueOneofCase.DoubleValue)
                {
                    return 0.0;
                }

                return (double)value_;
            }
            set
            {
                value_ = value;
                valueCase_ = ValueOneofCase.DoubleValue;
            }
        }

        [DebuggerNonUserCode]
        public string StringValue
        {
            get
            {
                if (valueCase_ != ValueOneofCase.StringValue)
                {
                    return "";
                }

                return (string)value_;
            }
            set
            {
                value_ = ProtoPreconditions.CheckNotNull(value, "value");
                valueCase_ = ValueOneofCase.StringValue;
            }
        }

        [DebuggerNonUserCode]
        public ValueOneofCase ValueCase => valueCase_;

        [DebuggerNonUserCode]
        public CustomDataMessage()
        {
        }

        [DebuggerNonUserCode]
        public CustomDataMessage(CustomDataMessage other)
            : this()
        {
            type_ = other.type_;
            switch (other.ValueCase)
            {
                case ValueOneofCase.BooleanValue:
                    BooleanValue = other.BooleanValue;
                    break;
                case ValueOneofCase.IntegerValue:
                    IntegerValue = other.IntegerValue;
                    break;
                case ValueOneofCase.LongValue:
                    LongValue = other.LongValue;
                    break;
                case ValueOneofCase.DoubleValue:
                    DoubleValue = other.DoubleValue;
                    break;
                case ValueOneofCase.StringValue:
                    StringValue = other.StringValue;
                    break;
            }

            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        [DebuggerNonUserCode]
        public CustomDataMessage Clone()
        {
            return new CustomDataMessage(this);
        }

        [DebuggerNonUserCode]
        public void ClearValue()
        {
            valueCase_ = ValueOneofCase.None;
            value_ = null;
        }

        [DebuggerNonUserCode]
        public override bool Equals(object other)
        {
            return Equals(other as CustomDataMessage);
        }

        [DebuggerNonUserCode]
        public bool Equals(CustomDataMessage other)
        {
            if (other == null)
            {
                return false;
            }

            if (other == this)
            {
                return true;
            }

            if (Type != other.Type)
            {
                return false;
            }

            if (BooleanValue != other.BooleanValue)
            {
                return false;
            }

            if (IntegerValue != other.IntegerValue)
            {
                return false;
            }

            if (LongValue != other.LongValue)
            {
                return false;
            }

            if (!ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(DoubleValue, other.DoubleValue))
            {
                return false;
            }

            if (StringValue != other.StringValue)
            {
                return false;
            }

            if (ValueCase != other.ValueCase)
            {
                return false;
            }

            return object.Equals(_unknownFields, other._unknownFields);
        }

        [DebuggerNonUserCode]
        public override int GetHashCode()
        {
            int num = 1;
            if (Type != 0)
            {
                num ^= Type.GetHashCode();
            }

            if (valueCase_ == ValueOneofCase.BooleanValue)
            {
                num ^= BooleanValue.GetHashCode();
            }

            if (valueCase_ == ValueOneofCase.IntegerValue)
            {
                num ^= IntegerValue.GetHashCode();
            }

            if (valueCase_ == ValueOneofCase.LongValue)
            {
                num ^= LongValue.GetHashCode();
            }

            if (valueCase_ == ValueOneofCase.DoubleValue)
            {
                num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(DoubleValue);
            }

            if (valueCase_ == ValueOneofCase.StringValue)
            {
                num ^= StringValue.GetHashCode();
            }

            num ^= (int)valueCase_;
            if (_unknownFields != null)
            {
                num ^= _unknownFields.GetHashCode();
            }

            return num;
        }

        [DebuggerNonUserCode]
        public override string ToString()
        {
            return JsonFormatter.ToDiagnosticString(this);
        }

        [DebuggerNonUserCode]
        public void WriteTo(CodedOutputStream output)
        {
            if (Type != 0)
            {
                output.WriteRawTag(8);
                output.WriteEnum((int)Type);
            }

            if (valueCase_ == ValueOneofCase.BooleanValue)
            {
                output.WriteRawTag(24);
                output.WriteBool(BooleanValue);
            }

            if (valueCase_ == ValueOneofCase.IntegerValue)
            {
                output.WriteRawTag(32);
                output.WriteInt32(IntegerValue);
            }

            if (valueCase_ == ValueOneofCase.LongValue)
            {
                output.WriteRawTag(40);
                output.WriteInt64(LongValue);
            }

            if (valueCase_ == ValueOneofCase.DoubleValue)
            {
                output.WriteRawTag(49);
                output.WriteDouble(DoubleValue);
            }

            if (valueCase_ == ValueOneofCase.StringValue)
            {
                output.WriteRawTag(58);
                output.WriteString(StringValue);
            }

            if (_unknownFields != null)
            {
                _unknownFields.WriteTo(output);
            }
        }

        [DebuggerNonUserCode]
        public int CalculateSize()
        {
            int num = 0;
            if (Type != 0)
            {
                num += 1 + CodedOutputStream.ComputeEnumSize((int)Type);
            }

            if (valueCase_ == ValueOneofCase.BooleanValue)
            {
                num += 2;
            }

            if (valueCase_ == ValueOneofCase.IntegerValue)
            {
                num += 1 + CodedOutputStream.ComputeInt32Size(IntegerValue);
            }

            if (valueCase_ == ValueOneofCase.LongValue)
            {
                num += 1 + CodedOutputStream.ComputeInt64Size(LongValue);
            }

            if (valueCase_ == ValueOneofCase.DoubleValue)
            {
                num += 9;
            }

            if (valueCase_ == ValueOneofCase.StringValue)
            {
                num += 1 + CodedOutputStream.ComputeStringSize(StringValue);
            }

            if (_unknownFields != null)
            {
                num += _unknownFields.CalculateSize();
            }

            return num;
        }

        [DebuggerNonUserCode]
        public void MergeFrom(CustomDataMessage other)
        {
            if (other != null)
            {
                if (other.Type != 0)
                {
                    Type = other.Type;
                }

                switch (other.ValueCase)
                {
                    case ValueOneofCase.BooleanValue:
                        BooleanValue = other.BooleanValue;
                        break;
                    case ValueOneofCase.IntegerValue:
                        IntegerValue = other.IntegerValue;
                        break;
                    case ValueOneofCase.LongValue:
                        LongValue = other.LongValue;
                        break;
                    case ValueOneofCase.DoubleValue:
                        DoubleValue = other.DoubleValue;
                        break;
                    case ValueOneofCase.StringValue:
                        StringValue = other.StringValue;
                        break;
                }

                _unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
            }
        }

        [DebuggerNonUserCode]
        public void MergeFrom(CodedInputStream input)
        {
            uint num;
            while ((num = input.ReadTag()) != 0)
            {
                switch (num)
                {
                    default:
                        _unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
                        break;
                    case 8u:
                        type_ = (CustomDataType)input.ReadEnum();
                        break;
                    case 24u:
                        BooleanValue = input.ReadBool();
                        break;
                    case 32u:
                        IntegerValue = input.ReadInt32();
                        break;
                    case 40u:
                        LongValue = input.ReadInt64();
                        break;
                    case 49u:
                        DoubleValue = input.ReadDouble();
                        break;
                    case 58u:
                        StringValue = input.ReadString();
                        break;
                }
            }
        }
    }
}
