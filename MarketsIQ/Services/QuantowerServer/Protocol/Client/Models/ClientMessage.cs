using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using MarketsIQ.Services.QuantowerServer.Protocol.Shared.Models;

namespace MarketsIQ.Services.QuantowerServer.Protocol.Client.Models
{
    public sealed class ClientMessage : IMessage<ClientMessage>, IMessage, IEquatable<ClientMessage>, IDeepCloneable<ClientMessage>
    {
        private static readonly MessageParser<ClientMessage> _parser = new MessageParser<ClientMessage>(() => new ClientMessage());

        private UnknownFieldSet _unknownFields;

        public const int RequestIdFieldNumber = 1;

        private int requestId_;

        public const int PingMessageFieldNumber = 9;

        private PingMessage pingMessage_;

        public const int MarketQuoteRequestsFieldNumber = 10;

        private static readonly FieldCodec<MarketQuoteRequestMessage> _repeated_marketQuoteRequests_codec = FieldCodec.ForMessage(82u, MarketQuoteRequestMessage.Parser);

        private readonly RepeatedField<MarketQuoteRequestMessage> marketQuoteRequests_ = new RepeatedField<MarketQuoteRequestMessage>();

        public const int ConnectMessageFieldNumber = 20;

        private ConnectMessage connectMessage_;

        public const int LogonRequestFieldNumber = 100;

        private LogonRequestMessage logonRequest_;

        public const int LogoutRequestFieldNumber = 101;

        private LogoutRequestMessage logoutRequest_;

        [DebuggerNonUserCode]
        public static MessageParser<ClientMessage> Parser => _parser;

        [DebuggerNonUserCode]
        public static MessageDescriptor Descriptor => ClientMessageReflection.Descriptor.MessageTypes[0];

        [DebuggerNonUserCode]
        MessageDescriptor IMessage.Descriptor => Descriptor;

        [DebuggerNonUserCode]
        public int RequestId
        {
            get
            {
                return requestId_;
            }
            set
            {
                requestId_ = value;
            }
        }

        [DebuggerNonUserCode]
        public PingMessage PingMessage
        {
            get
            {
                return pingMessage_;
            }
            set
            {
                pingMessage_ = value;
            }
        }

        [DebuggerNonUserCode]
        public RepeatedField<MarketQuoteRequestMessage> MarketQuoteRequests => marketQuoteRequests_;

        [DebuggerNonUserCode]
        public ConnectMessage ConnectMessage
        {
            get
            {
                return connectMessage_;
            }
            set
            {
                connectMessage_ = value;
            }
        }

        [DebuggerNonUserCode]
        public LogonRequestMessage LogonRequest
        {
            get
            {
                return logonRequest_;
            }
            set
            {
                logonRequest_ = value;
            }
        }

        [DebuggerNonUserCode]
        public LogoutRequestMessage LogoutRequest
        {
            get
            {
                return logoutRequest_;
            }
            set
            {
                logoutRequest_ = value;
            }
        }

        [DebuggerNonUserCode]
        public ClientMessage()
        {
        }

