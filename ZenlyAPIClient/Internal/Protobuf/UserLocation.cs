using System.Collections.Generic;
using ProtoBuf;

namespace Zenly.APIClient.Internal.Protobuf
{
    [ProtoContract]
    class UserLocation
    {
        [ProtoMember(1)]
        public User User { set; get; }
    }
}
