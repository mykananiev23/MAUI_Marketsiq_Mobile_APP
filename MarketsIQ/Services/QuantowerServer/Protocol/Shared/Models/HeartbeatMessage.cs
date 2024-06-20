using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace MarketsIQ.Services.QuantowerServer.Protocol.Shared.Models
{
    public sealed class HeartbeatMessage : IMessage<HeartbeatMessage>, IMessage, IEquatable<HeartbeatMessage>, IDeepCloneable<HeartbeatMessage>
    {
        private static readonly MessageParser<HeartbeatMessage> _parser = new MessageParser<HeartbeatMessage>(() => new HeartbeatMessage());

        private UnknownFieldSet _unknownFields;

        [DebuggerNonUserCode]
        public static MessageParser<HeartbeatMessage> Parser => _parser;

        [DebuggerNonUserCode]
        public static MessageDescriptor Descriptor => HeartbeatMessageReflection.Descriptor.MessageTypes[0];

        [DebuggerNonUserCode]
        MessageDescriptor IMessage.Descriptor => Descriptor;

        [DebuggerNonUserCode]
        public HeartbeatMessage()
        {
        }

        [DebuggerNonUserCode]
        public HeartbeatMessage(HeartbeatMessage other)
            : this()
        {
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        [DebuggerNonUserCode]
        public HeartbeatMessage Clone()
        {
            return new HeartbeatMessage(this);
        }

        [DebuggerNonUserCode]
        public override bool Equals(object other)
        {
            return Equals(other as HeartbeatMessage);
        }

        [DebuggerNonUserCode]
        public bool Equals(HeartbeatMessage other)
        {
            if (other == null)
            {
                return false;
            }

            if (other == this)
            {
                return true;
            }

            return object.Equals(_unknownFields, other._unknownFields);
        }

        [DebuggerNonUserCode]
        public override int GetHashCode()
        {
            int num = 1;
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
            if (_unknownFields != null)
            {
                _unknownFields.WriteTo(output);
            }
        }

        [DebuggerNonUserCode]
        public int CalculateSize()
        {
            int num = 0;
            if (_unknownFields != null)
            {
                num += _unknownFields.CalculateSize();
            }

            return num;
        }

        [DebuggerNonUserCode]
        public void MergeFrom(HeartbeatMessage other)
        {
            if (other != null)
            {
                _unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
            }
        }

        [DebuggerNonUserCode]
        public void MergeFrom(CodedInputStream input)
        {
            uint num;
            while ((num = input.ReadTag()) != 0)
            {
                _unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            }
        }
    }
}
