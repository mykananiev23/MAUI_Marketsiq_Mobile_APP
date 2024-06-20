using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace MarketsIQ.Services.QuantowerServer.Protocol.Shared.Models
{
    public sealed class MarketQuoteMessage : IMessage<MarketQuoteMessage>, IMessage, IEquatable<MarketQuoteMessage>, IDeepCloneable<MarketQuoteMessage>
    {
        public enum QuoteOneofCase
        {
            None = 0,
            Level1 = 10,
            Level2 = 11,
            Dom = 12,
            Trade = 13,
            DayBar = 14
        }

        private static readonly MessageParser<MarketQuoteMessage> _parser = new MessageParser<MarketQuoteMessage>(() => new MarketQuoteMessage());

        private UnknownFieldSet _unknownFields;

        public const int TypeFieldNumber = 1;

        private MarketQuoteType type_;

        public const int InstrumentIdFieldNumber = 2;

        private int instrumentId_;

        public const int TimeFieldNumber = 3;

        private long time_;

        public const int Level1FieldNumber = 10;

        public const int Level2FieldNumber = 11;

        public const int DomFieldNumber = 12;

        public const int TradeFieldNumber = 13;

        public const int DayBarFieldNumber = 14;

        private object quote_;

        private QuoteOneofCase quoteCase_;

        [DebuggerNonUserCode]
        public static MessageParser<MarketQuoteMessage> Parser => _parser;

        [DebuggerNonUserCode]
        public static MessageDescriptor Descriptor => MarketQuoteMessageReflection.Descriptor.MessageTypes[0];

        [DebuggerNonUserCode]
        MessageDescriptor IMessage.Descriptor => Descriptor;

        [DebuggerNonUserCode]
        public MarketQuoteType Type
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
        public long Time
        {
            get
            {
                return time_;
            }
            set
            {
                time_ = value;
            }
        }

        [DebuggerNonUserCode]
        public Level1QuoteMessage Level1
        {
            get
            {
                if (quoteCase_ != QuoteOneofCase.Level1)
                {
                    return null;
                }

                return (Level1QuoteMessage)quote_;
            }
            set
            {
                quote_ = value;
                quoteCase_ = ((value != null) ? QuoteOneofCase.Level1 : QuoteOneofCase.None);
            }
        }

        [DebuggerNonUserCode]
        public Level2QuoteMessage Level2
        {
            get
            {
                if (quoteCase_ != QuoteOneofCase.Level2)
                {
                    return null;
                }

                return (Level2QuoteMessage)quote_;
            }
            set
            {
                quote_ = value;
                quoteCase_ = ((value != null) ? QuoteOneofCase.Level2 : QuoteOneofCase.None);
            }
        }

        [DebuggerNonUserCode]
        public DomQuoteMessage Dom
        {
            get
            {
                if (quoteCase_ != QuoteOneofCase.Dom)
                {
                    return null;
                }

                return (DomQuoteMessage)quote_;
            }
            set
            {
                quote_ = value;
                quoteCase_ = ((value != null) ? QuoteOneofCase.Dom : QuoteOneofCase.None);
            }
        }

        [DebuggerNonUserCode]
        public TradeQuoteMessage Trade
        {
            get
            {
                if (quoteCase_ != QuoteOneofCase.Trade)
                {
                    return null;
                }

                return (TradeQuoteMessage)quote_;
            }
            set
            {
                quote_ = value;
                quoteCase_ = ((value != null) ? QuoteOneofCase.Trade : QuoteOneofCase.None);
            }
        }

        [DebuggerNonUserCode]
        public DayBarQuoteMessage DayBar
        {
            get
            {
                if (quoteCase_ != QuoteOneofCase.DayBar)
                {
                    return null;
                }

                return (DayBarQuoteMessage)quote_;
            }
            set
            {
                quote_ = value;
                quoteCase_ = ((value != null) ? QuoteOneofCase.DayBar : QuoteOneofCase.None);
            }
        }

        [DebuggerNonUserCode]
        public QuoteOneofCase QuoteCase => quoteCase_;

        [DebuggerNonUserCode]
        public MarketQuoteMessage()
        {
        }

        [DebuggerNonUserCode]
        public MarketQuoteMessage(MarketQuoteMessage other)
            : this()
        {
            type_ = other.type_;
            instrumentId_ = other.instrumentId_;
            time_ = other.time_;
            switch (other.QuoteCase)
            {
                case QuoteOneofCase.Level1:
                    Level1 = other.Level1.Clone();
                    break;
                case QuoteOneofCase.Level2:
                    Level2 = other.Level2.Clone();
                    break;
                case QuoteOneofCase.Dom:
                    Dom = other.Dom.Clone();
                    break;
                case QuoteOneofCase.Trade:
                    Trade = other.Trade.Clone();
                    break;
                case QuoteOneofCase.DayBar:
                    DayBar = other.DayBar.Clone();
                    break;
            }

            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        [DebuggerNonUserCode]
        public MarketQuoteMessage Clone()
        {
            return new MarketQuoteMessage(this);
        }

        [DebuggerNonUserCode]
        public void ClearQuote()
        {
            quoteCase_ = QuoteOneofCase.None;
            quote_ = null;
        }

        [DebuggerNonUserCode]
        public override bool Equals(object other)
        {
            return Equals(other as MarketQuoteMessage);
        }

        [DebuggerNonUserCode]
        public bool Equals(MarketQuoteMessage other)
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

            if (InstrumentId != other.InstrumentId)
            {
                return false;
            }

            if (Time != other.Time)
            {
                return false;
            }

            if (!object.Equals(Level1, other.Level1))
            {
                return false;
            }

            if (!object.Equals(Level2, other.Level2))
            {
                return false;
            }

            if (!object.Equals(Dom, other.Dom))
            {
                return false;
            }

            if (!object.Equals(Trade, other.Trade))
            {
                return false;
            }

            if (!object.Equals(DayBar, other.DayBar))
            {
                return false;
            }

            if (QuoteCase != other.QuoteCase)
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

            if (InstrumentId != 0)
            {
                num ^= InstrumentId.GetHashCode();
            }

            if (Time != 0L)
            {
                num ^= Time.GetHashCode();
            }

            if (quoteCase_ == QuoteOneofCase.Level1)
            {
                num ^= Level1.GetHashCode();
            }

            if (quoteCase_ == QuoteOneofCase.Level2)
            {
                num ^= Level2.GetHashCode();
            }

            if (quoteCase_ == QuoteOneofCase.Dom)
            {
                num ^= Dom.GetHashCode();
            }

            if (quoteCase_ == QuoteOneofCase.Trade)
            {
                num ^= Trade.GetHashCode();
            }

            if (quoteCase_ == QuoteOneofCase.DayBar)
            {
                num ^= DayBar.GetHashCode();
            }

            num ^= (int)quoteCase_;
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

            if (InstrumentId != 0)
            {
                output.WriteRawTag(16);
                output.WriteInt32(InstrumentId);
            }

            if (Time != 0L)
            {
                output.WriteRawTag(24);
                output.WriteInt64(Time);
            }

            if (quoteCase_ == QuoteOneofCase.Level1)
            {
                output.WriteRawTag(82);
                output.WriteMessage(Level1);
            }

            if (quoteCase_ == QuoteOneofCase.Level2)
            {
                output.WriteRawTag(90);
                output.WriteMessage(Level2);
            }

            if (quoteCase_ == QuoteOneofCase.Dom)
            {
                output.WriteRawTag(98);
                output.WriteMessage(Dom);
            }

            if (quoteCase_ == QuoteOneofCase.Trade)
            {
                output.WriteRawTag(106);
                output.WriteMessage(Trade);
            }

            if (quoteCase_ == QuoteOneofCase.DayBar)
            {
                output.WriteRawTag(114);
                output.WriteMessage(DayBar);
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

            if (InstrumentId != 0)
            {
                num += 1 + CodedOutputStream.ComputeInt32Size(InstrumentId);
            }

            if (Time != 0L)
            {
                num += 1 + CodedOutputStream.ComputeInt64Size(Time);
            }

            if (quoteCase_ == QuoteOneofCase.Level1)
            {
                num += 1 + CodedOutputStream.ComputeMessageSize(Level1);
            }

            if (quoteCase_ == QuoteOneofCase.Level2)
            {
                num += 1 + CodedOutputStream.ComputeMessageSize(Level2);
            }

            if (quoteCase_ == QuoteOneofCase.Dom)
            {
                num += 1 + CodedOutputStream.ComputeMessageSize(Dom);
            }

            if (quoteCase_ == QuoteOneofCase.Trade)
            {
                num += 1 + CodedOutputStream.ComputeMessageSize(Trade);
            }

            if (quoteCase_ == QuoteOneofCase.DayBar)
            {
                num += 1 + CodedOutputStream.ComputeMessageSize(DayBar);
            }

            if (_unknownFields != null)
            {
                num += _unknownFields.CalculateSize();
            }

            return num;
        }

        [DebuggerNonUserCode]
        public void MergeFrom(MarketQuoteMessage other)
        {
            if (other == null)
            {
                return;
            }

            if (other.Type != 0)
            {
                Type = other.Type;
            }

            if (other.InstrumentId != 0)
            {
                InstrumentId = other.InstrumentId;
            }

            if (other.Time != 0L)
            {
                Time = other.Time;
            }

            switch (other.QuoteCase)
            {
                case QuoteOneofCase.Level1:
                    if (Level1 == null)
                    {
                        Level1 = new Level1QuoteMessage();
                    }

                    Level1.MergeFrom(other.Level1);
                    break;
                case QuoteOneofCase.Level2:
                    if (Level2 == null)
                    {
                        Level2 = new Level2QuoteMessage();
                    }

                    Level2.MergeFrom(other.Level2);
                    break;
                case QuoteOneofCase.Dom:
                    if (Dom == null)
                    {
                        Dom = new DomQuoteMessage();
                    }

                    Dom.MergeFrom(other.Dom);
                    break;
                case QuoteOneofCase.Trade:
                    if (Trade == null)
                    {
                        Trade = new TradeQuoteMessage();
                    }

                    Trade.MergeFrom(other.Trade);
                    break;
                case QuoteOneofCase.DayBar:
                    if (DayBar == null)
                    {
                        DayBar = new DayBarQuoteMessage();
                    }

                    DayBar.MergeFrom(other.DayBar);
                    break;
            }

            _unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
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
                        type_ = (MarketQuoteType)input.ReadEnum();
                        break;
                    case 16u:
                        InstrumentId = input.ReadInt32();
                        break;
                    case 24u:
                        Time = input.ReadInt64();
                        break;
                    case 82u:
                        {
                            Level1QuoteMessage level1QuoteMessage = new Level1QuoteMessage();
                            if (quoteCase_ == QuoteOneofCase.Level1)
                            {
                                level1QuoteMessage.MergeFrom(Level1);
                            }

                            input.ReadMessage(level1QuoteMessage);
                            Level1 = level1QuoteMessage;
                            break;
                        }
                    case 90u:
                        {
                            Level2QuoteMessage level2QuoteMessage = new Level2QuoteMessage();
                            if (quoteCase_ == QuoteOneofCase.Level2)
                            {
                                level2QuoteMessage.MergeFrom(Level2);
                            }

                            input.ReadMessage(level2QuoteMessage);
                            Level2 = level2QuoteMessage;
                            break;
                        }
                    case 98u:
                        {
                            DomQuoteMessage domQuoteMessage = new DomQuoteMessage();
                            if (quoteCase_ == QuoteOneofCase.Dom)
                            {
                                domQuoteMessage.MergeFrom(Dom);
                            }

                            input.ReadMessage(domQuoteMessage);
                            Dom = domQuoteMessage;
                            break;
                        }
                    case 106u:
                        {
                            TradeQuoteMessage tradeQuoteMessage = new TradeQuoteMessage();
                            if (quoteCase_ == QuoteOneofCase.Trade)
                            {
                                tradeQuoteMessage.MergeFrom(Trade);
                            }

                            input.ReadMessage(tradeQuoteMessage);
                            Trade = tradeQuoteMessage;
                            break;
                        }
                    case 114u:
                        {
                            DayBarQuoteMessage dayBarQuoteMessage = new DayBarQuoteMessage();
                            if (quoteCase_ == QuoteOneofCase.DayBar)
                            {
                                dayBarQuoteMessage.MergeFrom(DayBar);
                            }

                            input.ReadMessage(dayBarQuoteMessage);
                            DayBar = dayBarQuoteMessage;
                            break;
                        }
                }
            }
        }
    }
}
