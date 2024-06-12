using MarketsIQ.Models.Full;

namespace MarketsIQ.Data
{
    public class FxSpotData
    {
        public static IList<SpotDataModel> Datas { get; set; } = new List<SpotDataModel>();

        static FxSpotData()
        {
            Datas.Add(new SpotDataModel
            {
                Symbol = "INR",
                Time = "12.22.22",
                Net = "0",
                Bid = "0",
                Ask = "0"
            });

            Datas.Add(new SpotDataModel
            {
                Symbol = "AUD",
                Time = "12.22.22",
                Net = "0",
                Bid = "0",
                Ask = "0"
            });

            Datas.Add(new SpotDataModel
            {
                Symbol = "EUR",
                Time = "12.22.22",
                Net = "0",
                Bid = "0",
                Ask = "0"
            });

            Datas.Add(new SpotDataModel
            {
                Symbol = "CNY",
                Time = "12.22.22",
                Net = "0",
                Bid = "0",
                Ask = "0"
            });
        }
    }
}
