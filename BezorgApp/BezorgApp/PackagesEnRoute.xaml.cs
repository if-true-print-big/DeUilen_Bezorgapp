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
}