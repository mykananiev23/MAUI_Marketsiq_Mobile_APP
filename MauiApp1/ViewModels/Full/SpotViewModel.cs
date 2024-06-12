using MarketsIQ.Data;
using MarketsIQ.Models.Full;

namespace MarketsIQ.ViewModels.Full
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
