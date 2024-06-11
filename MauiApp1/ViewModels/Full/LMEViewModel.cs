using MauiApp1.Data;
using MauiApp1.Models.Full;

namespace MauiApp1.ViewModels.Full
{
    class LMEViewModel
    {
        public IList<LMEDataModel> Datas { get; set; } = new List<LMEDataModel>();
        public IList<CopperModel> Coppers { get; set; } = new List<CopperModel>();
        public IList<CurrencyModel> Currencies { get; set; } = new List<CurrencyModel>();
        public CurrencyModel SelectedCurrency { get; set; }
        public CopperModel SelectedCopper { get; set; }
        public LMEDataModel SelectedData { set; get; }

        public LMEViewModel()
        {
            Datas = LMEData.Datas;
            Coppers = CopperData.Datas;
            Currencies = CurrencyData.Datas;

            SelectedCurrency = Currencies.FirstOrDefault();
            SelectedCopper = Coppers.FirstOrDefault();
            SelectedData = Datas.FirstOrDefault();
        }
    }
}
