using MauiApp1.Data;
using MauiApp1.Models.Full;

namespace MauiApp1.ViewModels.Full
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
