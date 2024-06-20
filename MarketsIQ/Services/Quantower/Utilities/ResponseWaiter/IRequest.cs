namespace MarketsIQ.Services.Quantower.Utilities.ResponseWaiter
{
    public interface IRequest<TKey>
    {
        TKey ResponseKey { get; }
    }
}
