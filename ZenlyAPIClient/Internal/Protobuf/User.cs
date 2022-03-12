using ProtoBuf;

namespace Aijkl.Zenly.APIClient.Internal.Protobuf
{
    [ProtoContract]
    internal class User
    {
        [ProtoMember(3)]
        public string UserId { set; get; }

        [ProtoMember(4)]
        public Location Location { set; get; }
    }
}
