using IdentityModel.Client;

namespace BookStoreConsole
{
    public class HttpService
    {
        public async Task<Lazy<HttpClient>> GetHttpClientAsync(bool setBearerToken, string apiEndpoint)
        {
            var client = new Lazy<HttpClient>(() => new HttpClient());

            if (true) client.Value.SetBearerToken(await GetAccessToken(apiEndpoint));

            client.Value.BaseAddress = new Uri(apiEndpoint);



            return await Task.FromResult(client);
        }

        private static async Task<TokenResponse> GetTokensFromApi(string apiEndpoint)
        {
            var discoveryCache = new DiscoveryCache(apiEndpoint);
            var disco = await discoveryCache.GetAsync();
            var httpClient = new Lazy<HttpClient>(() => new HttpClient());
            var response = await httpClient.Value.RequestPasswordTokenAsync(new PasswordTokenRequest
            {
                Address = disco.TokenEndpoint, // apiEndpoint/connect/token
                //ClientId = "CSAM_Service",
                //ClientSecret = "1q2w3e*",
                //UserName = "Zp0vEuWTmWHZktVQisWqOQ==",
                //Password = "5SGqPgEptwIsZWB5GFlSXg==*",
                UserName = "STR-APIUser",
                Password = "OCRstrsandbox",
                //Scope = "openid offline_access address email phone profile roles AssetTracker",
            });
            return response.IsError ? new TokenResponse() : response;
        }
        private static async Task<string> GetAccessToken(string apiEndpoint) => (await GetTokensFromApi(apiEndpoint)).AccessToken;
    }
}