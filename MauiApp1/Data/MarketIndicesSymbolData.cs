using MarketsIQ.Services.Quantower.API.Client.Models;

namespace MarketsIQ.Data
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
