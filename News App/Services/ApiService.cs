using News_App.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace News_App.Services
{
	public class ApiService 
	{
		public async Task<Root> GetNews(String categoryName)
		{
			var httpClient = new HttpClient();
			var response = await httpClient.GetStringAsync($"https://gnews.io/api/v4/top-headlines?category=general&lang=zh&country=tw&max=10&apikey=d4cff1762fa6f1d6b5a3a5dd2f4bf6fe");
            return JsonConvert.DeserializeObject<Root>(response);
        }
	}
}