using System.Collections.Generic;
using ProtoBuf;

namespace Aijkl.Zenly.APIClient.Internal.Protobuf
{
    [ProtoContract]
    class UsersLocation
    {
        [ProtoMember(1)]
        public List<User> Users { set; get; }
    }
}
