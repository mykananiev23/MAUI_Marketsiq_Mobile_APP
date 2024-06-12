using MarketsIQ.Data;
using MarketsIQ.Models.Full;

namespace MarketsIQ.ViewModels.Full
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
