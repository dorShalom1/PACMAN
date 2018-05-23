using PACMAN.Enums;
using RestSharp;
using System.Net;
using System.Net.NetworkInformation;
using System.Runtime.Serialization;
using System.Windows.Forms;
using System;
using System.IO.Ports;
using System.IO;

namespace PACMAN.Objects
{
    [Serializable]
    public abstract class Attenuator : ISerializable
    {
        public string ipAddress;
        public string port;
        public string serialNumber;
        public string comPortName;
        public int baudRate;
        public Parity parity;
        public int dataBits;
        public StopBits stopBits;
        private UsbConnection usbCon;
        private TelnetConnection telnetCon;
        private SerialConnection serialCon;
        public string description { get; set; }
        public int attenuation { get; set; }
        public ConnectionTypes conType { get; set; }
        public bool isChecked { get; set; }
        public string getCmd;
        public string setCmd;
        private object mylock = new object();
        private string ackStr;
        public bool isConnected;
        private bool isWorking;
        private bool IsWorking
        {
            get
            {
                lock (mylock)
                {
                    return isWorking;
                }
            }
            set
            {
                lock (mylock)
                {
                    isWorking = value;
                }
            }
        }
        private System.Threading.Timer timer;

        public Attenuator(SerializationInfo info, StreamingContext sc)
        {
            ipAddress = (string)info.GetValue("ipAddress", typeof(string));
            port = (string)info.GetValue("port", typeof(string));
            serialNumber = (string)info.GetValue("serialNumber", typeof(string));
            comPortName = (string)info.GetValue("comPortName", typeof(string));
            baudRate = (int)info.GetValue("baudRate", typeof(int));
            parity = (Parity)info.GetValue("parity", typeof(Parity));
            dataBits = (int)info.GetValue("dataBits", typeof(int));
            stopBits = (StopBits)info.GetValue("stopBits", typeof(StopBits));
            description = (string)info.GetValue("description", typeof(string));
            attenuation = (int)info.GetValue("attenuation", typeof(int));
            isChecked = (bool)info.GetValue("isChecked", typeof(bool));
            getCmd = (string)info.GetValue("getCmd", typeof(string));
            setCmd = (string)info.GetValue("setCmd", typeof(string));
            conType = (ConnectionTypes)info.GetValue("conType", typeof(ConnectionTypes));
            Init();
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("ipAddress", ipAddress);
            info.AddValue("port", port);
            info.AddValue("serialNumber", serialNumber);
            info.AddValue("comPortName", comPortName);
            info.AddValue("baudRate", baudRate);
            info.AddValue("parity", parity);
            info.AddValue("dataBits", dataBits);
            info.AddValue("stopBits", stopBits);
            info.AddValue("description", description);
            info.AddValue("attenuation", attenuation);
            info.AddValue("isChecked", isChecked);
            info.AddValue("getCmd", getCmd);
            info.AddValue("setCmd", setCmd);
            info.AddValue("conType", conType);
        }

        public Attenuator(string IpAdress, string Port, string Description, ConnectionTypes Type)
        {
            description = Description;
            ipAddress = IpAdress;
            port = Port;
            conType = Type;
        }

        public Attenuator(string ComPortName, string BaudRate, string Parity, string DataBits, string StopBits, string Description, ConnectionTypes Type)
        {
            comPortName = ComPortName;
            baudRate = int.Parse(BaudRate);
            parity = string2Parity(Parity);
            dataBits = int.Parse(DataBits);
            stopBits = string2StopBits(StopBits);
            description = Description;
            conType = Type;
        }

        private StopBits string2StopBits(string stopBits)
        {
            switch (stopBits)
            {
                case "None":
                    return StopBits.None;
                case "Odd":
                    return StopBits.One;
                case "Even":
                    return StopBits.OnePointFive;
                case "Mark":
                    return StopBits.Two;
                default:
                    return StopBits.One;
            }
        }

        private Parity string2Parity(string parity)
        {
            switch (parity)
            {
                case "None":
                    return Parity.None;
                case "Odd":
                    return Parity.Odd;
                case "Even":
                    return Parity.Even;
                case "Mark":
                    return Parity.Mark;
                case "Space":
                    return Parity.Space;
                default:
                    return Parity.None;
            }

        }

        public Attenuator(string SerialNumber, string Description)
        {
            description = Description;
            conType = ConnectionTypes.Usb;
            serialNumber = SerialNumber;
        }

        public bool IsConnected()
        {
            try
            {
                switch (conType)
                {
                    case ConnectionTypes.Http:
                        Ping ping = new Ping();
                        PingReply pingReply = ping.Send(ipAddress);
                        isConnected = pingReply.Status == IPStatus.Success;
                        break;
                    case ConnectionTypes.Telnet:
                        isConnected = telnetCon.IsConnected;
                        break;
                    case ConnectionTypes.Usb:
                        bool res;
                        usbCon.TryIsAlive(out res);
                        isConnected = res;
                        break;
                    case ConnectionTypes.Serial:
                        isConnected = serialCon.IsConnected;
                        break;
                    default:
                        isConnected = false;
                        break;
                }
                return isConnected;
            }
            catch(Exception ex)
            {
                File.AppendAllText(@"c:\pacmanData\log.txt", ex.Message);
                return false;
            }
        }

