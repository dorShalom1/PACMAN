using System;
using System.Collections.Generic;
using System.Diagnostics;
using mcl_RUDAT64;

namespace PACMAN.Objects
{
    public class UsbConnection { 

        #region Fields
        
        [NonSerialized]
        USB_RUDAT attInstance;

        [NonSerialized]
        private bool disposed = false;

        #endregion Fields

        #region Properites

        public String serialNumber { get; private set; }

        #endregion Properites

        public UsbConnection(String serialNumber)
        {
            attInstance = new USB_RUDAT();
            this.serialNumber = serialNumber;
        }

        public double GetAttenuation()
        {
            if (!getUSBStatus())
                throw new Exception("Rudat 6000 USB - Get Attenuation failed due to usb Connection failure SN:" + serialNumber);

            float att = -999;
            attInstance.Read_Att(ref att);
            return att;
        }

        public bool SetAttenuation(double value)
        {
            if (!getUSBStatus())
                throw new Exception("Rudat 6000 USB - Set Attenuation failed due to usb Connection failure SN:" + serialNumber);

            int test = attInstance.SetAttenuation((float)value);
            if ((float)value != GetAttenuation())
                return false;
            return true;
        }

        public void TryIsAlive(out bool status)
        {
            status = attInstance.GetUSBConnectionStatus() == 1;
        }

        public void Init()
        {
            String sn = serialNumber;
            attInstance.Connect(ref sn);

            if (!getUSBStatus())
                throw new Exception("Rudat 6000 USB - Connection failed due to usb Connection failure SN:" + serialNumber);

            Trace.TraceInformation("Connected to USB Rudat 6000 SN:" + sn);
            disposed = false;
        }

        private bool getUSBStatus()
        {
            bool status = false;
            TryIsAlive(out status);
            return status;
        }

        protected void Dispose(bool itIsSafeToAlsoFreeManagedObjects)
        {
            if (!disposed)
            {
                //Free unmanaged resources
                //Free managed resources too, but only if I'm being called from Dispose
                //(If I'm being called from Finalize then the objects might not exist
                //anymore
                if (itIsSafeToAlsoFreeManagedObjects)
                {
                    if (this.attInstance != null)
                    {
                        attInstance.Disconnect();
                        attInstance = null;
                    }
                }
                disposed = true;
            }
        }

        public static List<String> GetAvailableSNList()
        {
            USB_RUDAT testAtt = new USB_RUDAT();
            String serialNumbers = "";

            testAtt.Get_Available_SN_List(ref serialNumbers);
            testAtt = null;

            return new List<string>(serialNumbers.Split(' '));
        }
    }
}
