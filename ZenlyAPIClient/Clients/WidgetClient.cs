using System;
using System.Collections.Generic;
using System.Linq;
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
        public async Task<UserLocation> FetchUserLocation(string userId)
        {
            if (userId == null) throw new ArgumentNullException(nameof(userId));

            var httpRequestMessage = WidgetRequest.CreateGetRequest($"/pincontext/{userId}?preview=0");
            var httpResponseMessage = await _restClient.SendRequest(httpRequestMessage);
            await using var stream = await httpResponseMessage.Content.ReadAsStreamAsync();

            Internal.Protobuf.UserLocation rootObject = Serializer.Deserialize<Internal.Protobuf.UserLocation>(stream);
            return new UserLocation
            {
                UserId = userId,
                Latitude = rootObject.User.Location.Latitude,
                Longitude = rootObject.User.Location.Longitude
            };
        }
        public async Task<IEnumerable<UserLocation>> FetchUsersLocation(string[] userIds)
        {
            if (userIds == null) throw new ArgumentNullException(nameof(userIds));
            if (userIds.Length == 0) throw new ArgumentException("Value cannot be an empty collection.", nameof(userIds));

            var httpRequestMessage = WidgetRequest.CreateGetRequest($"/pincontext/{string.Join(",", userIds)}?preview=0");
            var httpResponseMessage = await _restClient.SendRequest(httpRequestMessage);
            await using var stream = await httpResponseMessage.Content.ReadAsStreamAsync();

            UsersLocation rootObject = Serializer.Deserialize<UsersLocation>(stream);
            return rootObject.Users.Select(x => new UserLocation()
            {
                UserId = x.UserId,
                Latitude = x.Location.Latitude,
                Longitude = x.Location.Longitude
            });
        }
    }
}