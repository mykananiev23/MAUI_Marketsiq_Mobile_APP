using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using MarketsIQ.Services.QuantowerServer.Protocol.Shared.Models;

namespace MarketsIQ.Services.QuantowerServer.Protocol.Client.Models
{
    public sealed class ServerMessage : IMessage<ServerMessage>, IMessage, IEquatable<ServerMessage>, IDeepCloneable<ServerMessage>
    {
        private static readonly MessageParser<ServerMessage> _parser = new MessageParser<ServerMessage>(() => new ServerMessage());

        private UnknownFieldSet _unknownFields;

        public const int RequestIdFieldNumber = 1;

        private int requestId_;

        public const int PingMessageFieldNumber = 9;

        private PingMessage pingMessage_;

        public const int MarketQuoteFieldNumber = 10;

        private static readonly FieldCodec<MarketQuoteMessage> _repeated_marketQuote_codec = FieldCodec.ForMessage(82u, MarketQuoteMessage.Parser);

        private readonly RepeatedField<MarketQuoteMessage> marketQuote_ = new RepeatedField<MarketQuoteMessage>();

        public const int ConnectMessageFieldNumber = 19;

        private ConnectMessage connectMessage_;

        public const int RequestResponseFieldNumber = 20;

        private RequestResponseMessage requestResponse_;

        public const int MarketQuoteResponseFieldNumber = 50;

        private OperationResultMessage marketQuoteResponse_;

        public const int LogonResultFieldNumber = 100;

        private OperationResultMessage logonResult_;

        public const int LogoutResultFieldNumber = 101;

        private OperationResultMessage logoutResult_;

        public const int DisconnectFieldNumber = 150;

        private DisconnectMessage disconnect_;

        [DebuggerNonUserCode]
        public static MessageParser<ServerMessage> Parser => _parser;

        [DebuggerNonUserCode]
        public static MessageDescriptor Descriptor => ServerMessageReflection.Descriptor.MessageTypes[0];

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
        public RepeatedField<MarketQuoteMessage> MarketQuote => marketQuote_;

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
        public RequestResponseMessage RequestResponse
        {
            get
            {
                return requestResponse_;
            }
            set
            {
                requestResponse_ = value;
            }
        }

        [DebuggerNonUserCode]
        public OperationResultMessage MarketQuoteResponse
        {
            get
            {
                return marketQuoteResponse_;
            }
            set
            {
                marketQuoteResponse_ = value;
            }
        }

        [DebuggerNonUserCode]
        public OperationResultMessage LogonResult
        {
            get
            {
                return logonResult_;
            }
            set
            {
                logonResult_ = value;
            }
        }

        [DebuggerNonUserCode]
        public OperationResultMessage LogoutResult
        {
            get
            {
                return logoutResult_;
            }
            set
            {
                logoutResult_ = value;
            }
        }

        [DebuggerNonUserCode]
        public DisconnectMessage Disconnect
        {
            get
            {
                return disconnect_;
            }
            set
            {
                disconnect_ = value;
            }
        }

        [DebuggerNonUserCode]
        public ServerMessage()
        {
        }

