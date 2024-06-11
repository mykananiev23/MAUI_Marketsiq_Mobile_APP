using Quantower.API.Client.Models;

namespace MauiApp1.Data
{
    public class MarketIndicesSymbolData
    {
        public static IList<QInstrument> Symbols { get; set; }

        static MarketIndicesSymbolData()
        {
            InitializeSymbols();
        }

        static void InitializeSymbols()
        {
            Symbols.Add(new QInstrument
            {

            });
        }
    }
}
