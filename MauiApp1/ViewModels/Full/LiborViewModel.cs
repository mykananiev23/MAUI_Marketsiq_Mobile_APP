using MauiApp1.Data;
using MauiApp1.Models.Full;

namespace MauiApp1.ViewModels.Full
{
    class LiborViewModel
    {
        public IList<LiqorDataModel> Datas { get; set; } = new List<LiqorDataModel>();

        public LiborViewModel()
        {
            Datas = LiborData.Datas;
        }
    }
}
