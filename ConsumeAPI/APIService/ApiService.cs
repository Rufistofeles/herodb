using ConsumeAPI.Models;
using Newtonsoft.Json;
using RestSharp;

namespace ConsumeAPI.APIService
{
	public interface IAPIService
	{
		Task<ResponseByIdAPI> SearchById(string Id);
		Task<ResponseByNameAPI> SearchByName(string Name);
	}
	public class ApiService : IAPIService
	{
		public ApiService()
		{
		}

		public async Task<ResponseByNameAPI> SearchByName(string Name)
		{
			string ApiKey = "5135413703147385";

			var client = new RestClient($"https://superheroapi.com/api/{ApiKey}/search/{Name}")
			{
				Timeout = -1
			};
			var request = new RestRequest(Method.GET);
			IRestResponse response = await client.ExecuteAsync(request);
			
			if(response.IsSuccessful)
			{
				try
				{
					var results = JsonConvert.DeserializeObject<ResponseByNameAPI>(response.Content);

					return results;
				}
				catch(Exception ex)
				{
					string msg = ex.Message;
					return null;
				}				
			}
			else
			{
				return null;
			}
		}

		public async Task<ResponseByIdAPI> SearchById(string Id)
		{
			string ApiKey = "5135413703147385";

			var client = new RestClient($"https://superheroapi.com/api/{ApiKey}/{Id}")
			{
				Timeout = -1
			};
			var request = new RestRequest(Method.GET);
			IRestResponse response = await client.ExecuteAsync(request);

			if (response.IsSuccessful)
			{
				try
				{
					var results = JsonConvert.DeserializeObject<ResponseByIdAPI>(response.Content);

					return results;
				}
				catch (Exception ex)
				{
					string msg = ex.Message;
					return null;
				}
			}
			else
			{
				return null;
			}
		}
	}
}
