using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace MarketsIQ.Services.QuantowerServer.Protocol.Shared.Models
{
    public sealed class TradeQuoteMessage : IMessage<TradeQuoteMessage>, IMessage, IEquatable<TradeQuoteMessage>, IDeepCloneable<TradeQuoteMessage>
    {
        private static readonly MessageParser<TradeQuoteMessage> _parser = new MessageParser<TradeQuoteMessage>(() => new TradeQuoteMessage());

        private UnknownFieldSet _unknownFields;

        public const int PriceFieldNumber = 1;

        private double price_;

        public const int SizeFieldNumber = 2;

        private double size_;

        public const int OpenInterestFieldNumber = 3;

        private double openInterest_;

        public const int AggressorFlagFieldNumber = 4;

        private AggressorFlag aggressorFlag_;

        [DebuggerNonUserCode]
        public static MessageParser<TradeQuoteMessage> Parser => _parser;

        [DebuggerNonUserCode]
        public static MessageDescriptor Descriptor => TradeQuoteMessageReflection.Descriptor.MessageTypes[0];

        [DebuggerNonUserCode]
        MessageDescriptor IMessage.Descriptor => Descriptor;

        [DebuggerNonUserCode]
        public double Price
        {
            get
            {
                return price_;
            }
            set
            {
                price_ = value;
            }
        }

        [DebuggerNonUserCode]
        public double Size
        {
            get
            {
                return size_;
            }
            set
            {
                size_ = value;
            }
        }

        [DebuggerNonUserCode]
        public double OpenInterest
        {
            get
            {
                return openInterest_;
            }
            set
            {
                openInterest_ = value;
            }
        }

        [DebuggerNonUserCode]
        public AggressorFlag AggressorFlag
        {
            get
            {
                return aggressorFlag_;
            }
            set
            {
                aggressorFlag_ = value;
            }
        }

        [DebuggerNonUserCode]
        public TradeQuoteMessage()
        {
        }

        [DebuggerNonUserCode]
        public TradeQuoteMessage(TradeQuoteMessage other)
            : this()
        {
            price_ = other.price_;
            size_ = other.size_;
            openInterest_ = other.openInterest_;
            aggressorFlag_ = other.aggressorFlag_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        [DebuggerNonUserCode]
        public TradeQuoteMessage Clone()
        {
            return new TradeQuoteMessage(this);
        }

        [DebuggerNonUserCode]
        public override bool Equals(object other)
        {
            return Equals(other as TradeQuoteMessage);
        }

        [DebuggerNonUserCode]
        public bool Equals(TradeQuoteMessage other)
        {
            if (other == null)
            {
                return false;
            }

            if (other == this)
            {
                return true;
            }

            if (!ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(Price, other.Price))
            {
                return false;
            }

            if (!ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(Size, other.Size))
            {
                return false;
            }

            if (!ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(OpenInterest, other.OpenInterest))
            {
                return false;
            }

            if (AggressorFlag != other.AggressorFlag)
            {
                return false;
            }

            return object.Equals(_unknownFields, other._unknownFields);
        }

        [DebuggerNonUserCode]
        public override int GetHashCode()
        {
            int num = 1;
            if (Price != 0.0)
            {
                num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(Price);
            }

            if (Size != 0.0)
            {
                num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(Size);
            }

            if (OpenInterest != 0.0)
            {
                num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(OpenInterest);
            }

            if (AggressorFlag != 0)
            {
                num ^= AggressorFlag.GetHashCode();
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
            if (Price != 0.0)
            {
                output.WriteRawTag(9);
                output.WriteDouble(Price);
            }

            if (Size != 0.0)
            {
                output.WriteRawTag(17);
                output.WriteDouble(Size);
            }

            if (OpenInterest != 0.0)
            {
                output.WriteRawTag(25);
                output.WriteDouble(OpenInterest);
            }

            if (AggressorFlag != 0)
            {
                output.WriteRawTag(32);
                output.WriteEnum((int)AggressorFlag);
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
            if (Price != 0.0)
            {
                num += 9;
            }

            if (Size != 0.0)
            {
                num += 9;
            }

            if (OpenInterest != 0.0)
            {
                num += 9;
            }

            if (AggressorFlag != 0)
            {
                num += 1 + CodedOutputStream.ComputeEnumSize((int)AggressorFlag);
            }

            if (_unknownFields != null)
            {
                num += _unknownFields.CalculateSize();
            }

            return num;
        }

        [DebuggerNonUserCode]
        public void MergeFrom(TradeQuoteMessage other)
        {
            if (other != null)
            {
                if (other.Price != 0.0)
                {
                    Price = other.Price;
                }

                if (other.Size != 0.0)
                {
                    Size = other.Size;
                }

                if (other.OpenInterest != 0.0)
                {
                    OpenInterest = other.OpenInterest;
                }

                if (other.AggressorFlag != 0)
                {
                    AggressorFlag = other.AggressorFlag;
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
                        Price = input.ReadDouble();
                        break;
                    case 17u:
                        Size = input.ReadDouble();
                        break;
                    case 25u:
                        OpenInterest = input.ReadDouble();
                        break;
                    case 32u:
                        aggressorFlag_ = (AggressorFlag)input.ReadEnum();
                        break;
                }
            }
        }
    }
}
