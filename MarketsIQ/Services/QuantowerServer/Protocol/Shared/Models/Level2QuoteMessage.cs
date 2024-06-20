using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace MarketsIQ.Services.QuantowerServer.Protocol.Shared.Models
{
    public sealed class Level2QuoteMessage : IMessage<Level2QuoteMessage>, IMessage, IEquatable<Level2QuoteMessage>, IDeepCloneable<Level2QuoteMessage>
    {
        private static readonly MessageParser<Level2QuoteMessage> _parser = new MessageParser<Level2QuoteMessage>(() => new Level2QuoteMessage());

        private UnknownFieldSet _unknownFields;

        public const int MmidFieldNumber = 1;

        private string mmid_ = "";

        public const int TypeFieldNumber = 2;

        private Level2Type type_;

        public const int IsClosedFieldNumber = 3;

        private bool isClosed_;

        public const int PriceFieldNumber = 4;

        private double price_;

        public const int SizeFieldNumber = 5;

        private double size_;

        [DebuggerNonUserCode]
        public static MessageParser<Level2QuoteMessage> Parser => _parser;

        [DebuggerNonUserCode]
        public static MessageDescriptor Descriptor => Level2QuoteMessageReflection.Descriptor.MessageTypes[0];

        [DebuggerNonUserCode]
        MessageDescriptor IMessage.Descriptor => Descriptor;

        [DebuggerNonUserCode]
        public string Mmid
        {
            get
            {
                return mmid_;
            }
            set
            {
                mmid_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        [DebuggerNonUserCode]
        public Level2Type Type
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
        public bool IsClosed
        {
            get
            {
                return isClosed_;
            }
            set
            {
                isClosed_ = value;
            }
        }

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
        public Level2QuoteMessage()
        {
        }

        [DebuggerNonUserCode]
        public Level2QuoteMessage(Level2QuoteMessage other)
            : this()
        {
            mmid_ = other.mmid_;
            type_ = other.type_;
            isClosed_ = other.isClosed_;
            price_ = other.price_;
            size_ = other.size_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        [DebuggerNonUserCode]
        public Level2QuoteMessage Clone()
        {
            return new Level2QuoteMessage(this);
        }

        [DebuggerNonUserCode]
        public override bool Equals(object other)
        {
            return Equals(other as Level2QuoteMessage);
        }

        [DebuggerNonUserCode]
        public bool Equals(Level2QuoteMessage other)
        {
            if (other == null)
            {
                return false;
            }

            if (other == this)
            {
                return true;
            }

            if (Mmid != other.Mmid)
            {
                return false;
            }

            if (Type != other.Type)
            {
                return false;
            }

            if (IsClosed != other.IsClosed)
            {
                return false;
            }

            if (!ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(Price, other.Price))
            {
                return false;
            }

            if (!ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(Size, other.Size))
            {
                return false;
            }

            return object.Equals(_unknownFields, other._unknownFields);
        }

        [DebuggerNonUserCode]
        public override int GetHashCode()
        {
            int num = 1;
            if (Mmid.Length != 0)
            {
                num ^= Mmid.GetHashCode();
            }

            if (Type != 0)
            {
                num ^= Type.GetHashCode();
            }

            if (IsClosed)
            {
                num ^= IsClosed.GetHashCode();
            }

            if (Price != 0.0)
            {
                num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(Price);
            }

            if (Size != 0.0)
            {
                num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(Size);
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
            if (Mmid.Length != 0)
            {
                output.WriteRawTag(10);
                output.WriteString(Mmid);
            }

            if (Type != 0)
            {
                output.WriteRawTag(16);
                output.WriteEnum((int)Type);
            }

            if (IsClosed)
            {
                output.WriteRawTag(24);
                output.WriteBool(IsClosed);
            }

            if (Price != 0.0)
            {
                output.WriteRawTag(33);
                output.WriteDouble(Price);
            }

            if (Size != 0.0)
            {
                output.WriteRawTag(41);
                output.WriteDouble(Size);
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
            if (Mmid.Length != 0)
            {
                num += 1 + CodedOutputStream.ComputeStringSize(Mmid);
            }

            if (Type != 0)
            {
                num += 1 + CodedOutputStream.ComputeEnumSize((int)Type);
            }

            if (IsClosed)
            {
                num += 2;
            }

            if (Price != 0.0)
            {
                num += 9;
            }

            if (Size != 0.0)
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
        public void MergeFrom(Level2QuoteMessage other)
        {
            if (other != null)
            {
                if (other.Mmid.Length != 0)
                {
                    Mmid = other.Mmid;
                }

                if (other.Type != 0)
                {
                    Type = other.Type;
                }

                if (other.IsClosed)
                {
                    IsClosed = other.IsClosed;
                }

                if (other.Price != 0.0)
                {
                    Price = other.Price;
                }

                if (other.Size != 0.0)
                {
                    Size = other.Size;
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
                    case 10u:
                        Mmid = input.ReadString();
                        break;
                    case 16u:
                        type_ = (Level2Type)input.ReadEnum();
                        break;
                    case 24u:
                        IsClosed = input.ReadBool();
                        break;
                    case 33u:
                        Price = input.ReadDouble();
                        break;
                    case 41u:
                        Size = input.ReadDouble();
                        break;
                }
            }
        }
    }
}
