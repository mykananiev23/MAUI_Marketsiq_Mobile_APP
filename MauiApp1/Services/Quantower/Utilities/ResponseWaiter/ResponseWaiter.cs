namespace MarketsIQ.Services.Quantower.Utilities.ResponseWaiter
{
    public class ResponseWaiter<TKey>
    {
        private interface IResponseWaiterItem
        {
            void Wait(CancellationToken externalToken);

            void Cancel();
        }

        private class ResponseWaiterItem<TResponse> : IResponseWaiterItem
        {
            private TResponse response;

            private readonly CancellationTokenSource cancellationTokenSource;

            public TResponse Response
            {
                get
                {
                    return response;
                }
                set
                {
                    response = value;
                    Cancel();
                }
            }

            public ResponseWaiterItem(TimeSpan timeout)
            {
                cancellationTokenSource = new CancellationTokenSource(timeout);
            }

            public void Wait(CancellationToken externalToken)
            {
                while (!cancellationTokenSource.IsCancellationRequested && !externalToken.IsCancellationRequested)
                {
                    Thread.Sleep(100);
                }
            }

            public void Cancel()
            {
                cancellationTokenSource?.Cancel();
            }
        }

        private readonly Dictionary<TKey, IResponseWaiterItem> waitersCache;

        private readonly object locker;

        private readonly TimeSpan defaultTimeout;

        public ResponseWaiter(TimeSpan defaultTimeout)
        {
            waitersCache = new Dictionary<TKey, IResponseWaiterItem>();
            locker = new object();
            this.defaultTimeout = defaultTimeout;
        }

        public bool WaitResponseAfter(Action action, IRequest<TKey> request, out IResponse<TKey> response, CancellationToken externalToken, TimeSpan? timeout = null)
        {
            return WaitResponseAfter<IResponse<TKey>>(action, request.ResponseKey, out response, externalToken, timeout);
        }

        public bool WaitResponseAfter<TResponse>(Action action, TKey responseKey, out TResponse response, CancellationToken externalToken, TimeSpan? timeout = null)
        {
            response = default(TResponse);
            ResponseWaiterItem<TResponse> responseWaiterItem = null;
            lock (locker)
            {
                responseWaiterItem = new ResponseWaiterItem<TResponse>(timeout ?? defaultTimeout);
                waitersCache.Add(responseKey, responseWaiterItem);
            }

            action?.Invoke();
            responseWaiterItem.Wait(externalToken);
            lock (locker)
            {
                waitersCache.Remove(responseKey);
            }

            TResponse response2 = responseWaiterItem.Response;
            ref TResponse reference = ref response2;
            TResponse val = default(TResponse);
            if (val == null)
            {
                val = reference;
                reference = ref val;
                if (val == null)
                {
                    goto IL_00df;
                }
            }

            if (!reference.Equals(null))
            {
                response = responseWaiterItem.Response;
                return true;
            }

            goto IL_00df;
        IL_00df:
            return false;
        }

        public bool CheckResponse(IResponse<TKey> response)
        {
            return CheckResponse(response.Key, response);
        }

        public bool CheckResponse<TResponse>(TKey responseKey, TResponse response)
        {
            if (response == null)
            {
                throw new ArgumentNullException("response");
            }

            if (responseKey == null)
            {
                return false;
            }

            IResponseWaiterItem value = null;
            lock (locker)
            {
                waitersCache.TryGetValue(responseKey, out value);
            }

            if (value is ResponseWaiterItem<TResponse> responseWaiterItem)
            {
                responseWaiterItem.Response = response;
                return true;
            }

            return false;
        }

        public void Clear()
        {
            lock (locker)
            {
                foreach (KeyValuePair<TKey, IResponseWaiterItem> item in waitersCache)
                {
                    item.Value.Cancel();
                }

                waitersCache.Clear();
            }
        }
    }
}
