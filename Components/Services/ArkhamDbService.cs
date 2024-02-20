using CardsDbApp.Models;

namespace CardsDbApp.Services
{
    public class ArkhamDbService: IArkhamDbService
    {
        private HttpClient _client;

        public ArkhamDbService()
        {
            _client = new HttpClient();

            _client.BaseAddress = new Uri("https://arkhamdb.com/api/public/");
            _client.DefaultRequestHeaders.Accept.Add(new("application/json"));
        }
        public async Task<ArkhamDbApiResponse?> GetCardObject(string code)
        {
            var response = await _client.GetFromJsonAsync<ArkhamDbApiResponse>($"card/{code}");
            return response;
        }
    
    }
}