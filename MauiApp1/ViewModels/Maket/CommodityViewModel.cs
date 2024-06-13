using MarketsIQ.Data;
using MarketsIQ.Models.Market;

namespace MarketsIQ.ViewModels.Maket
{
    class CommodityViewModel
    {
        public IList<TestMarketSymbolModel> Datas { get; set; } = new List<TestMarketSymbolModel>();

        public CommodityViewModel()
        {
            Datas = MarketTabData.Datas;
        }
    }
}
