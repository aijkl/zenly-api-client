using System;
using Aijkl.Zenly.APIClient.Clients;
using Aijkl.Zenly.APIClient.Internal;

namespace Aijkl.Zenly.APIClient
{
    public class ZenlyApiClient : IDisposable
    {
        private readonly RestClient _restClient;
        private bool _disposed;
        public ZenlyApiClient()
        {
            _restClient = new RestClient();
            WidgetClient = new WidgetClient(_restClient);
        }

        public WidgetClient WidgetClient { get; }

        public void Dispose()
        {
            if (!_disposed) return;

            _restClient.Dispose();
            _disposed = true;
        }
    }
}