        [DebuggerNonUserCode]
        public ClientMessage(ClientMessage other)
            : this()
        {
            requestId_ = other.requestId_;
            PingMessage = ((other.pingMessage_ != null) ? other.PingMessage.Clone() : null);
            marketQuoteRequests_ = other.marketQuoteRequests_.Clone();
            ConnectMessage = ((other.connectMessage_ != null) ? other.ConnectMessage.Clone() : null);
            LogonRequest = ((other.logonRequest_ != null) ? other.LogonRequest.Clone() : null);
            LogoutRequest = ((other.logoutRequest_ != null) ? other.LogoutRequest.Clone() : null);
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        [DebuggerNonUserCode]
        public ClientMessage Clone()
        {
            return new ClientMessage(this);
        }

        [DebuggerNonUserCode]
        public override bool Equals(object other)
        {
            return Equals(other as ClientMessage);
        }

        [DebuggerNonUserCode]
        public bool Equals(ClientMessage other)
        {
            if (other == null)
            {
                return false;
            }

            if (other == this)
            {
                return true;
            }

            if (RequestId != other.RequestId)
            {
                return false;
            }

            if (!object.Equals(PingMessage, other.PingMessage))
            {
                return false;
            }

            if (!marketQuoteRequests_.Equals(other.marketQuoteRequests_))
            {
                return false;
            }

            if (!object.Equals(ConnectMessage, other.ConnectMessage))
            {
                return false;
            }

            if (!object.Equals(LogonRequest, other.LogonRequest))
            {
                return false;
            }

            if (!object.Equals(LogoutRequest, other.LogoutRequest))
            {
                return false;
            }

            return object.Equals(_unknownFields, other._unknownFields);
        }

        [DebuggerNonUserCode]
        public override int GetHashCode()
        {
            int num = 1;
            if (RequestId != 0)
            {
                num ^= RequestId.GetHashCode();
            }

            if (pingMessage_ != null)
            {
                num ^= PingMessage.GetHashCode();
            }

            num ^= marketQuoteRequests_.GetHashCode();
            if (connectMessage_ != null)
            {
                num ^= ConnectMessage.GetHashCode();
            }

            if (logonRequest_ != null)
            {
                num ^= LogonRequest.GetHashCode();
            }

            if (logoutRequest_ != null)
            {
                num ^= LogoutRequest.GetHashCode();
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
            if (RequestId != 0)
            {
                output.WriteRawTag(8);
                output.WriteInt32(RequestId);
            }

            if (pingMessage_ != null)
            {
                output.WriteRawTag(74);
                output.WriteMessage(PingMessage);
            }

            marketQuoteRequests_.WriteTo(output, _repeated_marketQuoteRequests_codec);
            if (connectMessage_ != null)
            {
                output.WriteRawTag(162, 1);
                output.WriteMessage(ConnectMessage);
            }

            if (logonRequest_ != null)
            {
                output.WriteRawTag(162, 6);
                output.WriteMessage(LogonRequest);
            }

            if (logoutRequest_ != null)
            {
                output.WriteRawTag(170, 6);
                output.WriteMessage(LogoutRequest);
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
            if (RequestId != 0)
            {
                num += 1 + CodedOutputStream.ComputeInt32Size(RequestId);
            }

            if (pingMessage_ != null)
            {
                num += 1 + CodedOutputStream.ComputeMessageSize(PingMessage);
            }

            num += marketQuoteRequests_.CalculateSize(_repeated_marketQuoteRequests_codec);
            if (connectMessage_ != null)
            {
                num += 2 + CodedOutputStream.ComputeMessageSize(ConnectMessage);
            }

            if (logonRequest_ != null)
            {
                num += 2 + CodedOutputStream.ComputeMessageSize(LogonRequest);
            }

            if (logoutRequest_ != null)
            {
                num += 2 + CodedOutputStream.ComputeMessageSize(LogoutRequest);
            }

            if (_unknownFields != null)
            {
                num += _unknownFields.CalculateSize();
            }

            return num;
        }

        [DebuggerNonUserCode]
        public void MergeFrom(ClientMessage other)
        {
            if (other == null)
            {
                return;
            }

            if (other.RequestId != 0)
            {
                RequestId = other.RequestId;
            }

            if (other.pingMessage_ != null)
            {
                if (pingMessage_ == null)
                {
                    pingMessage_ = new PingMessage();
                }

                PingMessage.MergeFrom(other.PingMessage);
            }

            marketQuoteRequests_.Add(other.marketQuoteRequests_);
            if (other.connectMessage_ != null)
            {
                if (connectMessage_ == null)
                {
                    connectMessage_ = new ConnectMessage();
                }

                ConnectMessage.MergeFrom(other.ConnectMessage);
            }

            if (other.logonRequest_ != null)
            {
                if (logonRequest_ == null)
                {
                    logonRequest_ = new LogonRequestMessage();
                }

                LogonRequest.MergeFrom(other.LogonRequest);
            }

            if (other.logoutRequest_ != null)
            {
                if (logoutRequest_ == null)
                {
                    logoutRequest_ = new LogoutRequestMessage();
                }

                LogoutRequest.MergeFrom(other.LogoutRequest);
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
                        RequestId = input.ReadInt32();
                        break;
                    case 74u:
                        if (pingMessage_ == null)
                        {
                            pingMessage_ = new PingMessage();
                        }

                        input.ReadMessage(pingMessage_);
                        break;
                    case 82u:
                        marketQuoteRequests_.AddEntriesFrom(input, _repeated_marketQuoteRequests_codec);
                        break;
                    case 162u:
                        if (connectMessage_ == null)
                        {
                            connectMessage_ = new ConnectMessage();
                        }

                        input.ReadMessage(connectMessage_);
                        break;
                    case 802u:
                        if (logonRequest_ == null)
                        {
                            logonRequest_ = new LogonRequestMessage();
                        }

                        input.ReadMessage(logonRequest_);
                        break;
                    case 810u:
                        if (logoutRequest_ == null)
                        {
                            logoutRequest_ = new LogoutRequestMessage();
                        }

                        input.ReadMessage(logoutRequest_);
                        break;
                }
            }
        }
    }
}
