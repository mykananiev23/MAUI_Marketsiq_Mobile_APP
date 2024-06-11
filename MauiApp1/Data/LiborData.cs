using MauiApp1.Models.Full;

namespace MauiApp1.Data
{
    public class LiborData
    {
        public static IList<LiqorDataModel> Datas { get; set; } = new List<LiqorDataModel>();

        static LiborData()
        {
            Datas.Add(new LiqorDataModel
            {
                Symbol = "QR",
                USD = "0",
                EUR = "0",
                GBP = "0"
            });

            Datas.Add(new LiqorDataModel
            {
                Symbol = "SW",
                USD = "0",
                EUR = "0",
                GBP = "0"
            });

            Datas.Add(new LiqorDataModel
            {
                Symbol = "1M",
                USD = "0",
                EUR = "0",
                GBP = "0"
            });

            Datas.Add(new LiqorDataModel
            {
                Symbol = "2M",
                USD = "0",
                EUR = "0",
                GBP = "0"
            });
        }
    }
}
