using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace HybridLocal
{
	internal class DataRepository
	{
		private readonly HttpClient _httpClient;
		private readonly UriBuilder _apiBaseUri = null;

		public DataRepository(string apiUrl) 
		{ 
			this._httpClient = new HttpClient();
			this._apiBaseUri = new UriBuilder(apiUrl);
		}

		public async Task<bool> SaveValue(string value)
		{
			var content = new FormUrlEncodedContent(new[]
			{
				new KeyValuePair<string, string>("value", value),
			});

			this._apiBaseUri.Path = "saveValue";
			var result = await this._httpClient.PutAsync(this._apiBaseUri.Uri, content);
			var textResult = await result.Content.ReadAsStringAsync();

			return bool.Parse(textResult);
		}

		public async Task<string> GetValue()
		{
			this._apiBaseUri.Path = "getValue";
			return await this._httpClient.GetStringAsync(this._apiBaseUri.Uri);
		}
	}
}
