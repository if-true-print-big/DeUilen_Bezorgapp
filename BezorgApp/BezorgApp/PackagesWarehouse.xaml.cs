namespace BezorgApp;

public partial class PackagesWarehouse : ContentPage
{
	public PackagesWarehouse()
	{
		InitializeComponent();
	}

	private async void ScannerPage(object sender, EventArgs e)
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

    private async void AdressenTapped(object sender, TappedEventArgs e)
    {
		await Navigation.PushAsync(new Adressen());
	}

	private async void ToOnePackageDemo(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new OnePackageDemo());
	}
	private async void ToOnePackage(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new OnePackage());
	}
}