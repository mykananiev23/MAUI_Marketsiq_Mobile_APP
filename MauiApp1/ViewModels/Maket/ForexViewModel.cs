using MarketsIQ.Data;
using MarketsIQ.Models.Market;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
