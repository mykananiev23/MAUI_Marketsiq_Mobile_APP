using LiveChartsCore;
using LiveChartsCore.SkiaSharpView;
using SkiaSharp;

namespace Test_maui_connection
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
            UserAppTheme = AppTheme.Light;
            base.OnStart();
            LiveCharts.Configure(config =>
            config.HasMap<City>((city, index) => new(index, city.Population)));
        }

        public record City(string Name, double Population);
    }
}
