using System;
using System.Net.Http;
using System.Threading;
using MarketsIQ.Services.Quantower.API.Client.Models;
using MarketsIQ.Services.Quantower.API.Client.Models.Tables;

namespace MarketsIQ.Services.Quantower.API.Client.Business.Http
{
    public class QHistoryClient : QHttpClient
    {
        public QHistoryClient(string baseEndpoint, QClientConfig clientConfig)
            : base(baseEndpoint, clientConfig)
        {
        }

        public QOperationResult<QLevel1HistoryItem[]> GetLevel1History(string instrumentId, DateTime from, DateTime to, CancellationToken cancellationToken)
        {
            return PaginationLoading(delegate (int pageNumber)
            {
                QOperationResult<QLevel1Table> qOperationResult = MakeHttpRequest<QLevel1Table>(HttpMethod.Get, $"api/v1/level1?instrumentId={instrumentId}&page={pageNumber}&fromTicks={from.Ticks}&toTicks={to.Ticks}", cancellationToken);
                return qOperationResult.MapTo(delegate (QLevel1Table table)
                {
                    if (table == null)
                    {
                        return null;
                    }

                    QLevel1HistoryItem[] array = new QLevel1HistoryItem[table.Length];
                    for (int i = 0; i < array.Length; i++)
                    {
                        array[i] = new QLevel1HistoryItem
                        {
                            Time = table.TimeArray[i].Ticks,
                            BidPrice = table.BidPriceArray[i],
                            BidSize = table.BidSizeArray[i],
                            AskPrice = table.AskPriceArray[i],
                            AskSize = table.AskSizeArray[i]
                        };
                    }

                    return array;
                });
            }, 50000, cancellationToken);
        }

        public QOperationResult<QTradeHistoryItem[]> GetTradesHistory(string instrumentId, DateTime from, DateTime to, CancellationToken cancellationToken)
        {
            return PaginationLoading(delegate (int pageNumber)
            {
                QOperationResult<QTradesTable> qOperationResult = MakeHttpRequest<QTradesTable>(HttpMethod.Get, $"api/v1/trades?instrumentId={instrumentId}&page={pageNumber}&fromTicks={from.Ticks}&toTicks={to.Ticks}", cancellationToken);
                return qOperationResult.MapTo(delegate (QTradesTable table)
                {
                    if (table == null)
                    {
                        return null;
                    }

                    QTradeHistoryItem[] array = new QTradeHistoryItem[table.Length];
                    for (int i = 0; i < array.Length; i++)
                    {
                        array[i] = new QTradeHistoryItem
                        {
                            Time = table.TimeArray[i].Ticks,
                            Price = table.PriceArray[i],
                            Size = table.SizeArray[i],
                            OpenInterest = table.OpenInterestArray[i],
                            AggressorFlag = table.AggressorFlagArray[i]
                        };
                    }

                    return array;
                });
            }, 50000, cancellationToken);
        }

        public QOperationResult<QBarHistoryItem[]> GetBarsHistory(string instrumentId, DateTime from, DateTime to, string dataType, string unit, int multiplier, CancellationToken cancellationToken)
        {
            return PaginationLoading(delegate (int pageNumber)
            {
                QOperationResult<QBarsTable> qOperationResult = MakeHttpRequest<QBarsTable>(HttpMethod.Get, $"api/v1/bars?type={dataType}&unit={unit}&multiplier={multiplier}&instrumentId={instrumentId}&page={pageNumber}&fromTicks={from.Ticks}&toTicks={to.Ticks}", cancellationToken);
                return qOperationResult.MapTo(delegate (QBarsTable table)
                {
                    if (table == null)
                    {
                        return null;
                    }

                    QBarHistoryItem[] array = new QBarHistoryItem[table.Length];
                    for (int i = 0; i < array.Length; i++)
                    {
                        array[i] = new QBarHistoryItem
                        {
                            Time = table.TimeArray[i],
                            Open = table.OpenPriceArray[i],
                            High = table.HighPriceArray[i],
                            Low = table.LowPriceArray[i],
                            Close = table.ClosePriceArray[i],
                            Volume = table.VolumeArray[i],
                            Ticks = table.TicksArray[i],
                            OpenInterest = table.OpenInterest[i]
                        };
                    }

                    return array;
                });
            }, 50000, cancellationToken);
        }

        public QOperationResult<AggregatedHistoryTypeItem[]> GetTypes(CancellationToken cancellationToken)
        {
            return MakeHttpRequest<AggregatedHistoryTypeItem[]>(HttpMethod.Get, "api/v2/types", cancellationToken);
        }
    }
}
