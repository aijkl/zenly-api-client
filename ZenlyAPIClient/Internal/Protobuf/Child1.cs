using ProtoBuf;

namespace Zenly.APIClient.Internal.Protobuf
{
    [ProtoContract]
    internal class Child1
    {
        [ProtoMember(3)]
        public string UserId { set; get; }

        [ProtoMember(4)]
        public Child2 Child2 { set; get; }
    }
}
