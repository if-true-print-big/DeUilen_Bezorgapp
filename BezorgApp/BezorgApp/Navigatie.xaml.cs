namespace BezorgApp;

public partial class Navigatie : ContentPage
{
	public Navigatie()
	{
		InitializeComponent();
		GetLocation();
	}

	private async void PackagesClicked(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new PackagesEnRoute());
	}

    private async void HomeTapped(object sender, TappedEventArgs e)
    {
        await Navigation.PushAsync(new MainPage());
    }

    private async void KaartTapped(object sender, EventArgs e)
    {
        // Staat al op navigatie
    }

    private void AdressenTapped(object sender, TappedEventArgs e)
    {

    }

	private async void GetLocation()
	{
		GeolocationRequest request = new GeolocationRequest(GeolocationAccuracy.Medium, TimeSpan.FromSeconds(10));
		Location location = await Geolocation.Default.GetLocationAsync(request);
		string coordinates = "";
		coordinates += "Breedtegraad ";
		coordinates += location.Latitude.ToString();
		coordinates += " Lengtegraad ";
		coordinates += location.Longitude.ToString();
		locationlabel.Text = coordinates;
	}
}