#nullable disable
using ProtoBuf;

namespace Aijkl.Zenly.APIClient.Internal.Protobuf
{
    [ProtoContract]
    internal class Location
    {
        [ProtoMember(4)]
        public double Latitude { set; get; }

        [ProtoMember(5)]
        public double Longitude { set; get; }
    }
}
