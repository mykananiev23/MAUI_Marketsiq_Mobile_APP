using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace MarketsIQ.Services.QuantowerServer.Protocol.Shared.Models
{
    public sealed class DomQuoteMessage : IMessage<DomQuoteMessage>, IMessage, IEquatable<DomQuoteMessage>, IDeepCloneable<DomQuoteMessage>
    {
        private static readonly MessageParser<DomQuoteMessage> _parser = new MessageParser<DomQuoteMessage>(() => new DomQuoteMessage());

        private UnknownFieldSet _unknownFields;

        public const int BidsFieldNumber = 1;

        private static readonly FieldCodec<Level2QuoteMessage> _repeated_bids_codec = FieldCodec.ForMessage(10u, Level2QuoteMessage.Parser);

        private readonly RepeatedField<Level2QuoteMessage> bids_ = new RepeatedField<Level2QuoteMessage>();

        public const int AsksFieldNumber = 2;

        private static readonly FieldCodec<Level2QuoteMessage> _repeated_asks_codec = FieldCodec.ForMessage(18u, Level2QuoteMessage.Parser);

        private readonly RepeatedField<Level2QuoteMessage> asks_ = new RepeatedField<Level2QuoteMessage>();

        [DebuggerNonUserCode]
        public static MessageParser<DomQuoteMessage> Parser => _parser;

        [DebuggerNonUserCode]
        public static MessageDescriptor Descriptor => DomQuoteMessageReflection.Descriptor.MessageTypes[0];

        [DebuggerNonUserCode]
        MessageDescriptor IMessage.Descriptor => Descriptor;

        [DebuggerNonUserCode]
        public RepeatedField<Level2QuoteMessage> Bids => bids_;

        [DebuggerNonUserCode]
        public RepeatedField<Level2QuoteMessage> Asks => asks_;

        [DebuggerNonUserCode]
        public DomQuoteMessage()
        {
        }

        [DebuggerNonUserCode]
        public DomQuoteMessage(DomQuoteMessage other)
            : this()
        {
            bids_ = other.bids_.Clone();
            asks_ = other.asks_.Clone();
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        [DebuggerNonUserCode]
        public DomQuoteMessage Clone()
        {
            return new DomQuoteMessage(this);
        }

        [DebuggerNonUserCode]
        public override bool Equals(object other)
        {
            return Equals(other as DomQuoteMessage);
        }

        [DebuggerNonUserCode]
        public bool Equals(DomQuoteMessage other)
        {
            if (other == null)
            {
                return false;
            }

            if (other == this)
            {
                return true;
            }

            if (!bids_.Equals(other.bids_))
            {
                return false;
            }

            if (!asks_.Equals(other.asks_))
            {
                return false;
            }

            return object.Equals(_unknownFields, other._unknownFields);
        }

        [DebuggerNonUserCode]
        public override int GetHashCode()
        {
            int num = 1;
            num ^= bids_.GetHashCode();
            num ^= asks_.GetHashCode();
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
            bids_.WriteTo(output, _repeated_bids_codec);
            asks_.WriteTo(output, _repeated_asks_codec);
            if (_unknownFields != null)
            {
                _unknownFields.WriteTo(output);
            }
        }

        [DebuggerNonUserCode]
        public int CalculateSize()
        {
            int num = 0;
            num += bids_.CalculateSize(_repeated_bids_codec);
            num += asks_.CalculateSize(_repeated_asks_codec);
            if (_unknownFields != null)
            {
                num += _unknownFields.CalculateSize();
            }

            return num;
        }

        [DebuggerNonUserCode]
        public void MergeFrom(DomQuoteMessage other)
        {
            if (other != null)
            {
                bids_.Add(other.bids_);
                asks_.Add(other.asks_);
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
                    case 10u:
                        bids_.AddEntriesFrom(input, _repeated_bids_codec);
                        break;
                    case 18u:
                        asks_.AddEntriesFrom(input, _repeated_asks_codec);
                        break;
                }
            }
        }
    }
}
