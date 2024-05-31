using Test_maui_connection.Models;

namespace Test_maui_connection.TestData
{
    public static class MarketSymbols
    {
        public static IList<MarketSymbol> _MarketSymbols { get; private set; }

        static MarketSymbols()
        {
            _MarketSymbols = new List<MarketSymbol>();

            _MarketSymbols.Add(new MarketSymbol
            {
                Name = "First Symbol Company Test",
                Description = "Bar",
                Type = "Foo",
                ChangePercentage = "0.34",
                Timestamp="22:22:22 PM",
                Price="116.00"
            });

            _MarketSymbols.Add(new MarketSymbol
            {
                Name = "Second",
                Description = "Bar",
                Type = "Foo",
                ChangePercentage = "0.34",
                Timestamp = "22:22:22 PM",
                Price = "116.00"
            });

            _MarketSymbols.Add(new MarketSymbol
            {
                Name = "Third",
                Description = "Bar",
                Type = "Foo",
                ChangePercentage = "0.34",
                Timestamp = "22:22:22 PM",
                Price = "116.00"
            });
        }
    }
}
