using Foundation;
using Wisej.Hybrid.Native;

namespace HybridClient
{
	[Register("AppDelegate")]
	public class AppDelegate : HybridUIApplicationDelegate
	{
		protected override MauiApp CreateMauiApp() => Startup.Main();
	}
}