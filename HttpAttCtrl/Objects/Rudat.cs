using PACMAN.Enums;
using System;
using System.Runtime.Serialization;

namespace PACMAN.Objects
{
    [Serializable]
    class Rudat : Attenuator
    {
        public Rudat(SerializationInfo info, StreamingContext sc) : base(info, sc) { }

        public Rudat(string IpAdress, string Port, string Description, ConnectionTypes Type) : base(IpAdress, Port,Description,Type)
        {
            setCmd = "B{0}E";
            getCmd = "A";
        }

        public Rudat(string ComPortName, string BaudRate, string Parity, string DataBits, string StopBits, string Description, ConnectionTypes Type) : base(ComPortName, BaudRate, Parity, DataBits, StopBits, Description, Type)
        {
            setCmd = "B{0}E";
            getCmd = "A";
        }

        public Rudat(string SerialNumber, string Description): base(SerialNumber, Description) { }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            base.GetObjectData(info, context);
        }
    }
}
