using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace Aijkl.Zenly.APIClient.Internal
{
    internal class RestClient : IDisposable
    {
        private readonly HttpClient _httpClient;
        private bool _disposed;
        internal RestClient()
        {
            var httpClientHandler = new HttpClientHandler();
            httpClientHandler.AutomaticDecompression = DecompressionMethods.All;
            httpClientHandler.UseCookies = true;
            _httpClient = new HttpClient(httpClientHandler);
        }
        internal async Task<HttpResponseMessage> SendRequest(HttpRequestMessage httpRequestMessage, HttpCompletionOption httpCompletionOption = HttpCompletionOption.ResponseContentRead, bool readToken = false)
        {
            var httpResponseMessage = await _httpClient.SendAsync(httpRequestMessage, httpCompletionOption).ConfigureAwait(false);
            if (httpResponseMessage.StatusCode != HttpStatusCode.OK)
            {
                throw new ZenlyApiException(httpResponseMessage.StatusCode, httpResponseMessage);
            }
            return httpResponseMessage;
        }
        public void Dispose()
        {
            if (!_disposed) return;

            _httpClient.Dispose();
            _disposed = true;
        }
    }
}
