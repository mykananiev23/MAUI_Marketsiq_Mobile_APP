namespace MarketsIQ.Services.Google.Protobuf
{
    public interface ICustomDiagnosticMessage : IMessage
    {
        string ToDiagnosticString();
    }
}
