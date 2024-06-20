using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace MarketsIQ.Services.QuantowerServer.Protocol.Client.Models
{
    public sealed class PingMessage : IMessage<PingMessage>, IMessage, IEquatable<PingMessage>, IDeepCloneable<PingMessage>
    {
        private static readonly MessageParser<PingMessage> _parser = new MessageParser<PingMessage>(() => new PingMessage());

        private UnknownFieldSet _unknownFields;

        [DebuggerNonUserCode]
        public static MessageParser<PingMessage> Parser => _parser;

        [DebuggerNonUserCode]
        public static MessageDescriptor Descriptor => PingMessageReflection.Descriptor.MessageTypes[0];

        [DebuggerNonUserCode]
        MessageDescriptor IMessage.Descriptor => Descriptor;

        [DebuggerNonUserCode]
        public PingMessage()
        {
        }

        [DebuggerNonUserCode]
        public PingMessage(PingMessage other)
            : this()
        {
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        [DebuggerNonUserCode]
        public PingMessage Clone()
        {
            return new PingMessage(this);
        }

        [DebuggerNonUserCode]
        public override bool Equals(object other)
        {
            return Equals(other as PingMessage);
        }

        [DebuggerNonUserCode]
        public bool Equals(PingMessage other)
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
        public void MergeFrom(PingMessage other)
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
