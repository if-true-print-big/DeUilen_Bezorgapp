namespace BezorgApp;

public partial class PackagesEnRoute : ContentPage
{
	public PackagesEnRoute()
	{
		InitializeComponent();
	}

	private async void MapClicked(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new Navigatie());
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

    private async void AdressenTapped(object sender, TappedEventArgs e)
    {
		await Navigation.PushAsync(new Adressen());
	}

	private async void ToOnePackageDemo(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new OnePackageDemo());
	}

	private async void MaakFoto_Clicked(object sender, EventArgs e)
	{
		if (MediaPicker.Default.IsCaptureSupported)
		{
			FileResult photo = await MediaPicker.Default.CapturePhotoAsync();

			if (photo != null)
			{
				var stream = await photo.OpenReadAsync();
				await DisplayAlertAsync("Succes",
					$"Foto gemaakt: {photo.FileName}",
					"OK");
				FotoPreview.Source = ImageSource.FromStream(() => stream);
			}
		}
	}
	private async void KiesFoto_Clicked(object sender, EventArgs e)
	{
		FileResult photo = await MediaPicker.Default.PickPhotoAsync();

		if (photo != null)
		{
			var stream = await photo.OpenReadAsync();
			await DisplayAlertAsync("Succes",
					$"Foto gekozen: {photo.FileName}",
					"OK");
			FotoPreview.Source = ImageSource.FromStream(() => stream);
		}
	}

	//wordt niet gebruikt omdat hij niet functioneert.
	private async void KiesBestand_Clicked(object sender, EventArgs e)
	{
		FileResult file = await FilePicker.Default.PickAsync();

		if (file != null)
		{
			await DisplayAlertAsync("Bestand gekozen",
				file.FileName,
				"OK");
		}
	}
}