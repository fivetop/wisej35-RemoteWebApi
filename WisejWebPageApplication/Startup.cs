
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;
using Wisej.Core;

namespace WisejWebPageApplication
{
	/// <summary>
	/// The Startup class configures services and the app's request pipeline.
	/// For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940.
	/// </summary>
	public class Startup
	{
		public Startup(IConfiguration configuration)
		{
			Configuration = configuration;
		}
		public IConfiguration Configuration { get; }

		public static void Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(new WebApplicationOptions
			{
				Args = args,
				WebRootPath = "./"
			});

			var app = builder.Build();
			app.UseWisej();
			app.UseFileServer();

			// Minimal API for .NET Core.
			app.MapGet(("/getValue"), () => DataRepository.GetValue());
			app.MapPut(("/saveValue"), async (context) =>
			{
				var value = context.Request.Form["value"];
				var result = DataRepository.SaveValue(value);
				await context.Response.WriteAsync(result.ToString());
			});

			app.Run();
		}
	}
}
