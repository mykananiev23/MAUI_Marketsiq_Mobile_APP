using MauiApp1.Models.Market;
using Quantower.API.Client.Models;

namespace MauiApp1.Controls
{
    public class MarketSearchHandler : SearchHandler
    {
        public List<ListMainModel> ListMainModels { get; set; }

        //public Type SelectedItemNavigationTarget { get; set; }

        //protected override void OnQueryChanged(string oldValue, string newValue)
        //{
        //    base.OnQueryChanged(oldValue, newValue);

        //    if (string.IsNullOrWhiteSpace(newValue))
        //    {
        //        ItemsSource = null;
        //    }
        //    else
        //    {
        //        ItemsSource = ListMainModels
        //            .Where(symbol => symbol.Instrument.Name.ToLower().Contains(newValue.ToLower()))
        //            .ToList<ListMainModel>();
        //    }
        //}

        //protected override async void OnItemSelected(object item)
        //{
        //    base.OnItemSelected(item);

        //    QInstrument instrument = item as QInstrument;
        //    string navigationTarget = GetNavigationTarget();

        //    if (navigationTarget.Equals("catdetails") || navigationTarget.Equals("dogdetails"))
        //    {
        //        // Navigate, passing a string
        //        await Shell.Current.GoToAsync($"{navigationTarget}?name={((QInstrument)item).Name}");
        //    }
        //    else
        //    {
        //        string lowerCasePropertyName = navigationTarget.Replace("details", string.Empty);
        //        // Capitalise the property name
        //        string propertyName = char.ToUpper(lowerCasePropertyName[0]) + lowerCasePropertyName.Substring(1);

        //        var navigationParameters = new Dictionary<string, object>
        //        {
        //            { propertyName, instrument }
        //        };

        //        // Navigate, passing an object
        //        await Shell.Current.GoToAsync($"{navigationTarget}", navigationParameters);
        //    }
        //}

        //string GetNavigationTarget()
        //{
        //    return (Shell.Current as AppShell).Routes.FirstOrDefault(route => route.Value.Equals(SelectedItemNavigationTarget)).Key;
        //}
    }
}
