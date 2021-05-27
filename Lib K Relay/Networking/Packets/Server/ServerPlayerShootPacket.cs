using Lib_K_Relay.Networking.Packets.DataObjects;

namespace Lib_K_Relay.Networking.Packets.Server
{
    public class ServerPlayerShootPacket : Packet
    {
        public float Angle;
        public byte BulletId;
        public int ContainerType;
        public short Damage;
        public int OwnerId;
        public Location StartingLoc;
        public int Unknown1;
        public byte Unknown2;
        public byte Unknown3;
        public float Unknown4;

        public override PacketType Type => PacketType.SERVERPLAYERSHOOT;

        public override void Read(PacketReader r)
        {
            BulletId = r.ReadByte();
            OwnerId = r.ReadInt32();
            ContainerType = r.ReadInt32();
            StartingLoc = (Location) new Location().Read(r);
            Angle = r.ReadSingle();
            Damage = r.ReadInt16();
            /*Unknown1 = r.ReadInt32();
            Unknown2 = r.ReadByte();
            Unknown3 = r.ReadByte();
            Unknown4 = r.ReadSingle();*/
        }

        public override void Write(PacketWriter w)
        {
            w.Write(BulletId);
            w.Write(OwnerId);
            w.Write(ContainerType);
            StartingLoc.Write(w);
            w.Write(Angle);
            w.Write(Damage);
            /*w.Write(Unknown1);
            w.Write(Unknown2);
            w.Write(Unknown3);
            w.Write(Unknown4);*/
        }
    }
}