using Newtonsoft.Json;

namespace MarketsIQ.Services.Quantower.API.Client.Models
{
    public class QOperationResult<T>
    {
        [JsonProperty("ErrorText")]
        public string ErrorText { get; set; }

        [JsonProperty("IsSuccess")]
        public bool IsSuccess { get; private set; }

        [JsonProperty("Value")]
        public T Value { get; internal set; }

        public bool IsCancelled { get; private set; }

        public static QOperationResult<T> CreateSuccess(T value)
        {
            return new QOperationResult<T>
            {
                IsSuccess = true,
                Value = value
            };
        }

        public static QOperationResult<T> CreateError(string errorText)
        {
            return new QOperationResult<T>
            {
                IsSuccess = false,
                ErrorText = errorText
            };
        }

        public static QOperationResult<T> CreateCancelled()
        {
            return new QOperationResult<T>
            {
                IsSuccess = false,
                IsCancelled = true
            };
        }

        public QOperationResult<TNew> MapTo<TNew>(Func<T, TNew> mapperFunc)
        {
            return new QOperationResult<TNew>
            {
                ErrorText = ErrorText,
                IsSuccess = IsSuccess,
                IsCancelled = IsCancelled,
                Value = mapperFunc(Value)
            };
        }
    }
}
