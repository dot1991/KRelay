﻿namespace Lib_K_Relay.Networking.Packets.Client
{
    public class ActivePetUpdateRequestPacket : Packet
    {
        public const int FOLLOW_PET = 1;
        public const int UNFOLLOW_PET = 2;
        public const int RELEASE_PET = 3;

        public int CommandId;
        public uint PetId;

        public override PacketType Type => PacketType.ACTIVE_PET_UPDATE_REQUEST;

        public override void Read(PacketReader r)
        {
            CommandId = r.ReadByte();
            PetId = (uint) r.ReadInt32();
        }

        public override void Write(PacketWriter w)
        {
            w.Write((byte) CommandId);
            w.Write((int) PetId);
        }
    }
}