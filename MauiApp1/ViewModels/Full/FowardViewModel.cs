using MarketsIQ.Data;
using MarketsIQ.Models.Full;

namespace MarketsIQ.ViewModels.Full
{
    class FowardViewModel
    {
        public IList<ForwardsDataModel> TableDatas { get; set; } = new List<ForwardsDataModel>();
        public IList<CurrencyModel> CurrencyDatas { get; set; } = new List<CurrencyModel>();
        public CurrencyModel SelectedItem { get; set; }

        public FowardViewModel()
        {
            TableDatas = ForwardsData.Datas;
            CurrencyDatas = CurrencyData.Datas;
            SelectedItem = CurrencyDatas.FirstOrDefault();
        }
    }
}
