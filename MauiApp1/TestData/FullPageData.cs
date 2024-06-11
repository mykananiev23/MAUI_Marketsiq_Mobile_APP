namespace MauiApp1.TestData
{
    public class TableInfo
    {
        public string SymbolName { get; set; }
        public string ValueDate { get; set; }
        public string Bid { get; set; }
        public string Ask { get; set; }
    }
    public class FullPageData
    {
        public static IList<TableInfo> TestTableData { get; set; } = new List<TableInfo>();
        public static TableInfo Thead { get; set; }

        static FullPageData()
        {
            Thead = new TableInfo
            {
                ValueDate = "ValueDate",
                Ask = "Ask",
                Bid = "Bid",
                SymbolName = "SymbolName"
            };

            TestTableData.Add(Thead);
            TestTableData.Add(new TableInfo
            {
                SymbolName = "Symbol1",
                Ask = "0.15",
                Bid = "0.16",
                ValueDate = "20-Apr-2021"
            });
            TestTableData.Add(new TableInfo
            {
                SymbolName = "Symbol1",
                Ask = "0.15",
                Bid = "0.16",
                ValueDate = "20-Apr-2021"
            });
            TestTableData.Add(new TableInfo
            {
                SymbolName = "Symbol1",
                Ask = "0.15",
                Bid = "0.16",
                ValueDate = "20-Apr-2021"
            });
            TestTableData.Add(new TableInfo
            {
                SymbolName = "Symbol1",
                Ask = "0.15",
                Bid = "0.16",
                ValueDate = "20-Apr-2021"
            });
        }
    }
}
