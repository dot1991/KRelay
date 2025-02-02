﻿namespace Lib_K_Relay.Networking.Packets.Server
{
    public class FilePacket : Packet
    {
        public byte[] Bytes;
        public string Name;

        public override PacketType Type => PacketType.FILE;

        public override void Read(PacketReader r)
        {
            Name = r.ReadString();
            Bytes = new byte[r.ReadInt32()];
            Bytes = r.ReadBytes(Bytes.Length);
        }

        public override void Write(PacketWriter w)
        {
            w.Write(Name);
            w.Write(Bytes.Length);
            w.Write(Bytes);
        }
    }
}