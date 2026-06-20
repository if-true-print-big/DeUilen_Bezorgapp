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
}