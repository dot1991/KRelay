﻿namespace Lib_K_Relay.Networking.Packets.Server
{
    public class RealmHeroesResponsePacket : Packet
    {
        public int HeroesLeft;

        public override PacketType Type => PacketType.REALM_HERO_LEFT_MSG;

        public override void Read(PacketReader r)
        {
            HeroesLeft = r.ReadInt32();
        }

        public override void Write(PacketWriter w)
        {
            w.Write(HeroesLeft);
        }
    }
}