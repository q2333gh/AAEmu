using AAEmu.Commons.Network;
using AAEmu.Game.Core.Network.Game;

namespace AAEmu.Game.Core.Packets.C2G
{
    public class CSRestartMainQuestPacket : GamePacket
    {
        public CSRestartMainQuestPacket() : base(0x0fa, 1)
        {
        }

        public override void Read(PacketStream stream)
        {
            var id = stream.ReadUInt32();

            _log.Warn("RestartMainQuest, Id: {0}", id);
        }
    }
}
