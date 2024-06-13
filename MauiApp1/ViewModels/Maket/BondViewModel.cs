using MarketsIQ.Data;
using MarketsIQ.Models.Market;

namespace MarketsIQ.ViewModels.Maket
{
    class BondViewModel
    {
        public IList<TestMarketSymbolModel> Datas { get; set; } = new List<TestMarketSymbolModel>();

        public BondViewModel()
        {
            Datas = MarketTabData.Datas;
        }
    }
}
