using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketsIQ.Services.Quantower.API.Client.Business.Http
{
    public class QVolumeAnalysisClient : QHttpClient
    {
        private class QVolumeAnalysisDataDateTimeEqualityComparer : IEqualityComparer<QVolumeAnalysisData>
        {
            public static QVolumeAnalysisDataDateTimeEqualityComparer Instance { get; } = new QVolumeAnalysisDataDateTimeEqualityComparer();


            public bool Equals(QVolumeAnalysisData x, QVolumeAnalysisData y)
            {
                if (x == y)
                {
                    return true;
                }

                if (x == null)
                {
                    return false;
                }

                if (y == null)
                {
                    return false;
                }

                if (x.GetType() != y.GetType())
                {
                    return false;
                }

                return x.Time.Equals(y.Time);
            }

            public int GetHashCode(QVolumeAnalysisData obj)
            {
                return obj.Time.GetHashCode();
            }
        }

        public QVolumeAnalysisClient(string baseEndpoint, QClientConfig clientConfig)
            : base(baseEndpoint, clientConfig)
        {
        }

        public QOperationResult<QVolumeAnalysisData[]> GetVolumeAnalysisData(string instrumentId, DateTime from, DateTime to, string unit, int multiplier, bool includePriceLevels, CancellationToken cancellationToken)
        {
            QOperationResult<QVolumeAnalysisData[]> qOperationResult = PaginationLoading((int pageNumber) => MakeHttpRequest<QVolumeAnalysisData[]>(HttpMethod.Get, "api/v1/volume-analysis?instrumentId=" + instrumentId + "&from=" + from.ToString("o", CultureInfo.InvariantCulture) + "&" + string.Format("to={0}&page={1}&unit={2}&multiplier={3}&includePriceLevels={4}", to.ToString("o", CultureInfo.InvariantCulture), pageNumber, unit, multiplier, includePriceLevels), cancellationToken), 1000, cancellationToken);
            if (qOperationResult.Value.Any())
            {
                QVolumeAnalysisData[] value = qOperationResult.Value.Distinct(QVolumeAnalysisDataDateTimeEqualityComparer.Instance).ToArray();
                qOperationResult.Value = value;
            }

            return qOperationResult;
        }
    }
}
