using Zenly.APIClient.Clients;
using Zenly.APIClient.Internal;

namespace Zenly.APIClient
{
    public class ZenlyAPIClient
    {
        private RestClient _restClient;
        public ZenlyAPIClient(string token)
        {
            _restClient = new RestClient(token);
            WidgetClient = new WidgetClient(_restClient);
        }

        public WidgetClient WidgetClient { get; }
    }
}