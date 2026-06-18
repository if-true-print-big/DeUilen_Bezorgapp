using ZXing.Net.Maui.Controls;

namespace BezorgApp;

public partial class ScannerPagina : ContentPage
{
	public ScannerPagina()
	{
		InitializeComponent();
        cameraBarcodeReaderView.Options = new ZXing.Net.Maui.BarcodeReaderOptions
        {
            Formats = ZXing.Net.Maui.BarcodeFormat.Ean13, // Set to recognize EAN-13 barcodes
            AutoRotate = true, // Automatically rotate the image to detect barcodes from different angles
            Multiple = true // Allow the detection of multiple barcodes at once
        };

    }


    protected void BarcodesDetected(object sender, ZXing.Net.Maui.BarcodeDetectionEventArgs e)
    {
        var first = e.Results?.FirstOrDefault();
        if (first is null)
        {
            return;
        }

        Dispatcher.DispatchAsync(async () =>
        {
            await DisplayAlert("Barcode Detected", first.Value, "OK");
        });
    }
}