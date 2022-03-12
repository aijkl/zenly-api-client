using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace Aijkl.Zenly.APIClient.Internal
{
    internal class RestClient : IDisposable
    {
        private HttpClient _httpClient;
        internal RestClient(string token)
        {
            if (string.IsNullOrEmpty(token))
            {
                throw new ArgumentException("token is null or empty");
            }

            var httpClientHandler = new HttpClientHandler();
            httpClientHandler.AutomaticDecompression = DecompressionMethods.All;
            httpClientHandler.UseCookies = true;
            _httpClient = new HttpClient(httpClientHandler); 
            _httpClient.DefaultRequestHeaders.Add("Authorization",$"Token {token}");
        }
        internal async Task<HttpResponseMessage> SendRequest(HttpRequestMessage httpRequestMessage, HttpCompletionOption httpCompletionOption = HttpCompletionOption.ResponseContentRead, bool readToken = false)
        {
            var httpResponseMessage = await _httpClient.SendAsync(httpRequestMessage, httpCompletionOption);
            if (httpResponseMessage.StatusCode != HttpStatusCode.OK)
            {
                throw new ZenlyApiException(httpResponseMessage.StatusCode, httpResponseMessage);
            }
            return httpResponseMessage;
        }
        public void Dispose()
        {
            _httpClient?.Dispose();
            _httpClient = null;
        }
    }
}
