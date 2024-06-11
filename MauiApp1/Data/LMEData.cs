using MauiApp1.Models.Full;

namespace MauiApp1.Data
{
    public class LMEData
    {
        public static IList<LMEDataModel> Datas { get; set; } = new List<LMEDataModel>();

        static LMEData ()
        {
            Datas.Add(new LMEDataModel
            {
                Symbol = "3M",
                Net = "1.92",
                Bid = "",
                Ask = "",
                ClosingStock = "162548",
                OpeningStock = "",
                In = "",
                Out = "",
                Warrants = "",
                CWarrants = "",
                CWRation = ""
            });

            Datas.Add(new LMEDataModel
            {
                Symbol = "Ton",
                Net = "1.92",
                Bid = "",
                Ask = "",
                ClosingStock = "162548",
                OpeningStock = "",
                In = "",
                Out = "",
                Warrants = "",
                CWarrants = "",
                CWRation = ""
            });

            Datas.Add(new LMEDataModel
            {
                Symbol = "Cash to 3M",
                Net = "1.92",
                Bid = "",
                Ask = "",
                ClosingStock = "162548",
                OpeningStock = "",
                In = "",
                Out = "",
                Warrants = "",
                CWarrants = "",
                CWRation = ""
            });
        }
    }
}
