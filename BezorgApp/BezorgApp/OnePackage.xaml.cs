namespace BezorgApp;

public partial class OnePackage : ContentPage
{
	public OnePackage()
	{
		InitializeComponent();
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
}