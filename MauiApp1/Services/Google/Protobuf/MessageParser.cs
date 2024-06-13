namespace MarketsIQ.Services.Google.Protobuf
{
    public class MessageParser
    {
        private Func<IMessage> factory;

        internal bool DiscardUnknownFields { get; }

        internal MessageParser(Func<IMessage> factory, bool discardUnknownFields)
        {
            this.factory = factory;
            DiscardUnknownFields = discardUnknownFields;
        }

        internal IMessage CreateTemplate()
        {
            return factory();
        }

        public IMessage ParseFrom(byte[] data)
        {
            IMessage message = factory();
            message.MergeFrom(data, DiscardUnknownFields);
            return message;
        }

        public IMessage ParseFrom(byte[] data, int offset, int length)
        {
            IMessage message = factory();
            message.MergeFrom(data, offset, length, DiscardUnknownFields);
            return message;
        }

        public IMessage ParseFrom(ByteString data)
        {
            IMessage message = factory();
            message.MergeFrom(data, DiscardUnknownFields);
            return message;
        }

        public IMessage ParseFrom(Stream input)
        {
            IMessage message = factory();
            message.MergeFrom(input, DiscardUnknownFields);
            return message;
        }

        public IMessage ParseDelimitedFrom(Stream input)
        {
            IMessage message = factory();
            message.MergeDelimitedFrom(input, DiscardUnknownFields);
            return message;
        }

        public IMessage ParseFrom(CodedInputStream input)
        {
            IMessage message = factory();
            MergeFrom(message, input);
            return message;
        }

        public IMessage ParseJson(string json)
        {
            IMessage message = factory();
            JsonParser.Default.Merge(message, json);
            return message;
        }

        internal void MergeFrom(IMessage message, CodedInputStream codedInput)
        {
            bool discardUnknownFields = codedInput.DiscardUnknownFields;
            try
            {
                codedInput.DiscardUnknownFields = DiscardUnknownFields;
                message.MergeFrom(codedInput);
            }
            finally
            {
                codedInput.DiscardUnknownFields = discardUnknownFields;
            }
        }

        public MessageParser WithDiscardUnknownFields(bool discardUnknownFields)
        {
            return new MessageParser(factory, discardUnknownFields);
        }
    }
}
