using MauiApp1.Models.Full;

namespace MauiApp1.Data
{
    public class ForwardsData
    {
        public static IList<ForwardsDataModel> Datas { get; set; } = new List<ForwardsDataModel>();

        static ForwardsData()
        {
            Datas.Add(new ForwardsDataModel
            {
                SymbolName = "Symbol1",
                Ask = "0.15",
                Bid = "0.16",
                ValueDate = "20-Apr-2021"
            });
            Datas.Add(new ForwardsDataModel
            {
                SymbolName = "Symbol1",
                Ask = "0.15",
                Bid = "0.16",
                ValueDate = "20-Apr-2021"
            });
            Datas.Add(new ForwardsDataModel
            {
                SymbolName = "Symbol1",
                Ask = "0.15",
                Bid = "0.16",
                ValueDate = "20-Apr-2021"
            });
            Datas.Add(new ForwardsDataModel
            {
                SymbolName = "Symbol1",
                Ask = "0.15",
                Bid = "0.16",
                ValueDate = "20-Apr-2021"
            });
        }
    }
}
