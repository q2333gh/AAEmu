using AAEmu.Commons.Network;
using AAEmu.Game.Core.Network.Game;

namespace AAEmu.Game.Core.Packets.C2G
{
    public class CSBidAuctionPacket : GamePacket
    {
        public CSBidAuctionPacket() : base(0x0b5, 1)
        {
        }

        public override void Read(PacketStream stream)
        {
            var npcObjId = stream.ReadBc();
            // TODO ...

            _log.Warn("BidAuction, NpcObjId: {0}", npcObjId);
        }
    }
}
