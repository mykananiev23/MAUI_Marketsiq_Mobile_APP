using Test_maui_connection.Models;

namespace Test_maui_connection.TestData
{
    public static class Symbols
    {
        public static IList<Symbol> MarketSymbols { get; private set; }

        static Symbols()
        {
            MarketSymbols = new List<Symbol>();

            MarketSymbols.Add(new Symbol
            {
                Name = "First",
                Description = "Bar",
                Type = "Foo",
            });

            MarketSymbols.Add(new Symbol
            {
                Name = "Second",
                Description = "Bar",
                Type = "Foo",
            });

            MarketSymbols.Add(new Symbol
            {
                Name = "Third",
                Description = "Bar",
                Type = "Foo",
            });
        }
    }
}
