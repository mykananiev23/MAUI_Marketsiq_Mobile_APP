using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketsIQ.Services.Quantower.API.Client.Models
{
    public class QTradeHistoryItem
    {
        public long Time { get; internal set; }

        public double Price { get; internal set; }

        public double Size { get; internal set; }

        public double OpenInterest { get; internal set; }

        public QAggressorFlag AggressorFlag { get; internal set; }
    }
}
