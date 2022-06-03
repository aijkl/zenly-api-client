using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aijkl.Zenly.APIClient.Internal;
using Aijkl.Zenly.APIClient.Internal.Protobuf;
using ProtoBuf;

namespace Aijkl.Zenly.APIClient.Clients
{
    public class WidgetClient
    {
        private readonly RestClient _restClient;
        internal WidgetClient(RestClient restClient)
        {
            _restClient = restClient;
        }
        public async Task<UserLocation> FetchUserLocationAsync(string userId, string token)
        {
            if (userId == null) throw new ArgumentNullException(nameof(userId));

            var httpRequestMessage = WidgetRequest.CreateGetRequest($"pincontext/{userId}?preview=0", token);
            var httpResponseMessage = await _restClient.SendRequest(httpRequestMessage).ConfigureAwait(false);
            await using var stream = await httpResponseMessage.Content.ReadAsStreamAsync().ConfigureAwait(false);

            var rootObject = Serializer.Deserialize<Internal.Protobuf.UserLocation>(stream);
            return new UserLocation(userId, rootObject.User.Location.Longitude, rootObject.User.Location.Latitude);
        }
        public async Task<IEnumerable<UserLocation>> FetchUsersLocationAsync(string[] userIds, string token)
        {
            if (userIds == null) throw new ArgumentNullException(nameof(userIds));
            if (userIds.Length != 0) throw new ArgumentException("Value cannot be an empty collection.", nameof(userIds));

            var httpRequestMessage = WidgetRequest.CreateGetRequest($"pincontext/{string.Join(",", userIds)}?preview=0", token);
            var httpResponseMessage = await _restClient.SendRequest(httpRequestMessage).ConfigureAwait(false);
            await using var stream = await httpResponseMessage.Content.ReadAsStreamAsync().ConfigureAwait(false);

            var rootObject = Serializer.Deserialize<UsersLocation>(stream);
            return rootObject.Users.Select(x => new UserLocation(x.UserId,x.Location.Longitude,x.Location.Latitude));
        }
    }
}