using MauiApp1.Data;
using MauiApp1.Models.Full;

namespace MauiApp1.ViewModels.Full
{
    class SpotViewModel
    {
        public IList<SpotDataModel> Datas { get; set; } = new List<SpotDataModel>();

        public SpotViewModel()
        {
            Datas = FxSpotData.Datas;
        }
    }
}
