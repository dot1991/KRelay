﻿namespace Lib_K_Relay.Networking.Packets.Client
{
    public class GuildInvitePacket : Packet
    {
        public string Name;

        public override PacketType Type => PacketType.GUILDINVITE;

        public override void Read(PacketReader r)
        {
            Name = r.ReadString();
        }

        public override void Write(PacketWriter w)
        {
            w.Write(Name);
        }
    }
}