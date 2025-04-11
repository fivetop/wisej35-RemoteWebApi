using Wisej.Hybrid.Native.Controls;

namespace HybridClient
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();

			MainPage = new HybridShell();
		}
	}
}