using Microsoft.Extensions.Logging;
using ZXing.Net.Maui.Controls;

//TODO: namen in header bij navigationpages vervangen voor normale nederlandse tekst (is nu filename van de pagina)
//TODO: Flow van PackagesWarehouse naar navigatie, proof of concept bouwen voor het feit dat je alleen mag beginnen als elk pakketje een status heeft (ingeladen of vermist)
namespace BezorgApp
{
	public static class MauiProgram
	{
		public static MauiApp CreateMauiApp()
		{
			var builder = MauiApp.CreateBuilder();
			builder
				.UseMauiApp<App>()
                .UseBarcodeReader()
                .ConfigureFonts(fonts =>
				{
					fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
					fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
				});

#if DEBUG
			builder.Logging.AddDebug();
#endif

			return builder.Build();
		}
	}
}
