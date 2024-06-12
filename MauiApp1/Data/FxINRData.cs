using MarketsIQ.Models.Full;

namespace MarketsIQ.Data
{
    public class FxINRData
    {
        public static IList<INRDataModel> Datas { get; set; } = new List<INRDataModel>();

        static FxINRData ()
        {
            Datas.Add(new INRDataModel
            {
                Symbol = "QR",
                ValueDate = "20-Apr-20",
                Bid = "0",
                Ask = "0",
            });

            Datas.Add(new INRDataModel
            {
                Symbol = "SW",
                ValueDate = "20-Apr-20",
                Bid = "0",
                Ask = "0",
            });

            Datas.Add(new INRDataModel
            {
                Symbol = "Bid",
                ValueDate = "20-Apr-20",
                Bid = "0",
                Ask = "0",
            });

            Datas.Add(new INRDataModel
            {
                Symbol = "Ask",
                ValueDate = "20-Apr-20",
                Bid = "0",
                Ask = "0",
            });
        }
    }
}
