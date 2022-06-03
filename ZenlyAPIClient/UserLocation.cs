using Newtonsoft.Json;
using Zenly.APIClient;

namespace Aijkl.Zenly.APIClient
{
    public record UserLocation([JsonProperty("userId")] string UserId, double Longitude, double Latitude) : Location(Longitude, Latitude);
}