using MauiApp1.Data;
using MauiApp1.Models.Full;

namespace MauiApp1.ViewModels.Full
{
    class INRViewModel
    {
        public IList<INRDataModel> Datas { get; set; } = new List<INRDataModel>();

        public INRViewModel()
        {
            Datas = FxINRData.Datas;
        }
    }
}
