using Zenly.APIClient.Internal;

namespace Zenly.APIClient.Clients
{
    public class WidgetClient
    {
        private RestClient _restClient;
        internal WidgetClient(RestClient restClient)
        {
            _restClient = restClient;
        }

    }
}
