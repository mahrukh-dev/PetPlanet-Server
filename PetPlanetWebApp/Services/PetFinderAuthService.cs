using Newtonsoft.Json;
using PetPlanetWebApp.Models;

namespace PetPlanetWebApp.Services
{
    public class PetFinderAuthService
    {
        HttpClient httpClient = new HttpClient();

        public async Task<string> GetAccessTokenAsync()
        {
            var content = new FormUrlEncodedContent(new[]
            {
            new KeyValuePair<string, string>("grant_type", "client_credentials"),
            new KeyValuePair<string, string>("client_id", "RHmQ6jm0N86spTP0xwe7s6QstXY9fIV1hYfWOyWcZm05fGszk5"),
            new KeyValuePair<string, string>("client_secret", "WuP6QNSHiEfEsRexSqj7FrWKK4wQ37iKqXB4eSUp")
            });

            HttpResponseMessage response = await httpClient.PostAsync("https://api.petfinder.com/v2/oauth2/token", content);

            if (response.IsSuccessStatusCode)
            {
                string responseContent = await response.Content.ReadAsStringAsync();
                var tokenResponse = JsonConvert.DeserializeObject<TokenResponse>(responseContent);
                return tokenResponse.AccessToken;
            }
            else
            {
                throw new HttpRequestException($"Error: {response.StatusCode}");
            }
        }
    }
}
