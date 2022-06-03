using System;
using Aijkl.Zenly.APIClient.Clients;
using Aijkl.Zenly.APIClient.Internal;

namespace Aijkl.Zenly.APIClient
{
    public class ZenlyApiClient : IDisposable
    {
        private RestClient _restClient;
        public ZenlyApiClient()
        {
            _restClient = new RestClient();
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