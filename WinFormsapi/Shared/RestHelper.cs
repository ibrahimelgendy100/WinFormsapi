using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsapi.Shared
{
	public static class RestHelper
	{
		private static readonly string baseURL = "http://khabir_api_backend.saskw.net/api/";
		public static async Task<string> GetAll()
		{
			using (HttpClient client = new HttpClient())
			{
				using (HttpResponseMessage res = await client.GetAsync(baseURL + "v1ItemRoute/GetAllItem"))
				{
					using(HttpContent content = res.Content)
					{
						string data = await content.ReadAsStringAsync();
						if (data !=null)
						{
							return data;
						}
					}
				}
			}
			return string.Empty;
		}
		public static string formatjson(string jsonstr)
		{
			JToken parsJson = JToken.Parse(jsonstr);
			return parsJson.ToString(Formatting.Indented);
		}
	}
}
