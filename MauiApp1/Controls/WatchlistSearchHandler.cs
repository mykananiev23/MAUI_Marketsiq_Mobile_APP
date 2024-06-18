using MarketsIQ.Models.Market;
using MarketsIQ.Services.Quantower.API.Client.Models;

namespace MarketsIQ.Controls
{
    internal class WatchlistSearchHandler: SearchHandler
    {
        public static readonly BindableProperty ListMainModelsProperty =
        BindableProperty.Create(nameof(ListMainModels), typeof(IList<QInstrument>), typeof(WatchlistSearchHandler), default(IList<QInstrument>));
        public IList<QInstrument> ListMainModels
        {
            get => (IList<QInstrument>)GetValue(ListMainModelsProperty);
            set => SetValue(ListMainModelsProperty, value);
        }

        public Type SelectedItemNavigationTarget { get; set; }

        protected override void OnQueryChanged(string oldValue, string newValue)
        {
            base.OnQueryChanged(oldValue, newValue);

            if (ListMainModels == null)
            {
                return;
            }

            if (string.IsNullOrWhiteSpace(newValue))
            {
                ItemsSource = null;
            }
            else
            {
                ItemsSource = ListMainModels
                    .Where(symbol => symbol.Name.ToLower().Contains(newValue.ToLower()))
                    .ToList();
            }
        }
    }
}
