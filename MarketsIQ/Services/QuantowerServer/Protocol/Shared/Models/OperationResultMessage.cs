using System.Buffers;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace MarketsIQ.Services.QuantowerServer.Protocol.Shared.Models
{
    public sealed class OperationResultMessage : IMessage<OperationResultMessage>, IMessage, IEquatable<OperationResultMessage>, IDeepCloneable<OperationResultMessage>
    {
        private static readonly MessageParser<OperationResultMessage> _parser = new MessageParser<OperationResultMessage>(() => new OperationResultMessage());

        private UnknownFieldSet _unknownFields;

        public const int StatusFieldNumber = 1;

        private OperationStatus status_;

        public const int ErrorCodeFieldNumber = 2;

        private int errorCode_;

        public const int ErrorTextFieldNumber = 3;

        private string errorText_ = "";

        public const int ResultValueFieldNumber = 4;

        private string resultValue_ = "";

        [DebuggerNonUserCode]
        public static MessageParser<OperationResultMessage> Parser => _parser;

        [DebuggerNonUserCode]
        public static MessageDescriptor Descriptor => OperationResultMessageReflection.Descriptor.MessageTypes[0];

        [DebuggerNonUserCode]
        MessageDescriptor IMessage.Descriptor => Descriptor;

        [DebuggerNonUserCode]
        public OperationStatus Status
        {
            get
            {
                return status_;
            }
            set
            {
                status_ = value;
            }
        }

        [DebuggerNonUserCode]
        public int ErrorCode
        {
            get
            {
                return errorCode_;
            }
            set
            {
                errorCode_ = value;
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
        public string ResultValue
        {
            get
            {
                return resultValue_;
            }
            set
            {
                resultValue_ = ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        [DebuggerNonUserCode]
        public OperationResultMessage()
        {
        }

        [DebuggerNonUserCode]
        public OperationResultMessage(OperationResultMessage other)
            : this()
        {
            status_ = other.status_;
            errorCode_ = other.errorCode_;
            errorText_ = other.errorText_;
            resultValue_ = other.resultValue_;
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        [DebuggerNonUserCode]
        public OperationResultMessage Clone()
        {
            return new OperationResultMessage(this);
        }

        [DebuggerNonUserCode]
        public override bool Equals(object other)
        {
            return Equals(other as OperationResultMessage);
        }

        [DebuggerNonUserCode]
        public bool Equals(OperationResultMessage other)
        {
            if (other == null)
            {
                return false;
            }

            if (other == this)
            {
                return true;
            }

            if (Status != other.Status)
            {
                return false;
            }

            if (ErrorCode != other.ErrorCode)
            {
                return false;
            }

            if (ErrorText != other.ErrorText)
            {
                return false;
            }

            if (ResultValue != other.ResultValue)
            {
                return false;
            }

            return object.Equals(_unknownFields, other._unknownFields);
        }

        [DebuggerNonUserCode]
        public override int GetHashCode()
        {
            int num = 1;
            if (Status != 0)
            {
                num ^= Status.GetHashCode();
            }

            if (ErrorCode != 0)
            {
                num ^= ErrorCode.GetHashCode();
            }

            if (ErrorText.Length != 0)
            {
                num ^= ErrorText.GetHashCode();
            }

            if (ResultValue.Length != 0)
            {
                num ^= ResultValue.GetHashCode();
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
            if (Status != 0)
            {
                output.WriteRawTag(8);
                output.WriteEnum((int)Status);
            }

            if (ErrorCode != 0)
            {
                output.WriteRawTag(16);
                output.WriteInt32(ErrorCode);
            }

            if (ErrorText.Length != 0)
            {
                output.WriteRawTag(26);
                output.WriteString(ErrorText);
            }

            if (ResultValue.Length != 0)
            {
                output.WriteRawTag(34);
                output.WriteString(ResultValue);
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
            if (Status != 0)
            {
                num += 1 + CodedOutputStream.ComputeEnumSize((int)Status);
            }

            if (ErrorCode != 0)
            {
                num += 1 + CodedOutputStream.ComputeInt32Size(ErrorCode);
            }

            if (ErrorText.Length != 0)
            {
                num += 1 + CodedOutputStream.ComputeStringSize(ErrorText);
            }

            if (ResultValue.Length != 0)
            {
                num += 1 + CodedOutputStream.ComputeStringSize(ResultValue);
            }

            if (_unknownFields != null)
            {
                num += _unknownFields.CalculateSize();
            }

            return num;
        }

        [DebuggerNonUserCode]
        public void MergeFrom(OperationResultMessage other)
        {
            if (other != null)
            {
                if (other.Status != 0)
                {
                    Status = other.Status;
                }

                if (other.ErrorCode != 0)
                {
                    ErrorCode = other.ErrorCode;
                }

                if (other.ErrorText.Length != 0)
                {
                    ErrorText = other.ErrorText;
                }

                if (other.ResultValue.Length != 0)
                {
                    ResultValue = other.ResultValue;
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
                    case 8u:
                        status_ = (OperationStatus)input.ReadEnum();
                        break;
                    case 16u:
                        ErrorCode = input.ReadInt32();
                        break;
                    case 26u:
                        ErrorText = input.ReadString();
                        break;
                    case 34u:
                        ResultValue = input.ReadString();
                        break;
                }
            }
        }

        public static OperationResultMessage Success()
        {
            return new OperationResultMessage
            {
                Status = OperationStatus.Success
            };
        }

        public static OperationResultMessage Success(string message)
        {
            return new OperationResultMessage
            {
                Status = OperationStatus.Success,
                ResultValue = message
            };
        }

        public static OperationResultMessage Failed(string errorText, int errorCode = -1)
        {
            return new OperationResultMessage
            {
                Status = OperationStatus.Failed,
                ErrorCode = errorCode,
                ErrorText = errorText
            };
        }
    }
}
