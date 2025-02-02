﻿namespace Lib_K_Relay.Networking.Packets.DataObjects
{
    public class Entity : IDataObject
    {
        public ushort ObjectType;
        public Status Status = new Status();

        public IDataObject Read(PacketReader r)
        {
            ObjectType = r.ReadUInt16();
            Status.Read(r);

            return this;
        }

        public void Write(PacketWriter w)
        {
            w.Write(ObjectType);
            Status.Write(w);
        }

        public object Clone()
        {
            return new Entity
            {
                ObjectType = ObjectType,
                Status = (Status) Status.Clone()
            };
        }
    }
}