using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace MarketsIQ.Services.QuantowerServer.Protocol.Client.Models
{
    public sealed class DisconnectMessage : IMessage<DisconnectMessage>, IMessage, IEquatable<DisconnectMessage>, IDeepCloneable<DisconnectMessage>
    {
        private static readonly MessageParser<DisconnectMessage> _parser = new MessageParser<DisconnectMessage>(() => new DisconnectMessage());

        private UnknownFieldSet _unknownFields;

        public const int ReasonFieldNumber = 1;

        private string reason_ = "";

        [DebuggerNonUserCode]
        public static MessageParser<DisconnectMessage> Parser => _parser;

        [DebuggerNonUserCode]
        public static MessageDescriptor Descriptor => DisconnectMessageReflection.Descriptor.MessageTypes[0];

        [DebuggerNonUserCode]
        MessageDescriptor IMessage.Descriptor => Descriptor;

        [DebuggerNonUserCode]
        public string Reason
        {
            get
            {
                return reason_;
            }
            set
            {
                reason_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        [DebuggerNonUserCode]
        public DisconnectMessage()
        {
        }

        [DebuggerNonUserCode]
        public DisconnectMessage(DisconnectMessage other)
            : this()
        {
            reason_ = other.reason_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        [DebuggerNonUserCode]
        public DisconnectMessage Clone()
        {
            return new DisconnectMessage(this);
        }

        [DebuggerNonUserCode]
        public override bool Equals(object other)
        {
            return Equals(other as DisconnectMessage);
        }

        [DebuggerNonUserCode]
        public bool Equals(DisconnectMessage other)
        {
            if (other == null)
            {
                return false;
            }

            if (other == this)
            {
                return true;
            }

            if (Reason != other.Reason)
            {
                return false;
            }

            return object.Equals(_unknownFields, other._unknownFields);
        }

        [DebuggerNonUserCode]
        public override int GetHashCode()
        {
            int num = 1;
            if (Reason.Length != 0)
            {
                num ^= Reason.GetHashCode();
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
            if (Reason.Length != 0)
            {
                output.WriteRawTag(10);
                output.WriteString(Reason);
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
            if (Reason.Length != 0)
            {
                num += 1 + CodedOutputStream.ComputeStringSize(Reason);
            }

            if (_unknownFields != null)
            {
                num += _unknownFields.CalculateSize();
            }

            return num;
        }

        [DebuggerNonUserCode]
        public void MergeFrom(DisconnectMessage other)
        {
            if (other != null)
            {
                if (other.Reason.Length != 0)
                {
                    Reason = other.Reason;
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
                if (num != 10)
                {
                    _unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
                }
                else
                {
                    Reason = input.ReadString();
                }
            }
        }
    }
}
