using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace MarketsIQ.Services.QuantowerServer.Protocol.Shared.Models
{
    public sealed class MarketQuoteRequestMessage : IMessage<MarketQuoteRequestMessage>, IMessage, IEquatable<MarketQuoteRequestMessage>, IDeepCloneable<MarketQuoteRequestMessage>
    {
        private static readonly MessageParser<MarketQuoteRequestMessage> _parser = new MessageParser<MarketQuoteRequestMessage>(() => new MarketQuoteRequestMessage());

        private UnknownFieldSet _unknownFields;

        public const int InstrumentIdFieldNumber = 1;

        private int instrumentId_;

        public const int MarketQuoteTypeFieldNumber = 2;

        private MarketQuoteType marketQuoteType_;

        public const int IsSubscribeFieldNumber = 3;

        private bool isSubscribe_;

        [DebuggerNonUserCode]
        public static MessageParser<MarketQuoteRequestMessage> Parser => _parser;

        [DebuggerNonUserCode]
        public static MessageDescriptor Descriptor => MarketQuoteRequestMessageReflection.Descriptor.MessageTypes[0];

        [DebuggerNonUserCode]
        MessageDescriptor IMessage.Descriptor => Descriptor;

        [DebuggerNonUserCode]
        public int InstrumentId
        {
            get
            {
                return instrumentId_;
            }
            set
            {
                instrumentId_ = value;
            }
        }

        [DebuggerNonUserCode]
        public MarketQuoteType MarketQuoteType
        {
            get
            {
                return marketQuoteType_;
            }
            set
            {
                marketQuoteType_ = value;
            }
        }

        [DebuggerNonUserCode]
        public bool IsSubscribe
        {
            get
            {
                return isSubscribe_;
            }
            set
            {
                isSubscribe_ = value;
            }
        }

        [DebuggerNonUserCode]
        public MarketQuoteRequestMessage()
        {
        }

        [DebuggerNonUserCode]
        public MarketQuoteRequestMessage(MarketQuoteRequestMessage other)
            : this()
        {
            instrumentId_ = other.instrumentId_;
            marketQuoteType_ = other.marketQuoteType_;
            isSubscribe_ = other.isSubscribe_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        [DebuggerNonUserCode]
        public MarketQuoteRequestMessage Clone()
        {
            return new MarketQuoteRequestMessage(this);
        }

        [DebuggerNonUserCode]
        public override bool Equals(object other)
        {
            return Equals(other as MarketQuoteRequestMessage);
        }

        [DebuggerNonUserCode]
        public bool Equals(MarketQuoteRequestMessage other)
        {
            if (other == null)
            {
                return false;
            }

            if (other == this)
            {
                return true;
            }

            if (InstrumentId != other.InstrumentId)
            {
                return false;
            }

            if (MarketQuoteType != other.MarketQuoteType)
            {
                return false;
            }

            if (IsSubscribe != other.IsSubscribe)
            {
                return false;
            }

            return Equals(_unknownFields, other._unknownFields);
        }

        [DebuggerNonUserCode]
        public override int GetHashCode()
        {
            int num = 1;
            if (InstrumentId != 0)
            {
                num ^= InstrumentId.GetHashCode();
            }

            if (MarketQuoteType != 0)
            {
                num ^= MarketQuoteType.GetHashCode();
            }

            if (IsSubscribe)
            {
                num ^= IsSubscribe.GetHashCode();
            }

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
            if (InstrumentId != 0)
            {
                output.WriteRawTag(8);
                output.WriteInt32(InstrumentId);
            }

            if (MarketQuoteType != 0)
            {
                output.WriteRawTag(16);
                output.WriteEnum((int)MarketQuoteType);
            }

            if (IsSubscribe)
            {
                output.WriteRawTag(24);
                output.WriteBool(IsSubscribe);
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
            if (InstrumentId != 0)
            {
                num += 1 + CodedOutputStream.ComputeInt32Size(InstrumentId);
            }

            if (MarketQuoteType != 0)
            {
                num += 1 + CodedOutputStream.ComputeEnumSize((int)MarketQuoteType);
            }

            if (IsSubscribe)
            {
                num += 2;
            }

            if (_unknownFields != null)
            {
                num += _unknownFields.CalculateSize();
            }

            return num;
        }

        [DebuggerNonUserCode]
        public void MergeFrom(MarketQuoteRequestMessage other)
        {
            if (other != null)
            {
                if (other.InstrumentId != 0)
                {
                    InstrumentId = other.InstrumentId;
                }

                if (other.MarketQuoteType != 0)
                {
                    MarketQuoteType = other.MarketQuoteType;
                }

                if (other.IsSubscribe)
                {
                    IsSubscribe = other.IsSubscribe;
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
                        InstrumentId = input.ReadInt32();
                        break;
                    case 16u:
                        marketQuoteType_ = (MarketQuoteType)input.ReadEnum();
                        break;
                    case 24u:
                        IsSubscribe = input.ReadBool();
                        break;
                }
            }
        }
    }
}