        public bool Init()
        {
            try
            {


                switch (conType)
                {
                    case ConnectionTypes.Http:
                        break;
                    case ConnectionTypes.Telnet:
                        telnetCon = new TelnetConnection(ipAddress, int.Parse(port));
                        telnetCon.newLine = getCmd.Equals("att?") ? "\n" : "\r";
                        ackStr = getCmd.Equals("att?") ? "1" : "ACK";
                        //timer = new System.Threading.Timer(new System.Threading.TimerCallback(releasePort), null, 120000, 60000);
                        break;
                    case ConnectionTypes.Serial:
                        serialCon = new SerialConnection(comPortName, baudRate, parity, dataBits, stopBits);
                        serialCon.newLine = getCmd.Equals("att?") ? "\n" : "\r";
                        ackStr = getCmd.Equals("att?") ? "1" : "ACK";
                        //timer = new System.Threading.Timer(new System.Threading.TimerCallback(releasePort), null, 120000, 60000);
                        break;
                    case ConnectionTypes.Usb:
                        usbCon = new UsbConnection(serialNumber);
                        usbCon.Init();
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                File.AppendAllText(@"c:\pacmanData\log.txt", ex.Message);
            }
                if (IsConnected())
            {
                isChecked = true;
            }
            else
                MessageBox.Show("Attenuator is not reachable.\nPlease check the connection and try again.",
                    "Unreachable Attenuator", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return isChecked;
        }

        private bool connect()
        {
            try
            {
                switch (conType)
                {
                    case ConnectionTypes.Http:
                        return IsConnected();
                    case ConnectionTypes.Telnet:
                        return telnetCon.Connect();
                    case ConnectionTypes.Usb:                        
                        return IsConnected();
                    case ConnectionTypes.Serial:
                        return serialCon.Connect();
                    default:
                        return false;
                }
            }
            catch (Exception ex)
            {
                File.AppendAllText(@"c:\pacmanData\log.txt", ex.Message);
                MessageBox.Show("Couldn't connect to " + description,
                    "Connection Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }

        private void releasePort(object obj)
        {
            if (IsWorking)
            {
                IsWorking = false;
            }
            else
            {
                if (conType.Equals(ConnectionTypes.Telnet))
                    telnetCon.Release();
                else
                    serialCon.Release();
                isConnected = false;
            }
        }

        public void releasePort()
        {
            if(telnetCon != null)
                telnetCon.Release();
            if (serialCon != null)
                serialCon.Release();
            isConnected = false;
        }

        public bool setAttenuation(int value)
        {
            TimeSpan diff;
            DateTime startTime;
            string stringResponse;
            try
            {
                switch (conType)
                {
                    case ConnectionTypes.Http:
                        attenuation = value;
                        var client = new RestClient(string.Format("http://{0}/{1}", (port != "80" ? ipAddress + ":" + port : ipAddress), string.Format(setCmd, value)));
                        var request = new RestRequest(Method.GET);
                        request.AddHeader("cache-control", "no-cache");
                        request.AddHeader("content-type", "application/x-www-form-urlencoded");
                        request.AddParameter("application/x-www-form-urlencoded", "attset=2", ParameterType.RequestBody);
                        IRestResponse response = client.Execute(request);
                        return response.StatusCode.Equals(HttpStatusCode.OK);
                    case ConnectionTypes.Telnet:
                        IsWorking = true;
                        if (!isConnected)
                        {
                            if (!telnetCon.Connect())
                                return false;
                            else
                                isConnected = true;
                        }
                        startTime = DateTime.Now;
                        telnetCon.WriteLine(string.Format(setCmd, value));
                        stringResponse = telnetCon.Read();
                        while (!stringResponse.Contains(ackStr))
                        {
                            stringResponse = telnetCon.Read();
                            diff = DateTime.Now - startTime;
                            if (diff.TotalMilliseconds > 1000)
                            {
                                return false;
                            }
                        }
                        return true;
                    case ConnectionTypes.Serial:
                        IsWorking = true;
                        if (!isConnected)
                        {
                            if (!serialCon.Connect())
                                return false;
                            else
                                isConnected = true;
                        }
                        startTime = DateTime.Now;
                        serialCon.WriteLine(string.Format(setCmd, value));
                        stringResponse = serialCon.Read();
                        while (!stringResponse.Contains(ackStr))
                        {
                            stringResponse = serialCon.Read();
                            diff = DateTime.Now - startTime;
                            if (diff.TotalMilliseconds > 1000)
                                return false;
                        }
                        return true;
                    case ConnectionTypes.Usb:
                        return usbCon.SetAttenuation(value);
                    default:
                        return false;
                }
            }
            catch (Exception ex)
            {
                File.AppendAllText(@"c:\pacmanData\log.txt", ex.Message);
                MessageBox.Show("Couldn't connect to " + description,
                    "Connection Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }

        public int getAttenuation()
        {
            try
            {
                switch (conType)
                {
                    case ConnectionTypes.Http:
                        var client = new RestClient(string.Format("http://{0}/{1}", ipAddress, getCmd));
                        var request = new RestRequest(Method.GET);
                        request.AddHeader("cache-control", "no-cache");
                        IRestResponse response = client.Execute(request);
                        int attenuation;
                        bool isInt = int.TryParse(response.Content, out attenuation);
                        return isInt ? attenuation : -1;
                    case ConnectionTypes.Telnet:
                        telnetCon.WriteLine(getCmd);
                        string val = telnetCon.Read();

                        return -1;
                    case ConnectionTypes.Serial:
                        return -1;
                    case ConnectionTypes.Usb:
                        return (int)usbCon.GetAttenuation();
                    default:
                        return -1;
                }
            }
            catch (Exception ex)
            {
                File.AppendAllText(@"c:\pacmanData\log.txt", ex.Message);
                MessageBox.Show("Couldn't connect to " + description,
                    "Connection Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return -1;
            }
        } 
    }
}
