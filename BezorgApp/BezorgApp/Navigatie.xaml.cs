namespace BezorgApp;

public partial class Navigatie : ContentPage
{
	public Navigatie()
	{
		InitializeComponent();
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
}