using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using tcortega.AuthGG.Client.DTOs;
using tcortega.AuthGG.Client.Exceptions;
using tcortega.AuthGG.Client.Utilities;

namespace tcortega.AuthGGClient
{
    public class AuthGGClient
    {
        private static string _baseUrl = "https://api.auth.gg/v1/";
        private static string _certificatePKey = "04D9F7C0C68DA3FDE380C3BBE2F87D09BB546B7DE5254DEAC4DC2DCA4A612A83585431E98B49A91A6D854D1128C133E92D5A6BFED12EF5043FF6AC5E77973135E6";
        private HttpClient _httpClient;
        private string _aid;
        private string _apiKey;
        private string _secret;

        private AuthGGClient(string aid, string apiKey, string secret, HttpClient httpClient)
        {
            _httpClient = httpClient;
            _aid = aid;
            _apiKey = apiKey;
            _secret = secret;
        }

        public static AuthGGClient Create(string aid, string apiKey, string secret)
        {
            if (!AuthUtils.IsValidAuthData(aid, apiKey, secret))
                throw new InvalidAuthDataException();

            var handler = new HttpClientHandler
            {
                ClientCertificateOptions = ClientCertificateOption.Manual,
                ServerCertificateCustomValidationCallback = (httpRequestMessage, cert, cetChain, policyErrors) =>
                {
                    return cert.GetPublicKeyString() == _certificatePKey;
                }
            };

            var httpClient = new HttpClient(handler);

            return new AuthGGClient(aid, apiKey, secret, httpClient);
        }

        public async Task<AppInfo> GetAppInfoAsync()
        {
            var requestData = new AppInfoPayload
            {
                Type = "info",
                Aid = _aid,
                Secret = _secret,
                ApiKey = _apiKey
            };

            using var content = new FormUrlEncodedContent(requestData.GetUrlEncodedQuery());
            using var response = await _httpClient.PostAsync(_baseUrl, content);

            var appInfoResponse = await response.Content.ReadFromJsonAsync<AppInfo>();
            // Validation needed since API returns Status 200 for everything, even errors... :(
            if (!appInfoResponse.IsSuccess)
                throw new InvalidAuthDataException(appInfoResponse.Message);

            return appInfoResponse;
        }

        public async Task<LoginResponse> LoginAsync(string username, string password, string hwid)
        {
            var requestData = new LoginPayload
            {
                Type = "login",
                Aid = _aid,
                ApiKey = _apiKey,
                Secret = _secret,
                Username = username,
                Password = password,
                Hwid = hwid
            };

            using var content = new FormUrlEncodedContent(requestData.GetUrlEncodedQuery());
            using var response = await _httpClient.PostAsync(_baseUrl, content);

            return await response.Content.ReadFromJsonAsync<LoginResponse>();
        }

        public async Task<LoginResponse> RegisterAsync(string username, string password, string email, string license, string hwid)
        {
            var requestData = new LoginPayload
            {
                Type = "register",
                Aid = _aid,
                ApiKey = _apiKey,
                Secret = _secret,
                Username = username,
                Password = password,
                Hwid = hwid
            };

            using var content = new FormUrlEncodedContent(requestData.GetUrlEncodedQuery());
            using var response = await _httpClient.PostAsync(_baseUrl, content);

            return await response.Content.ReadFromJsonAsync<LoginResponse>();
        }
    }
}
