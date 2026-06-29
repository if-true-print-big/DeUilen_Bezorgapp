namespace BezorgApp;
using Microsoft.Maui.Storage;
using Microsoft.Maui.Media;
public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }
    

	private async void StartClicked(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new PackagesWarehouse());
	}

    private async void HomeTapped(object sender, TappedEventArgs e)
    {
        // Staat al op home
    }

    private async void KaartTapped(object sender, EventArgs e)
    {
		await Navigation.PushAsync(new Navigatie());
	}

    private async void AdressenTapped(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Adressen());
    }
}