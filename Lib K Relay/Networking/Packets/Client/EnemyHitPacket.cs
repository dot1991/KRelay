namespace Lib_K_Relay.Networking.Packets.Client
{
    public class EnemyHitPacket : Packet
    {
        public byte BulletId;
        public int DamagerId;
        public bool Killed;
        public int TargetId;
        public int TargetId2;
        public int Time;

        public override PacketType Type => PacketType.ENEMYHIT;

        public override void Read(PacketReader r)
        {
            // probably incorrect, todo
            Time = r.ReadInt32();
            BulletId = r.ReadByte();
            TargetId = r.ReadInt32();
            DamagerId = r.ReadInt32();
            Killed = r.ReadBoolean();
            TargetId2 = r.ReadInt32();
        }

        public override void Write(PacketWriter w)
        {
            w.Write(Time);
            w.Write(BulletId);
            w.Write(TargetId);
            w.Write(DamagerId);
            w.Write(Killed);
            w.Write(TargetId2);
        }
    }
}