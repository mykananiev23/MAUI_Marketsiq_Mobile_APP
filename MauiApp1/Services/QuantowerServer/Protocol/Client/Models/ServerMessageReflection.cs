using Google.Protobuf.Reflection;
using MarketsIQ.Services.QuantowerServer.Protocol.Shared.Models;

namespace MarketsIQ.Services.QuantowerServer.Protocol.Client.Models
{
    public static class ServerMessageReflection
    {
        private static FileDescriptor descriptor;

        public static FileDescriptor Descriptor => descriptor;

        static ServerMessageReflection()
        {
            descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChRzZXJ2ZXJfbWVzc2FnZS5wcm90bxoVY29ubmVjdF9tZXNzYWdlLnByb3Rv" + "GhJwaW5nX21lc3NhZ2UucHJvdG8aHm9wZXJhdGlvbl9yZXN1bHRfbWVzc2Fn" + "ZS5wcm90bxoabWFya2V0X3F1b3RlX21lc3NhZ2UucHJvdG8aHnJlcXVlc3Rf" + "cmVzcG9uc2VfbWVzc2FnZS5wcm90bxoYZGlzY29ubmVjdF9tZXNzYWdlLnBy" + "b3RvIoYDCg1TZXJ2ZXJNZXNzYWdlEhEKCVJlcXVlc3RJZBgBIAEoBRIhCgtQ" + "aW5nTWVzc2FnZRgJIAEoCzIMLlBpbmdNZXNzYWdlEigKC01hcmtldFF1b3Rl" + "GAogAygLMhMuTWFya2V0UXVvdGVNZXNzYWdlEicKDkNvbm5lY3RNZXNzYWdl" + "GBMgASgLMg8uQ29ubmVjdE1lc3NhZ2USMAoPUmVxdWVzdFJlc3BvbnNlGBQg" + "ASgLMhcuUmVxdWVzdFJlc3BvbnNlTWVzc2FnZRI0ChNNYXJrZXRRdW90ZVJl" + "c3BvbnNlGDIgASgLMhcuT3BlcmF0aW9uUmVzdWx0TWVzc2FnZRIsCgtMb2dv" + "blJlc3VsdBhkIAEoCzIXLk9wZXJhdGlvblJlc3VsdE1lc3NhZ2USLQoMTG9n" + "b3V0UmVzdWx0GGUgASgLMhcuT3BlcmF0aW9uUmVzdWx0TWVzc2FnZRInCgpE" + "aXNjb25uZWN0GJYBIAEoCzISLkRpc2Nvbm5lY3RNZXNzYWdlQimqAiZRdWFu" + "dG93ZXJTZXJ2ZXIuUHJvdG9jb2wuQ2xpZW50Lk1vZGVsc2IGcHJvdG8z"), new FileDescriptor[6]
            {
            ConnectMessageReflection.Descriptor,
            PingMessageReflection.Descriptor,
            OperationResultMessageReflection.Descriptor,
            MarketQuoteMessageReflection.Descriptor,
            RequestResponseMessageReflection.Descriptor,
            DisconnectMessageReflection.Descriptor
            }, new GeneratedClrTypeInfo(null, new GeneratedClrTypeInfo[1]
            {
            new GeneratedClrTypeInfo(typeof(ServerMessage), ServerMessage.Parser, new string[9] { "RequestId", "PingMessage", "MarketQuote", "ConnectMessage", "RequestResponse", "MarketQuoteResponse", "LogonResult", "LogoutResult", "Disconnect" }, null, null, null)
            }));
        }
    }
}
