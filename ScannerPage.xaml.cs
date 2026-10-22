namespace T2_App
{
    public partial class ScannerPage : ContentPage
    {
        public ScannerPage()
        {
            InitializeComponent();
        }

        private async void OnSimulateScanClicked(object sender, EventArgs e)
        {
            await DisplayAlert("Asset Funnet!", "Du skannet: MacBook Pro 16", "OK");
            await Shell.Current.GoToAsync("..");
        }
    }
}