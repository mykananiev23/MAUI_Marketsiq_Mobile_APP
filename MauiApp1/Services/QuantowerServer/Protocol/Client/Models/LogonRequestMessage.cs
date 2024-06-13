using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace MarketsIQ.Services.QuantowerServer.Protocol.Client.Models
{
    public sealed class LogonRequestMessage : IMessage<LogonRequestMessage>, IMessage, IEquatable<LogonRequestMessage>, IDeepCloneable<LogonRequestMessage>
    {
        private static readonly MessageParser<LogonRequestMessage> _parser = new MessageParser<LogonRequestMessage>(() => new LogonRequestMessage());

        private UnknownFieldSet _unknownFields;

        public const int TokenFieldNumber = 1;

        private string token_ = "";

        [DebuggerNonUserCode]
        public static MessageParser<LogonRequestMessage> Parser => _parser;

        [DebuggerNonUserCode]
        public static MessageDescriptor Descriptor => LogonRequestMessageReflection.Descriptor.MessageTypes[0];

        [DebuggerNonUserCode]
        MessageDescriptor IMessage.Descriptor => Descriptor;

        [DebuggerNonUserCode]
        public string Token
        {
            get
            {
                return token_;
            }
            set
            {
                token_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        [DebuggerNonUserCode]
        public LogonRequestMessage()
        {
        }

        [DebuggerNonUserCode]
        public LogonRequestMessage(LogonRequestMessage other)
            : this()
        {
            token_ = other.token_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        [DebuggerNonUserCode]
        public LogonRequestMessage Clone()
        {
            return new LogonRequestMessage(this);
        }

        [DebuggerNonUserCode]
        public override bool Equals(object other)
        {
            return Equals(other as LogonRequestMessage);
        }

        [DebuggerNonUserCode]
        public bool Equals(LogonRequestMessage other)
        {
            if (other == null)
            {
                return false;
            }

            if (other == this)
            {
                return true;
            }

            if (Token != other.Token)
            {
                return false;
            }

            return object.Equals(_unknownFields, other._unknownFields);
        }

        [DebuggerNonUserCode]
        public override int GetHashCode()
        {
            int num = 1;
            if (Token.Length != 0)
            {
                num ^= Token.GetHashCode();
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
            if (Token.Length != 0)
            {
                output.WriteRawTag(10);
                output.WriteString(Token);
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
            if (Token.Length != 0)
            {
                num += 1 + CodedOutputStream.ComputeStringSize(Token);
            }

            if (_unknownFields != null)
            {
                num += _unknownFields.CalculateSize();
            }

            return num;
        }

        [DebuggerNonUserCode]
        public void MergeFrom(LogonRequestMessage other)
        {
            if (other != null)
            {
                if (other.Token.Length != 0)
                {
                    Token = other.Token;
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
                    Token = input.ReadString();
                }
            }
        }
    }
}
