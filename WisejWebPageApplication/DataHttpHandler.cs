using System.Web;

namespace WisejWebPageApplication
{
	class DataHttpHandler : IHttpHandler
	{
		bool IHttpHandler.IsReusable => true;

		void IHttpHandler.ProcessRequest(HttpContext context)
		{
			switch (context.Request.Path)
			{
				case "/getValue":
					context.Response.Write(DataRepository.GetValue());
					break;

				case "/saveValue":
					var value = context.Request.Form["value"];
					context.Response.Write(DataRepository.SaveValue(value));
					break;
			}
		}
	}
}
