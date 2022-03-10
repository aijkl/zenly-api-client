using System;
using System.Threading.Tasks;
using ProtoBuf;
using Zenly.APIClient.Internal;
using Zenly.APIClient.Internal.Protobuf;

namespace Zenly.APIClient.Clients
{
    public class WidgetClient
    {
        private readonly RestClient _restClient;
        internal WidgetClient(RestClient restClient)
        {
            _restClient = restClient;
        }

        public async Task<UserLocationWidget> FetchLocation(string userId)
        {
            if (userId == null) throw new ArgumentNullException(nameof(userId));

            var httpRequestMessage = WidgetRequest.CreateGetRequest($"/pincontext/{userId}?preview=0");
            var httpResponseMessage = await _restClient.SendRequest(httpRequestMessage);
            await using var stream = await httpResponseMessage.Content.ReadAsStreamAsync();

            RootObject rootObject = Serializer.Deserialize<RootObject>(stream);
            return new UserLocationWidget
            {
                UserId = userId,
                Latitude = rootObject.Child1.Child2.Latitude,
                Longitude = rootObject.Child1.Child2.Longitude
            };
        }
    }
}
