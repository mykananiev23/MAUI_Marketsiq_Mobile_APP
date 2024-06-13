using MarketsIQ.Data;
using MarketsIQ.Models.Market;

namespace MarketsIQ.ViewModels.Maket
{
    class ForexViewModel
    {
        public IList<TestMarketSymbolModel> Datas { get; set; }

        public ForexViewModel()
        {
            Datas = MarketTabData.Datas;
        }
    }
}
