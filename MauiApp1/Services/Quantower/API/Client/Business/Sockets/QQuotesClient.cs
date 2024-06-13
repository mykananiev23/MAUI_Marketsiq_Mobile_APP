namespace MarketsIQ.Services.Quantower.API.Client.Business.Sockets
{
    public class QQuotesClient : QSocketClient
    {
        private readonly Queue<MarketQuoteRequestMessage> requestsQueue;

        private readonly object requestsQueueLocker;

        public event EventHandler<QEventArgs> MarketQuoteReceived;

        public QQuotesClient()
        {
            requestsQueue = new Queue<MarketQuoteRequestMessage>();
            requestsQueueLocker = new object();
        }

        public QOperationResult<string> Logon(string token, CancellationToken cancellationToken)
        {
            ClientMessage clientMessage = new ClientMessage
            {
                LogonRequest = new LogonRequestMessage
                {
                    Token = token
                }
            };
            ServerMessage serverMessage = SendRequest(clientMessage, cancellationToken);
            if (serverMessage?.LogonResult == null)
            {
                return QOperationResult<string>.CreateError("Logon response wasn't received from server");
            }

            if (serverMessage.LogonResult.Status == OperationStatus.Failed)
            {
                return QOperationResult<string>.CreateError(serverMessage.LogonResult.ErrorText);
            }

            return QOperationResult<string>.CreateSuccess(null);
        }

        public void Subscribe(int instrumentId, QMarketQuoteType subscriptionType)
        {
            AddRequestToQueue(new MarketQuoteRequestMessage
            {
                IsSubscribe = true,
                InstrumentId = instrumentId,
                MarketQuoteType = Convert(subscriptionType)
            });
        }

        public void Unsubscribe(int instrumentId, QMarketQuoteType subscriptionType)
        {
            AddRequestToQueue(new MarketQuoteRequestMessage
            {
                IsSubscribe = false,
                InstrumentId = instrumentId,
                MarketQuoteType = Convert(subscriptionType)
            });
        }

        protected override void OnTimerTick()
        {
            if (TryReadFromQueue(out var requests))
            {
                Task.Factory.StartNew(delegate
                {
                    ClientMessage clientMessage = new ClientMessage();
                    clientMessage.MarketQuoteRequests.AddRange(requests);
                    SendMessage(clientMessage);
                });
            }
        }

        protected override void ProcessServerMessage(ServerMessage serverMessage)
        {
            if (serverMessage.MarketQuote != null)
            {
                ProcessMarketData(serverMessage.MarketQuote);
            }
        }

        private void ProcessMarketData(IEnumerable<MarketQuoteMessage> marketQuoteMessages)
        {
            foreach (MarketQuoteMessage marketQuoteMessage in marketQuoteMessages)
            {
                QMarketQuote marketQuote = QMarketQuote.CreateFrom(marketQuoteMessage);
                OnMarketDataReceived(marketQuote);
            }
        }

        private static MarketQuoteType Convert(QMarketQuoteType clientMarketDataType)
        {
            MarketQuoteType result = MarketQuoteType.Level1;
            switch (clientMarketDataType)
            {
                case QMarketQuoteType.Level2:
                    result = MarketQuoteType.Level2;
                    break;
                case QMarketQuoteType.Trade:
                    result = MarketQuoteType.Trade;
                    break;
                case QMarketQuoteType.Level1:
                    result = MarketQuoteType.Level1;
                    break;
                case QMarketQuoteType.DayBar:
                    result = MarketQuoteType.DayBar;
                    break;
            }

            return result;
        }

        private static QMarketQuoteType Convert(MarketQuoteType protocolMarketDataType)
        {
            QMarketQuoteType result = QMarketQuoteType.Level1;
            switch (protocolMarketDataType)
            {
                case MarketQuoteType.Level2:
                    result = QMarketQuoteType.Level2;
                    break;
                case MarketQuoteType.Trade:
                    result = QMarketQuoteType.Trade;
                    break;
                case MarketQuoteType.DayBar:
                    result = QMarketQuoteType.DayBar;
                    break;
                case MarketQuoteType.Level1:
                    result = QMarketQuoteType.Level1;
                    break;
            }

            return result;
        }

        private void AddRequestToQueue(MarketQuoteRequestMessage request)
        {
            lock (requestsQueueLocker)
            {
                requestsQueue.Enqueue(request);
            }
        }

        private bool TryReadFromQueue(out List<MarketQuoteRequestMessage> requests)
        {
            requests = null;
            lock (requestsQueueLocker)
            {
                if (requestsQueue.Count == 0)
                {
                    return false;
                }

                requests = new List<MarketQuoteRequestMessage>();
                while (requestsQueue.Count > 0)
                {
                    requests.Add(requestsQueue.Dequeue());
                }

                return true;
            }
        }

        private void OnMarketDataReceived(QMarketQuote marketQuote)
        {
            this.MarketQuoteReceived?.Invoke(this, new QEventArgs
            {
                MarketData = marketQuote
            });
        }
    }
}
