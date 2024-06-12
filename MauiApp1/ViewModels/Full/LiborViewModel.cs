using MarketsIQ.Data;
using MarketsIQ.Models.Full;

namespace MarketsIQ.ViewModels.Full
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
