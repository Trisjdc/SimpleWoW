
using System.Collections.Generic;

namespace Client.World.Network
{
    public partial class WorldSocket
    {
        [PacketHandler(WorldCommand.SMSG_WARDEN_DATA)]
        void HandleWardenDataResponse(InPacket packet)
        {
            // flawed out packet, needs to be filled with sha1 checksum and warden data
            OutPacket response = new OutPacket(WorldCommand.CMSG_WARDEN_DATA);
            Game.SendPacket(response);
        }
    }
}