using ProtoBuf;

namespace Zenly.APIClient.Internal.Protobuf
{
    [ProtoContract]
    class RootObject
    {
        [ProtoMember(1)]
        public Child1 Child1 { set; get; }
    }
}
