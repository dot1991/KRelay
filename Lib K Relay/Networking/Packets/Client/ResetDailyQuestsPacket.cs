﻿namespace Lib_K_Relay.Networking.Packets.Client
{
    public class ResetDailyQuestsPacket : Packet
    {
        public override PacketType Type => PacketType.RESET_DAILY_QUESTS;

        public override void Read(PacketReader r)
        {
        }

        public override void Write(PacketWriter w)
        {
        }
    }
}