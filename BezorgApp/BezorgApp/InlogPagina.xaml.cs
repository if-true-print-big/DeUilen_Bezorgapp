namespace BezorgApp;

public partial class InlogPagina : ContentPage
{
    public InlogPagina()
    {
        InitializeComponent();
    }

        private void Input_TextChanged(object sender, TextChangedEventArgs e)
    {
        bool veldenGevuld =
            !string.IsNullOrWhiteSpace(GebruikersnaamEntry.Text) &&
            !string.IsNullOrWhiteSpace(WachtwoordEntry.Text);

        InlogKnop.IsEnabled = veldenGevuld;
    }

} 