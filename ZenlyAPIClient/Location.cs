using System;
using Newtonsoft.Json;

namespace Zenly.APIClient
{
    public record Location([JsonProperty("longitude")] double Longitude, [JsonProperty("latitude")] double Latitude)
    {
        public double GetDistanceMeter(Location targetLocation)
        {
            var d1 = Latitude * (Math.PI / 180.0);
            var num1 = Longitude * (Math.PI / 180.0);
            var d2 = targetLocation.Latitude * (Math.PI / 180.0);
            var num2 = targetLocation.Longitude * (Math.PI / 180.0) - num1;
            var d3 = Math.Pow(Math.Sin((d2 - d1) / 2.0), 2.0) + Math.Cos(d1) * Math.Cos(d2) * Math.Pow(Math.Sin(num2 / 2.0), 2.0);

            return 6376500.0 * (2.0 * Math.Atan2(Math.Sqrt(d3), Math.Sqrt(1.0 - d3)));
        }
    }
}
