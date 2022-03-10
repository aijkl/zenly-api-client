using System;
using Zenly.APIClient.Clients;
using Zenly.APIClient.Internal;

namespace Zenly.APIClient
{
    public class ZenlyAPIClient : IDisposable
    {
        private RestClient _restClient;
        public ZenlyAPIClient(string token)
        {
            _restClient = new RestClient(token);
            WidgetClient = new WidgetClient(_restClient);
        }

        public WidgetClient WidgetClient { get; }

        public void Dispose()
        {
            _restClient?.Dispose();
            _restClient = null;
        }
    }
}