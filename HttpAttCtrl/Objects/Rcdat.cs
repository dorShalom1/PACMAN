using PACMAN.Enums;
using System;
using System.Runtime.Serialization;

namespace PACMAN.Objects
{
    [Serializable]
    class Rcdat : Attenuator
    {
        public Rcdat(SerializationInfo info, StreamingContext sc) : base(info, sc) { }

        public Rcdat(string IpAdress, string Port, string Description, ConnectionTypes Type) : base(IpAdress, Port, Description, Type)
        {
            setCmd = "setatt={0}";
            getCmd = "att?";
        }

        public Rcdat(string ComPortName, string BaudRate, string Parity, string DataBits, string StopBits, string Description, ConnectionTypes Type) : base(ComPortName, BaudRate, Parity, DataBits, StopBits, Description, Type)
        {
            setCmd = "setatt={0}";
            getCmd = "att?";
        }

        public Rcdat(string SerialNumber, string Description) : base(SerialNumber, Description) { }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            base.GetObjectData(info, context);
        }
    }
}
