using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace MarketsIQ.Services.QuantowerServer.Protocol.Shared.Models
{
    public sealed class DayBarQuoteMessage : IMessage<DayBarQuoteMessage>, IMessage, IEquatable<DayBarQuoteMessage>, IDeepCloneable<DayBarQuoteMessage>
    {
        private static readonly MessageParser<DayBarQuoteMessage> _parser = new MessageParser<DayBarQuoteMessage>(() => new DayBarQuoteMessage());

        private UnknownFieldSet _unknownFields;

        public const int BidPriceFieldNumber = 1;

        private double bidPrice_;

        public const int BidSizeFieldNumber = 2;

        private double bidSize_;

        public const int AskPriceFieldNumber = 3;

        private double askPrice_;

        public const int AskSizeFieldNumber = 4;

        private double askSize_;

        public const int TradePriceFieldNumber = 5;

        private double tradePrice_;

        public const int TradeSizeFieldNumber = 6;

        private double tradeSize_;

        public const int OpenInterestFieldNumber = 7;

        private double openInterest_;

        public const int OpenFieldNumber = 8;

        private double open_;

        public const int HighFieldNumber = 9;

        private double high_;

        public const int LowFieldNumber = 10;

        private double low_;

        public const int PrevCloseFieldNumber = 11;

        private double prevClose_;

        public const int VolumeFieldNumber = 12;

        private double volume_;

        public const int TicksFieldNumber = 13;

        private long ticks_;

        public const int TradesFieldNumber = 14;

        private long trades_;

        public const int ExpirationDateTicksFieldNumber = 100;

        private long expirationDateTicks_;

        public const int SessionStateFieldNumber = 110;

        private SessionState sessionState_;

        [DebuggerNonUserCode]
        public static MessageParser<DayBarQuoteMessage> Parser => _parser;

        [DebuggerNonUserCode]
        public static MessageDescriptor Descriptor => DaybarQuoteMessageReflection.Descriptor.MessageTypes[0];

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
        public double TradePrice
        {
            get
            {
                return tradePrice_;
            }
            set
            {
                tradePrice_ = value;
            }
        }

        [DebuggerNonUserCode]
        public double TradeSize
        {
            get
            {
                return tradeSize_;
            }
            set
            {
                tradeSize_ = value;
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
        public double Open
        {
            get
            {
                return open_;
            }
            set
            {
                open_ = value;
            }
        }

        [DebuggerNonUserCode]
        public double High
        {
            get
            {
                return high_;
            }
            set
            {
                high_ = value;
            }
        }

        [DebuggerNonUserCode]
        public double Low
        {
            get
            {
                return low_;
            }
            set
            {
                low_ = value;
            }
        }

        [DebuggerNonUserCode]
        public double PrevClose
        {
            get
            {
                return prevClose_;
            }
            set
            {
                prevClose_ = value;
            }
        }

        [DebuggerNonUserCode]
        public double Volume
        {
            get
            {
                return volume_;
            }
            set
            {
                volume_ = value;
            }
        }

        [DebuggerNonUserCode]
        public long Ticks
        {
            get
            {
                return ticks_;
            }
            set
            {
                ticks_ = value;
            }
        }

        [DebuggerNonUserCode]
        public long Trades
        {
            get
            {
                return trades_;
            }
            set
            {
                trades_ = value;
            }
        }

        [DebuggerNonUserCode]
        public long ExpirationDateTicks
        {
            get
            {
                return expirationDateTicks_;
            }
            set
            {
                expirationDateTicks_ = value;
            }
        }

        [DebuggerNonUserCode]
        public SessionState SessionState
        {
            get
            {
                return sessionState_;
            }
            set
            {
                sessionState_ = value;
            }
        }

        [DebuggerNonUserCode]
        public DayBarQuoteMessage()
        {
        }

        [DebuggerNonUserCode]
        public DayBarQuoteMessage(DayBarQuoteMessage other)
            : this()
        {
            bidPrice_ = other.bidPrice_;
            bidSize_ = other.bidSize_;
            askPrice_ = other.askPrice_;
            askSize_ = other.askSize_;
            tradePrice_ = other.tradePrice_;
            tradeSize_ = other.tradeSize_;
            openInterest_ = other.openInterest_;
            open_ = other.open_;
            high_ = other.high_;
            low_ = other.low_;
            prevClose_ = other.prevClose_;
            volume_ = other.volume_;
            ticks_ = other.ticks_;
            trades_ = other.trades_;
            expirationDateTicks_ = other.expirationDateTicks_;
            sessionState_ = other.sessionState_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        [DebuggerNonUserCode]
        public DayBarQuoteMessage Clone()
        {
            return new DayBarQuoteMessage(this);
        }

        [DebuggerNonUserCode]
        public override bool Equals(object other)
        {
            return Equals(other as DayBarQuoteMessage);
        }

        [DebuggerNonUserCode]
        public bool Equals(DayBarQuoteMessage other)
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

            if (!ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(TradePrice, other.TradePrice))
            {
                return false;
            }

            if (!ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(TradeSize, other.TradeSize))
            {
                return false;
            }

            if (!ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(OpenInterest, other.OpenInterest))
            {
                return false;
            }

            if (!ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(Open, other.Open))
            {
                return false;
            }

            if (!ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(High, other.High))
            {
                return false;
            }

            if (!ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(Low, other.Low))
            {
                return false;
            }

            if (!ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(PrevClose, other.PrevClose))
            {
                return false;
            }

            if (!ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(Volume, other.Volume))
            {
                return false;
            }

            if (Ticks != other.Ticks)
            {
                return false;
            }

            if (Trades != other.Trades)
            {
                return false;
            }

            if (ExpirationDateTicks != other.ExpirationDateTicks)
            {
                return false;
            }

            if (SessionState != other.SessionState)
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

            if (TradePrice != 0.0)
            {
                num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(TradePrice);
            }

            if (TradeSize != 0.0)
            {
                num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(TradeSize);
            }

            if (OpenInterest != 0.0)
            {
                num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(OpenInterest);
            }

            if (Open != 0.0)
            {
                num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(Open);
            }

            if (High != 0.0)
            {
                num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(High);
            }

            if (Low != 0.0)
            {
                num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(Low);
            }

            if (PrevClose != 0.0)
            {
                num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(PrevClose);
            }

            if (Volume != 0.0)
            {
                num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(Volume);
            }

            if (Ticks != 0L)
            {
                num ^= Ticks.GetHashCode();
            }

            if (Trades != 0L)
            {
                num ^= Trades.GetHashCode();
            }

            if (ExpirationDateTicks != 0L)
            {
                num ^= ExpirationDateTicks.GetHashCode();
            }

            if (SessionState != 0)
            {
                num ^= SessionState.GetHashCode();
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

            if (TradePrice != 0.0)
            {
                output.WriteRawTag(41);
                output.WriteDouble(TradePrice);
            }

            if (TradeSize != 0.0)
            {
                output.WriteRawTag(49);
                output.WriteDouble(TradeSize);
            }

            if (OpenInterest != 0.0)
            {
                output.WriteRawTag(57);
                output.WriteDouble(OpenInterest);
            }

            if (Open != 0.0)
            {
                output.WriteRawTag(65);
                output.WriteDouble(Open);
            }

            if (High != 0.0)
            {
                output.WriteRawTag(73);
                output.WriteDouble(High);
            }

            if (Low != 0.0)
            {
                output.WriteRawTag(81);
                output.WriteDouble(Low);
            }

            if (PrevClose != 0.0)
            {
                output.WriteRawTag(89);
                output.WriteDouble(PrevClose);
            }

            if (Volume != 0.0)
            {
                output.WriteRawTag(97);
                output.WriteDouble(Volume);
            }

            if (Ticks != 0L)
            {
                output.WriteRawTag(104);
                output.WriteInt64(Ticks);
            }

            if (Trades != 0L)
            {
                output.WriteRawTag(112);
                output.WriteInt64(Trades);
            }

            if (ExpirationDateTicks != 0L)
            {
                output.WriteRawTag(160, 6);
                output.WriteInt64(ExpirationDateTicks);
            }

            if (SessionState != 0)
            {
                output.WriteRawTag(240, 6);
                output.WriteEnum((int)SessionState);
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

            if (TradePrice != 0.0)
            {
                num += 9;
            }

            if (TradeSize != 0.0)
            {
                num += 9;
            }

            if (OpenInterest != 0.0)
            {
                num += 9;
            }

            if (Open != 0.0)
            {
                num += 9;
            }

            if (High != 0.0)
            {
                num += 9;
            }

            if (Low != 0.0)
            {
                num += 9;
            }

            if (PrevClose != 0.0)
            {
                num += 9;
            }

            if (Volume != 0.0)
            {
                num += 9;
            }

            if (Ticks != 0L)
            {
                num += 1 + CodedOutputStream.ComputeInt64Size(Ticks);
            }

            if (Trades != 0L)
            {
                num += 1 + CodedOutputStream.ComputeInt64Size(Trades);
            }

            if (ExpirationDateTicks != 0L)
            {
                num += 2 + CodedOutputStream.ComputeInt64Size(ExpirationDateTicks);
            }

            if (SessionState != 0)
            {
                num += 2 + CodedOutputStream.ComputeEnumSize((int)SessionState);
            }

            if (_unknownFields != null)
            {
                num += _unknownFields.CalculateSize();
            }

            return num;
        }

        [DebuggerNonUserCode]
        public void MergeFrom(DayBarQuoteMessage other)
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

                if (other.TradePrice != 0.0)
                {
                    TradePrice = other.TradePrice;
                }

                if (other.TradeSize != 0.0)
                {
                    TradeSize = other.TradeSize;
                }

                if (other.OpenInterest != 0.0)
                {
                    OpenInterest = other.OpenInterest;
                }

                if (other.Open != 0.0)
                {
                    Open = other.Open;
                }

                if (other.High != 0.0)
                {
                    High = other.High;
                }

                if (other.Low != 0.0)
                {
                    Low = other.Low;
                }

                if (other.PrevClose != 0.0)
                {
                    PrevClose = other.PrevClose;
                }

                if (other.Volume != 0.0)
                {
                    Volume = other.Volume;
                }

                if (other.Ticks != 0L)
                {
                    Ticks = other.Ticks;
                }

                if (other.Trades != 0L)
                {
                    Trades = other.Trades;
                }

                if (other.ExpirationDateTicks != 0L)
                {
                    ExpirationDateTicks = other.ExpirationDateTicks;
                }

                if (other.SessionState != 0)
                {
                    SessionState = other.SessionState;
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
                    case 41u:
                        TradePrice = input.ReadDouble();
                        break;
                    case 49u:
                        TradeSize = input.ReadDouble();
                        break;
                    case 57u:
                        OpenInterest = input.ReadDouble();
                        break;
                    case 65u:
                        Open = input.ReadDouble();
                        break;
                    case 73u:
                        High = input.ReadDouble();
                        break;
                    case 81u:
                        Low = input.ReadDouble();
                        break;
                    case 89u:
                        PrevClose = input.ReadDouble();
                        break;
                    case 97u:
                        Volume = input.ReadDouble();
                        break;
                    case 104u:
                        Ticks = input.ReadInt64();
                        break;
                    case 112u:
                        Trades = input.ReadInt64();
                        break;
                    case 800u:
                        ExpirationDateTicks = input.ReadInt64();
                        break;
                    case 880u:
                        sessionState_ = (SessionState)input.ReadEnum();
                        break;
                }
            }
        }
    }
}
