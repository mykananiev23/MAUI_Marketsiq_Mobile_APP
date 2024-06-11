using MauiApp1.Models.Full;

namespace MauiApp1.Data
{
    public class CurrencyData
    {
        public static IList<CurrencyModel> Datas { set; get; } = new List<CurrencyModel>();

        static CurrencyData()
        {
            Datas.Add(new CurrencyModel
            {
                Code = "$",
                Title = "USD"
            });

            Datas.Add(new CurrencyModel
            {
                Code = "$",
                Title = "EUR"
            });

            Datas.Add(new CurrencyModel
            {
                Code = "$",
                Title = "GBP"
            });

            Datas.Add(new CurrencyModel
            {
                Code = "$",
                Title = "JPY"
            });
        }
    }
}