        [DebuggerNonUserCode]
        public ServerMessage(ServerMessage other)
            : this()
        {
            requestId_ = other.requestId_;
            PingMessage = ((other.pingMessage_ != null) ? other.PingMessage.Clone() : null);
            marketQuote_ = other.marketQuote_.Clone();
            ConnectMessage = ((other.connectMessage_ != null) ? other.ConnectMessage.Clone() : null);
            RequestResponse = ((other.requestResponse_ != null) ? other.RequestResponse.Clone() : null);
            MarketQuoteResponse = ((other.marketQuoteResponse_ != null) ? other.MarketQuoteResponse.Clone() : null);
            LogonResult = ((other.logonResult_ != null) ? other.LogonResult.Clone() : null);
            LogoutResult = ((other.logoutResult_ != null) ? other.LogoutResult.Clone() : null);
            Disconnect = ((other.disconnect_ != null) ? other.Disconnect.Clone() : null);
            _unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        [DebuggerNonUserCode]
        public ServerMessage Clone()
        {
            return new ServerMessage(this);
        }

        [DebuggerNonUserCode]
        public override bool Equals(object other)
        {
            return Equals(other as ServerMessage);
        }

        [DebuggerNonUserCode]
        public bool Equals(ServerMessage other)
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

            if (!marketQuote_.Equals(other.marketQuote_))
            {
                return false;
            }

            if (!object.Equals(ConnectMessage, other.ConnectMessage))
            {
                return false;
            }

            if (!object.Equals(RequestResponse, other.RequestResponse))
            {
                return false;
            }

            if (!object.Equals(MarketQuoteResponse, other.MarketQuoteResponse))
            {
                return false;
            }

            if (!object.Equals(LogonResult, other.LogonResult))
            {
                return false;
            }

            if (!object.Equals(LogoutResult, other.LogoutResult))
            {
                return false;
            }

            if (!object.Equals(Disconnect, other.Disconnect))
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

            num ^= marketQuote_.GetHashCode();
            if (connectMessage_ != null)
            {
                num ^= ConnectMessage.GetHashCode();
            }

            if (requestResponse_ != null)
            {
                num ^= RequestResponse.GetHashCode();
            }

            if (marketQuoteResponse_ != null)
            {
                num ^= MarketQuoteResponse.GetHashCode();
            }

            if (logonResult_ != null)
            {
                num ^= LogonResult.GetHashCode();
            }

            if (logoutResult_ != null)
            {
                num ^= LogoutResult.GetHashCode();
            }

            if (disconnect_ != null)
            {
                num ^= Disconnect.GetHashCode();
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

            marketQuote_.WriteTo(output, _repeated_marketQuote_codec);
            if (connectMessage_ != null)
            {
                output.WriteRawTag(154, 1);
                output.WriteMessage(ConnectMessage);
            }

            if (requestResponse_ != null)
            {
                output.WriteRawTag(162, 1);
                output.WriteMessage(RequestResponse);
            }

            if (marketQuoteResponse_ != null)
            {
                output.WriteRawTag(146, 3);
                output.WriteMessage(MarketQuoteResponse);
            }

            if (logonResult_ != null)
            {
                output.WriteRawTag(162, 6);
                output.WriteMessage(LogonResult);
            }

            if (logoutResult_ != null)
            {
                output.WriteRawTag(170, 6);
                output.WriteMessage(LogoutResult);
            }

            if (disconnect_ != null)
            {
                output.WriteRawTag(178, 9);
                output.WriteMessage(Disconnect);
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

            num += marketQuote_.CalculateSize(_repeated_marketQuote_codec);
            if (connectMessage_ != null)
            {
                num += 2 + CodedOutputStream.ComputeMessageSize(ConnectMessage);
            }

            if (requestResponse_ != null)
            {
                num += 2 + CodedOutputStream.ComputeMessageSize(RequestResponse);
            }

            if (marketQuoteResponse_ != null)
            {
                num += 2 + CodedOutputStream.ComputeMessageSize(MarketQuoteResponse);
            }

            if (logonResult_ != null)
            {
                num += 2 + CodedOutputStream.ComputeMessageSize(LogonResult);
            }

            if (logoutResult_ != null)
            {
                num += 2 + CodedOutputStream.ComputeMessageSize(LogoutResult);
            }

            if (disconnect_ != null)
            {
                num += 2 + CodedOutputStream.ComputeMessageSize(Disconnect);
            }

            if (_unknownFields != null)
            {
                num += _unknownFields.CalculateSize();
            }

            return num;
        }

        [DebuggerNonUserCode]
        public void MergeFrom(ServerMessage other)
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

            marketQuote_.Add(other.marketQuote_);
            if (other.connectMessage_ != null)
            {
                if (connectMessage_ == null)
                {
                    connectMessage_ = new ConnectMessage();
                }

                ConnectMessage.MergeFrom(other.ConnectMessage);
            }

            if (other.requestResponse_ != null)
            {
                if (requestResponse_ == null)
                {
                    requestResponse_ = new RequestResponseMessage();
                }

                RequestResponse.MergeFrom(other.RequestResponse);
            }

            if (other.marketQuoteResponse_ != null)
            {
                if (marketQuoteResponse_ == null)
                {
                    marketQuoteResponse_ = new OperationResultMessage();
                }

                MarketQuoteResponse.MergeFrom(other.MarketQuoteResponse);
            }

            if (other.logonResult_ != null)
            {
                if (logonResult_ == null)
                {
                    logonResult_ = new OperationResultMessage();
                }

                LogonResult.MergeFrom(other.LogonResult);
            }

            if (other.logoutResult_ != null)
            {
                if (logoutResult_ == null)
                {
                    logoutResult_ = new OperationResultMessage();
                }

                LogoutResult.MergeFrom(other.LogoutResult);
            }

            if (other.disconnect_ != null)
            {
                if (disconnect_ == null)
                {
                    disconnect_ = new DisconnectMessage();
                }

                Disconnect.MergeFrom(other.Disconnect);
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
                        marketQuote_.AddEntriesFrom(input, _repeated_marketQuote_codec);
                        break;
                    case 154u:
                        if (connectMessage_ == null)
                        {
                            connectMessage_ = new ConnectMessage();
                        }

                        input.ReadMessage(connectMessage_);
                        break;
                    case 162u:
                        if (requestResponse_ == null)
                        {
                            requestResponse_ = new RequestResponseMessage();
                        }

                        input.ReadMessage(requestResponse_);
                        break;
                    case 402u:
                        if (marketQuoteResponse_ == null)
                        {
                            marketQuoteResponse_ = new OperationResultMessage();
                        }

                        input.ReadMessage(marketQuoteResponse_);
                        break;
                    case 802u:
                        if (logonResult_ == null)
                        {
                            logonResult_ = new OperationResultMessage();
                        }

                        input.ReadMessage(logonResult_);
                        break;
                    case 810u:
                        if (logoutResult_ == null)
                        {
                            logoutResult_ = new OperationResultMessage();
                        }

                        input.ReadMessage(logoutResult_);
                        break;
                    case 1202u:
                        if (disconnect_ == null)
                        {
                            disconnect_ = new DisconnectMessage();
                        }

                        input.ReadMessage(disconnect_);
                        break;
                }
            }
        }
    }
}
