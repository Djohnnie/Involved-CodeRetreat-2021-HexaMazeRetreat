using HexaMazeRetreat.Domain.Contracts;
using RestSharp;
using System.Threading.Tasks;

namespace HexaMazeRetreat.Solution
{
    public class ApiClient
    {
        private readonly RestClient _client = new RestClient("https://hexamazeretreat.azurewebsites.net/_api");

        public async Task<GetLevelByNameResponse> GetLevelByName(string levelName)
        {
            var request = new RestRequest($"levels/{levelName}", Method.GET);

            var response = await _client.ExecuteAsync<GetLevelByNameResponse>(request);

            return response.Data;
        }

        public async Task CreatePlay(CreatePlayRequest createPlayRequest, string levelName)
        {
            var request = new RestRequest($"plays/{levelName}", Method.POST);

            request.AddJsonBody(createPlayRequest);

            var response = await _client.ExecuteAsync(request);
        }

    }
}