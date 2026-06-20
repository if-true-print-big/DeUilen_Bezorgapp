using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;
using JetBrains.Annotations;

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