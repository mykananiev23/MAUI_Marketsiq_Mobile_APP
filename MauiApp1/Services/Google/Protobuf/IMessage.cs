using MarketsIQ.Services.Google.Protobuf.Reflection;

namespace MarketsIQ.Services.Google.Protobuf
{
    public interface IMessage
    {
        MessageDescriptor Descriptor { get; }

        void MergeFrom(CodedInputStream input);

        void WriteTo(CodedOutputStream output);

        int CalculateSize();
    }
    public interface IMessage<T> : IMessage, IEquatable<T>, IDeepCloneable<T> where T : IMessage<T>
    {
        void MergeFrom(T message);
    }
}
