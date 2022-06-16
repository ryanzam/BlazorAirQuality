using BlazorAirQuality.DTOs;
using System.Net.Http;
using System.Net.Http.Json;

namespace BlazorAirQuality.Services
{
    public class AQService
    {
        public AQService()
        {

        }

        public async Task<AirQuality[]> GetAllAQ()
        {
            var httpClient = new HttpClient();
            var response = await httpClient.GetFromJsonAsync<Response>("https://api.openaq.org/v2/countries?limit=200&page=1&offset=0&sort=asc&order_by=country");
            return response.Results;
        }
    }
}
