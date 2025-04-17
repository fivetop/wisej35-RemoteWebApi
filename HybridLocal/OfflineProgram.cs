using Wisej.Web;

namespace HybridLocal
{
	internal static class Program
	{
		static Program()
		{
            var apiUrl = "https://8snsmzqh-5000.use.devtunnels.ms/";
            Application.Services.AddService<DataRepository>(new DataRepository(apiUrl));
		}

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		static void Main()
		{
			Application.MainPage = new Page1();
		}
	}
}