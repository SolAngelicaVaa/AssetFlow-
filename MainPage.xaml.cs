using System.Collections.ObjectModel;

namespace T2_App
{
    public class Asset
    {
        public string Name { get; set; }
        public string Icon { get; set; }
        public string StatusText { get; set; }
        public Color StatusColor { get; set; }
    }

    public partial class MainPage : ContentPage
    {
        public ObservableCollection<Asset> Assets { get; set; }

        public MainPage()
        {
            InitializeComponent();
            Assets = new ObservableCollection<Asset>
            {
                new Asset { Name = "MacBook Pro 16", Icon = "💻", StatusText = "Status: Tilgjengelig", StatusColor = Colors.Green },
                new Asset { Name = "Firmabil (EL-45678)", Icon = "🚗", StatusText = "Status: I bruk", StatusColor = Colors.Red }
            };
            BindingContext = this;
        }

        private async void OnScannerClicked(object sender, EventArgs e) => await Shell.Current.GoToAsync("ScannerPage");
        private async void OnRegisterNewClicked(object sender, EventArgs e) => await Shell.Current.GoToAsync("NewAssetPage");
    }
}