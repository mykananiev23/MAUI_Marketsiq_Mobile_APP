using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace MarketsIQ.Services.QuantowerServer.Protocol.Shared.Models
{
    public sealed class Level1QuoteMessage : IMessage<Level1QuoteMessage>, IMessage, IEquatable<Level1QuoteMessage>, IDeepCloneable<Level1QuoteMessage>
    {
        private static readonly MessageParser<Level1QuoteMessage> _parser = new MessageParser<Level1QuoteMessage>(() => new Level1QuoteMessage());

        private UnknownFieldSet _unknownFields;

        public const int BidPriceFieldNumber = 1;

        private double bidPrice_;

        public const int BidSizeFieldNumber = 2;

        private double bidSize_;

        public const int AskPriceFieldNumber = 3;

        private double askPrice_;

        public const int AskSizeFieldNumber = 4;

        private double askSize_;

        [DebuggerNonUserCode]
        public static MessageParser<Level1QuoteMessage> Parser => _parser;

        [DebuggerNonUserCode]
        public static MessageDescriptor Descriptor => Level1QuoteMessageReflection.Descriptor.MessageTypes[0];

        [DebuggerNonUserCode]
        MessageDescriptor IMessage.Descriptor => Descriptor;

        [DebuggerNonUserCode]
        public double BidPrice
        {
            get
            {
                return bidPrice_;
            }
            set
            {
                bidPrice_ = value;
            }
        }

        [DebuggerNonUserCode]
        public double BidSize
        {
            get
            {
                return bidSize_;
            }
            set
            {
                bidSize_ = value;
            }
        }

        [DebuggerNonUserCode]
        public double AskPrice
        {
            get
            {
                return askPrice_;
            }
            set
            {
                askPrice_ = value;
            }
        }

        [DebuggerNonUserCode]
        public double AskSize
        {
            get
            {
                return askSize_;
            }
            set
            {
                askSize_ = value;
            }
        }

        [DebuggerNonUserCode]
        public Level1QuoteMessage()
        {
        }

        [DebuggerNonUserCode]
        public Level1QuoteMessage(Level1QuoteMessage other)
            : this()
        {
            bidPrice_ = other.bidPrice_;
            bidSize_ = other.bidSize_;
            askPrice_ = other.askPrice_;
            askSize_ = other.askSize_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        [DebuggerNonUserCode]
        public Level1QuoteMessage Clone()
        {
            return new Level1QuoteMessage(this);
        }

        [DebuggerNonUserCode]
        public override bool Equals(object other)
        {
            return Equals(other as Level1QuoteMessage);
        }

        [DebuggerNonUserCode]
        public bool Equals(Level1QuoteMessage other)
        {
            if (other == null)
            {
                return false;
            }

            if (other == this)
            {
                return true;
            }

            if (!ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(BidPrice, other.BidPrice))
            {
                return false;
            }

            if (!ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(BidSize, other.BidSize))
            {
                return false;
            }

            if (!ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(AskPrice, other.AskPrice))
            {
                return false;
            }

            if (!ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(AskSize, other.AskSize))
            {
                return false;
            }

            return object.Equals(_unknownFields, other._unknownFields);
        }

        [DebuggerNonUserCode]
        public override int GetHashCode()
        {
            int num = 1;
            if (BidPrice != 0.0)
            {
                num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(BidPrice);
            }

            if (BidSize != 0.0)
            {
                num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(BidSize);
            }

            if (AskPrice != 0.0)
            {
                num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(AskPrice);
            }

            if (AskSize != 0.0)
            {
                num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(AskSize);
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
            if (BidPrice != 0.0)
            {
                output.WriteRawTag(9);
                output.WriteDouble(BidPrice);
            }

            if (BidSize != 0.0)
            {
                output.WriteRawTag(17);
                output.WriteDouble(BidSize);
            }

            if (AskPrice != 0.0)
            {
                output.WriteRawTag(25);
                output.WriteDouble(AskPrice);
            }

            if (AskSize != 0.0)
            {
                output.WriteRawTag(33);
                output.WriteDouble(AskSize);
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
            if (BidPrice != 0.0)
            {
                num += 9;
            }

            if (BidSize != 0.0)
            {
                num += 9;
            }

            if (AskPrice != 0.0)
            {
                num += 9;
            }

            if (AskSize != 0.0)
            {
                num += 9;
            }

            if (_unknownFields != null)
            {
                num += _unknownFields.CalculateSize();
            }

            return num;
        }

        [DebuggerNonUserCode]
        public void MergeFrom(Level1QuoteMessage other)
        {
            if (other != null)
            {
                if (other.BidPrice != 0.0)
                {
                    BidPrice = other.BidPrice;
                }

                if (other.BidSize != 0.0)
                {
                    BidSize = other.BidSize;
                }

                if (other.AskPrice != 0.0)
                {
                    AskPrice = other.AskPrice;
                }

                if (other.AskSize != 0.0)
                {
                    AskSize = other.AskSize;
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
                    case 9u:
                        BidPrice = input.ReadDouble();
                        break;
                    case 17u:
                        BidSize = input.ReadDouble();
                        break;
                    case 25u:
                        AskPrice = input.ReadDouble();
                        break;
                    case 33u:
                        AskSize = input.ReadDouble();
                        break;
                }
            }
        }
    }
}
