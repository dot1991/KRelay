﻿using Lib_K_Relay.Networking.Packets.DataObjects;

namespace Lib_K_Relay.Networking.Packets.Client
{
    public class MovePacket : Packet
    {
        public Location NewPosition;
        public LocationRecord[] Records;
        public int ServerRealTimeMSofLastNewTick;
        public int TickId;
        public int Time;

        public override PacketType Type => PacketType.MOVE;

        public override void Read(PacketReader r)
        {
            TickId = r.ReadInt32();
            Time = r.ReadInt32();
            ServerRealTimeMSofLastNewTick = r.ReadInt32();
            NewPosition = (Location) new Location().Read(r);
            Records = new LocationRecord[r.ReadInt16()];
            for (var i = 0; i < Records.Length; i++) Records[i] = (LocationRecord) new LocationRecord().Read(r);
        }

        public override void Write(PacketWriter w)
        {
            w.Write(TickId);
            w.Write(Time);
            w.Write(ServerRealTimeMSofLastNewTick);
            NewPosition.Write(w);
            w.Write((short) Records.Length);
            foreach (var l in Records) l.Write(w);
        }
    }
}