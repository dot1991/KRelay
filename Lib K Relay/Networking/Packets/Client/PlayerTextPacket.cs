﻿namespace Lib_K_Relay.Networking.Packets.Client
{
    public class PlayerTextPacket : Packet
    {
        public string Text;

        public override PacketType Type => PacketType.PLAYERTEXT;

        public override void Read(PacketReader r)
        {
            Text = r.ReadString();
        }

        public override void Write(PacketWriter w)
        {
            w.Write(Text);
        }
    }
}