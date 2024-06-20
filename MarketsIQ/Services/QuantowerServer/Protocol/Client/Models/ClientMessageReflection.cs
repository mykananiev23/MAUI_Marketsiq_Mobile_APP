using Google.Protobuf.Reflection;
using MarketsIQ.Services.QuantowerServer.Protocol.Shared.Models;

namespace MarketsIQ.Services.QuantowerServer.Protocol.Client.Models
{
    public static class ClientMessageReflection
    {
        private static FileDescriptor descriptor;

        public static FileDescriptor Descriptor => descriptor;

        static ClientMessageReflection()
        {
            descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChRjbGllbnRfbWVzc2FnZS5wcm90bxoVY29ubmVjdF9tZXNzYWdlLnByb3Rv" + "GhJwaW5nX21lc3NhZ2UucHJvdG8aG2xvZ29uX3JlcXVlc3RfbWVzc2FnZS5w" + "cm90bxocbG9nb3V0X3JlcXVlc3RfbWVzc2FnZS5wcm90bxoibWFya2V0X3F1" + "b3RlX3JlcXVlc3RfbWVzc2FnZS5wcm90byKBAgoNQ2xpZW50TWVzc2FnZRIR" + "CglSZXF1ZXN0SWQYASABKAUSIQoLUGluZ01lc3NhZ2UYCSABKAsyDC5QaW5n" + "TWVzc2FnZRI3ChNNYXJrZXRRdW90ZVJlcXVlc3RzGAogAygLMhouTWFya2V0" + "UXVvdGVSZXF1ZXN0TWVzc2FnZRInCg5Db25uZWN0TWVzc2FnZRgUIAEoCzIP" + "LkNvbm5lY3RNZXNzYWdlEioKDExvZ29uUmVxdWVzdBhkIAEoCzIULkxvZ29u" + "UmVxdWVzdE1lc3NhZ2USLAoNTG9nb3V0UmVxdWVzdBhlIAEoCzIVLkxvZ291" + "dFJlcXVlc3RNZXNzYWdlQimqAiZRdWFudG93ZXJTZXJ2ZXIuUHJvdG9jb2wu" + "Q2xpZW50Lk1vZGVsc2IGcHJvdG8z"), new FileDescriptor[5]
            {
            ConnectMessageReflection.Descriptor,
            PingMessageReflection.Descriptor,
            LogonRequestMessageReflection.Descriptor,
            LogoutRequestMessageReflection.Descriptor,
            MarketQuoteRequestMessageReflection.Descriptor
            }, new GeneratedClrTypeInfo(null, new GeneratedClrTypeInfo[1]
            {
            new GeneratedClrTypeInfo(typeof(ClientMessage), ClientMessage.Parser, new string[6] { "RequestId", "PingMessage", "MarketQuoteRequests", "ConnectMessage", "LogonRequest", "LogoutRequest" }, null, null, null)
            }));
        }
    }
}
