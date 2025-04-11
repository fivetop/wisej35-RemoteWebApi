using HybridLocal;
using Microsoft.Extensions.Logging;
using Wisej.Hybrid.Native.Core;

namespace HybridClient
{
	public static class Startup
	{
		public static MauiApp Main()
		{
			var builder = MauiApp.CreateBuilder();
			builder
				.UseMauiApp<App>()
				.ConfigureFonts(fonts =>
				{
					fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
					fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
				})

				 // Uncomment and replace with Offline startup Type to use embedded web server.
				 .UseWisejOffline<OfflineStartup>()

				.UseWisejHybrid((config) =>
				{
					// Uncomment to provide an offline fallback timeout.
					// config.OfflineTimeout = 5000;

					// Provide the startup URL for the Hybrid WebView.
					config.StartupUrl = "http://localhost:5000";
				});

#if DEBUG
		builder.Logging.AddDebug();
#endif

			return builder.Build();
		}
	}
}