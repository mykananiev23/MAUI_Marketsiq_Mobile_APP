using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace MarketsIQ.Services.QuantowerServer.Protocol.Client.Models
{
    public sealed class ConnectMessage : IMessage<ConnectMessage>, IMessage, IEquatable<ConnectMessage>, IDeepCloneable<ConnectMessage>
    {
        private static readonly MessageParser<ConnectMessage> _parser = new MessageParser<ConnectMessage>(() => new ConnectMessage());

        private UnknownFieldSet _unknownFields;

        [DebuggerNonUserCode]
        public static MessageParser<ConnectMessage> Parser => _parser;

        [DebuggerNonUserCode]
        public static MessageDescriptor Descriptor => ConnectMessageReflection.Descriptor.MessageTypes[0];

        [DebuggerNonUserCode]
        MessageDescriptor IMessage.Descriptor => Descriptor;

        [DebuggerNonUserCode]
        public ConnectMessage()
        {
        }

        [DebuggerNonUserCode]
        public ConnectMessage(ConnectMessage other)
            : this()
        {
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        [DebuggerNonUserCode]
        public ConnectMessage Clone()
        {
            return new ConnectMessage(this);
        }

        [DebuggerNonUserCode]
        public override bool Equals(object other)
        {
            return Equals(other as ConnectMessage);
        }

        [DebuggerNonUserCode]
        public bool Equals(ConnectMessage other)
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
        public void MergeFrom(ConnectMessage other)
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
