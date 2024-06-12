using MarketsIQ.Models.Market;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketsIQ.Data
{
    public class MarketTabData
    {
        public static IList<TestMarketSymbolModel> Datas { get; set; } = new List<TestMarketSymbolModel>();

        static MarketTabData()
        {
            Datas.Add(new TestMarketSymbolModel
            {
                Description = "Down Jones Index",
                Type = "Index",
                AskPrice = "116.00",
                BidPrice = "33738.50",
                Time = "22:22:22",
                BidVolumn = "337380.00",
                AskVolumn = "337390.00"
            });

            Datas.Add(new TestMarketSymbolModel
            {
                Description = "Down Jones Index",
                Type = "Index",
                AskPrice = "116.00",
                BidPrice = "33738.50",
                Time = "22:22:22",
                BidVolumn = "337380.00",
                AskVolumn = "337390.00"
            });

            Datas.Add(new TestMarketSymbolModel
            {
                Description = "Down Jones Index",
                Type = "Index",
                AskPrice = "116.00",
                BidPrice = "33738.50",
                Time = "22:22:22",
                BidVolumn = "337380.00",
                AskVolumn = "337390.00"
            });

            Datas.Add(new TestMarketSymbolModel
            {
                Description = "Down Jones Index",
                Type = "Index",
                AskPrice = "116.00",
                BidPrice = "33738.50",
                Time = "22:22:22",
                BidVolumn = "337380.00",
                AskVolumn = "337390.00"
            });

            Datas.Add(new TestMarketSymbolModel
            {
                Description = "Down Jones Index",
                Type = "Index",
                AskPrice = "116.00",
                BidPrice = "33738.50",
                Time = "22:22:22",
                BidVolumn = "337380.00",
                AskVolumn = "337390.00"
            });

            Datas.Add(new TestMarketSymbolModel
            {
                Description = "Down Jones Index",
                Type = "Index",
                AskPrice = "116.00",
                BidPrice = "33738.50",
                Time = "22:22:22",
                BidVolumn = "337380.00",
                AskVolumn = "337390.00"
            });
        }
    }
}
