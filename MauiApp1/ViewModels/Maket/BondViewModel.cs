using MarketsIQ.Data;
using MarketsIQ.Models.Market;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
