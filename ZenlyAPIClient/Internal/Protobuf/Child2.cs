using ProtoBuf;

namespace Zenly.APIClient.Internal.Protobuf
{
    [ProtoContract]
    internal class Child2
    {
        [ProtoMember(4)]
        public double Latitude { set; get; }

        [ProtoMember(5)]
        public double Longitude { set; get; }
    }
}
