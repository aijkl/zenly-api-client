#nullable disable
using System.Collections.Generic;
using ProtoBuf;

namespace Aijkl.Zenly.APIClient.Internal.Protobuf
{
    [ProtoContract]
    internal class UsersLocation
    {
        [ProtoMember(1)]
        public List<User> Users { set; get; }
    }
}
