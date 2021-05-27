﻿namespace Lib_K_Relay.Networking.Packets.Server
{
    public class BuyResultPacket : Packet
    {
        public string Message;
        /*
		UnknownError = -1
		Success = 0
		InvalidCharacter = 1
		ItemNotFound = 2
		NotEnoughGold = 3
		InventoryFull = 4
		TooLowRank = 5
		NotEnoughFame = 6
		PetFeedSuccess = 7
        TooManyResets = 10
		*/

        public int Result;

        public override PacketType Type => PacketType.BUYRESULT;

        public override void Read(PacketReader r)
        {
            Result = r.ReadInt32();
            Message = r.ReadString();
        }

        public override void Write(PacketWriter w)
        {
            w.Write(Result);
            w.Write(Message);
        }
    }
}