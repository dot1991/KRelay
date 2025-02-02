﻿namespace Lib_K_Relay.Networking.Packets.Client
{
    public class ShootAckPacket : Packet
    {
        public int Time;

        public override PacketType Type => PacketType.SHOOTACK;

        public override void Read(PacketReader r)
        {
            Time = r.ReadInt32();
        }

        public override void Write(PacketWriter w)
        {
            w.Write(Time);
        }
    }
}