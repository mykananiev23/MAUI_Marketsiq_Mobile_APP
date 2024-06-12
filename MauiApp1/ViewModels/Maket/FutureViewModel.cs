using MarketsIQ.Data;
using MarketsIQ.Models.Market;

namespace MarketsIQ.ViewModels.Maket
{
    class FutureViewModel
    {
        public IList<TestMarketSymbolModel> Datas { get; set; } = new List<TestMarketSymbolModel>();

        public FutureViewModel()
        {
            Datas = MarketTabData.Datas;
        }
    }
}
