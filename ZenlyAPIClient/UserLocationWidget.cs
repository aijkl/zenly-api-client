using Newtonsoft.Json;

namespace Zenly.APIClient
{
    public class UserLocation
    {
        [JsonProperty("userId")]
        public string UserId { set; get; }

        [JsonProperty("longitude")]
        public double Longitude { set; get; }

        [JsonProperty("latitude")]
        public double Latitude { set; get; }
    }
}