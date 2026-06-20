namespace BezorgApp;
using Microsoft.Maui.Storage;
using Microsoft.Maui.Media;
public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }
    private void HomeTapped(object sender, TappedEventArgs e)
    {
        DisplayAlertAsync("ok","ok","123");
        // Home page
    }

	private void StartClicked(object sender, TappedEventArgs e)
	{
		//
	}

	private void KaartTapped(object sender, TappedEventArgs e)
    {
        // Kaart page
    }

    private void AdressenTapped(object sender, TappedEventArgs e)
    {
        // Adressen page
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