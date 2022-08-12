#nullable disable
using ProtoBuf;

namespace Aijkl.Zenly.APIClient.Internal.Protobuf
{
    [ProtoContract]
    internal class UserLocation
    {
        [ProtoMember(1)] 
        public User User { set; get; }
    }
}
