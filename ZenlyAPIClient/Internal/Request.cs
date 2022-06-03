using System;
using System.Text;
using System.Net.Http;

namespace Aijkl.Zenly.APIClient
{
    internal static class WidgetRequest
    {
        internal static readonly string BaseUrl = "https://api.znly.co/widgets";
        internal static readonly string UserAgent = "WidgetsExtension/220214183253 CFNetwork/1331.0.7 Darwin/21.4.0";
        internal static HttpRequestMessage CreateGetRequest(string verb, string token)
        {
            var httpRequestMessage = CreateDefaultRequest(token);
            httpRequestMessage.Method = HttpMethod.Get;
            httpRequestMessage.RequestUri = new Uri($"{BaseUrl}/{verb}");
            return httpRequestMessage;
        }
        internal static HttpRequestMessage CreatePostRequest(string verb, string body, string token)
        {
            var httpRequestMessage = CreateDefaultRequest(token);
            httpRequestMessage.Method = HttpMethod.Post;
            httpRequestMessage.RequestUri = new Uri($"{BaseUrl}/{verb}");
            httpRequestMessage.Content = new StringContent(body, Encoding.UTF8, "application/x-www-form-urlencoded");
            return httpRequestMessage;
        }
        internal static HttpRequestMessage CreateDefaultRequest(string token)
        {
            var httpRequestMessage = new HttpRequestMessage();
            httpRequestMessage.Headers.Add("Connection", "keep-alive");
            httpRequestMessage.Headers.Add("Accept", "*/*");
            httpRequestMessage.Headers.Add("User-Agent", UserAgent);
            httpRequestMessage.Headers.Add("Accept-Language", "ja-jp");
            httpRequestMessage.Headers.Add("Authorization", $"Token {token}");
            return httpRequestMessage;
        }
    }
}