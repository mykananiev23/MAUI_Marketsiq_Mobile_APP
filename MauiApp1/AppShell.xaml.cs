using MarketsIQ.Views.Market;

namespace MarketsIQ
{
    public partial class AppShell : Shell
    {
        public Dictionary<string, Type> Routes { get; private set; } = new Dictionary<string, Type>();
        public AppShell()
        {
            InitializeComponent();
            RegisterRoutes();
            BindingContext = this;
        }

        void RegisterRoutes()
        {
            Routes.Add("MarketDetail", typeof(MarketDetail));
            //Routes.Add("WatchlistDetail", typeof());

            foreach(var item in Routes)
            {
                Routing.RegisterRoute(item.Key, item.Value);
            }
        }
    }
}
