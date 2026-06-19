namespace BezorgApp;

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

    private void KaartTapped(object sender, TappedEventArgs e)
    {
        // Kaart page
    }

    private void AdressenTapped(object sender, TappedEventArgs e)
    {
        // Adressen page
    }
}