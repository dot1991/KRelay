﻿namespace Lib_K_Relay.Networking.Packets.Client
{
    public class ChangeTradePacket : Packet
    {
        public bool[] Offers;

        public override PacketType Type => PacketType.CHANGETRADE;

        public override void Read(PacketReader r)
        {
            Offers = new bool[r.ReadInt16()];
            for (var i = 0; i < Offers.Length; i++) Offers[i] = r.ReadBoolean();
        }

        public override void Write(PacketWriter w)
        {
            w.Write((ushort) Offers.Length);
            foreach (var i in Offers) w.Write(i);
        }
    }
}