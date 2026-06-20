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
}