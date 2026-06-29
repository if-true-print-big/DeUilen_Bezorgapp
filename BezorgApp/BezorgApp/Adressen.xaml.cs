namespace BezorgApp;

public partial class Adressen : ContentPage
{
	public Adressen()
	{
		InitializeComponent();
	}
    private async void OnAdres1Tapped(object sender, TappedEventArgs e)
    {
        await Navigation.PushAsync(new PackagesEnRoute());
    }
    private async void OnAdres2Tapped(object sender, TappedEventArgs e)
    {
        await Navigation.PushAsync(new Adres2());
    }
    private async void OnAdres3Tapped(object sender, TappedEventArgs e)
    {
        await Navigation.PushAsync(new Adres3());
    }
    private async void OnAdres4Tapped(object sender, TappedEventArgs e)
    {
        await Navigation.PushAsync(new Adres4());
    }
}