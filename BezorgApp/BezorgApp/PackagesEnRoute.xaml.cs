namespace BezorgApp;

public partial class PackagesEnRoute : ContentPage
{
	public PackagesEnRoute()
	{
		InitializeComponent();
	}

	private async void MapClicked(object sender, EventArgs e)
	{
		await Navigation.PopAsync();
	}

	private async void ScanClicked(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new ScannerPagina());
	}

    private async void HomeTapped(object sender, TappedEventArgs e)
    {
        await Navigation.PushAsync(new MainPage());
    }

    private async void KaartTapped(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Navigatie());
    }

    private void AdressenTapped(object sender, TappedEventArgs e)
    {

    }
}