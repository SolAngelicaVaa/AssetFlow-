namespace T2_App
{
    public partial class NewAssetPage : ContentPage
    {
        public NewAssetPage()
        {
            InitializeComponent();
        }

        private async void OnSaveClicked(object sender, EventArgs e)
        {
            // Enkel validering
            if (string.IsNullOrWhiteSpace(AssetNameEntry.Text))
            {
                await DisplayAlert("Feil", "Vennligst oppgi et navn på utstyret.", "OK");
                return;
            }

            // Her kan du legge til logikk for å lagre i databasen senere
            string name = AssetNameEntry.Text;
            string location = LocationEntry.Text;

            await DisplayAlert("AssetFlow", $"{name} ble lagret på lokasjon: {location}", "OK");

            // Gå tilbake til Dashboard etter lagring
            await Navigation.PopAsync();
        }
    }
}