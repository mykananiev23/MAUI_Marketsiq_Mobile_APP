using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace MarketsIQ.Services.QuantowerServer.Protocol.Shared.Models
{
    public sealed class RequestResponseMessage : IMessage<RequestResponseMessage>, IMessage, IEquatable<RequestResponseMessage>, IDeepCloneable<RequestResponseMessage>
    {
        private static readonly MessageParser<RequestResponseMessage> _parser = new MessageParser<RequestResponseMessage>(() => new RequestResponseMessage());

        private UnknownFieldSet _unknownFields;

        public const int MessageIdFieldNumber = 2;

        private int messageId_;

        public const int RequestIdFieldNumber = 3;

        private string requestId_ = "";

        public const int ModeFieldNumber = 4;

        private RequestResponseMode mode_;

        public const int ErrorTextFieldNumber = 5;

        private string errorText_ = "";

        public const int CustomDataFieldNumber = 6;

        private static readonly MapField<uint, CustomDataMessage>.Codec _map_customData_codec = new MapField<uint, CustomDataMessage>.Codec(FieldCodec.ForUInt32(8u), FieldCodec.ForMessage(18u, CustomDataMessage.Parser), 50u);

        private readonly MapField<uint, CustomDataMessage> customData_ = new MapField<uint, CustomDataMessage>();

        [DebuggerNonUserCode]
        public static MessageParser<RequestResponseMessage> Parser => _parser;

        [DebuggerNonUserCode]
        public static MessageDescriptor Descriptor => RequestResponseMessageReflection.Descriptor.MessageTypes[0];

        [DebuggerNonUserCode]
        MessageDescriptor IMessage.Descriptor => Descriptor;

        [DebuggerNonUserCode]
        public int MessageId
        {
            get
            {
                return messageId_;
            }
            set
            {
                messageId_ = value;
            }
        }

        [DebuggerNonUserCode]
        public string RequestId
        {
            get
            {
                return requestId_;
            }
            set
            {
                requestId_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        [DebuggerNonUserCode]
        public RequestResponseMode Mode
        {
            get
            {
                return mode_;
            }
            set
            {
                mode_ = value;
            }
        }

        [DebuggerNonUserCode]
        public string ErrorText
        {
            get
            {
                return errorText_;
            }
            set
            {
                errorText_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        [DebuggerNonUserCode]
        public MapField<uint, CustomDataMessage> CustomData => customData_;

        [DebuggerNonUserCode]
        public RequestResponseMessage()
        {
        }

        [DebuggerNonUserCode]
        public RequestResponseMessage(RequestResponseMessage other)
            : this()
        {
            messageId_ = other.messageId_;
            requestId_ = other.requestId_;
            mode_ = other.mode_;
            errorText_ = other.errorText_;
            customData_ = other.customData_.Clone();
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        [DebuggerNonUserCode]
        public RequestResponseMessage Clone()
        {
            return new RequestResponseMessage(this);
        }

        [DebuggerNonUserCode]
        public override bool Equals(object other)
        {
            return Equals(other as RequestResponseMessage);
        }

        [DebuggerNonUserCode]
        public bool Equals(RequestResponseMessage other)
        {
            if (other == null)
            {
                return false;
            }

            if (other == this)
            {
                return true;
            }

            if (MessageId != other.MessageId)
            {
                return false;
            }

            if (RequestId != other.RequestId)
            {
                return false;
            }

            if (Mode != other.Mode)
            {
                return false;
            }

            if (ErrorText != other.ErrorText)
            {
                return false;
            }

            if (!CustomData.Equals(other.CustomData))
            {
                return false;
            }

            return object.Equals(_unknownFields, other._unknownFields);
        }

        [DebuggerNonUserCode]
        public override int GetHashCode()
        {
            int num = 1;
            if (MessageId != 0)
            {
                num ^= MessageId.GetHashCode();
            }

            if (RequestId.Length != 0)
            {
                num ^= RequestId.GetHashCode();
            }

            if (Mode != 0)
            {
                num ^= Mode.GetHashCode();
            }

            if (ErrorText.Length != 0)
            {
                num ^= ErrorText.GetHashCode();
            }

            num ^= CustomData.GetHashCode();
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
            if (MessageId != 0)
            {
                output.WriteRawTag(16);
                output.WriteInt32(MessageId);
            }

            if (RequestId.Length != 0)
            {
                output.WriteRawTag(26);
                output.WriteString(RequestId);
            }

            if (Mode != 0)
            {
                output.WriteRawTag(32);
                output.WriteEnum((int)Mode);
            }

            if (ErrorText.Length != 0)
            {
                output.WriteRawTag(42);
                output.WriteString(ErrorText);
            }

            customData_.WriteTo(output, _map_customData_codec);
            if (_unknownFields != null)
            {
                _unknownFields.WriteTo(output);
            }
        }

        [DebuggerNonUserCode]
        public int CalculateSize()
        {
            int num = 0;
            if (MessageId != 0)
            {
                num += 1 + CodedOutputStream.ComputeInt32Size(MessageId);
            }

            if (RequestId.Length != 0)
            {
                num += 1 + CodedOutputStream.ComputeStringSize(RequestId);
            }

            if (Mode != 0)
            {
                num += 1 + CodedOutputStream.ComputeEnumSize((int)Mode);
            }

            if (ErrorText.Length != 0)
            {
                num += 1 + CodedOutputStream.ComputeStringSize(ErrorText);
            }

            num += customData_.CalculateSize(_map_customData_codec);
            if (_unknownFields != null)
            {
                num += _unknownFields.CalculateSize();
            }

            return num;
        }

        [DebuggerNonUserCode]
        public void MergeFrom(RequestResponseMessage other)
        {
            if (other != null)
            {
                if (other.MessageId != 0)
                {
                    MessageId = other.MessageId;
                }

                if (other.RequestId.Length != 0)
                {
                    RequestId = other.RequestId;
                }

                if (other.Mode != 0)
                {
                    Mode = other.Mode;
                }

                if (other.ErrorText.Length != 0)
                {
                    ErrorText = other.ErrorText;
                }

                customData_.Add(other.customData_);
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
                    case 16u:
                        MessageId = input.ReadInt32();
                        break;
                    case 26u:
                        RequestId = input.ReadString();
                        break;
                    case 32u:
                        mode_ = (RequestResponseMode)input.ReadEnum();
                        break;
                    case 42u:
                        ErrorText = input.ReadString();
                        break;
                    case 50u:
                        customData_.AddEntriesFrom(input, _map_customData_codec);
                        break;
                }
            }
        }
    }
}
