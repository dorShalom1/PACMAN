using System;
using System.Text;
using System.IO.Ports;
using System.Windows.Forms;
using System.Threading;

namespace PACMAN.Objects
{
    class SerialConnection
    {
        SerialPort serialPort;
        string comPortName;
        int baudRate;
        Parity parity;
        int dataBits;
        StopBits stopBits;
        public string newLine = "\r";

        public SerialConnection(string ComPortName, int BaudRate, Parity Parity, int DataBits, StopBits StopBits)
        {
            comPortName = ComPortName;
            baudRate = BaudRate;
            parity = Parity;
            dataBits = DataBits;
            stopBits = StopBits;
            try
            {
                serialPort = new SerialPort(comPortName, baudRate, parity, dataBits, stopBits);
                serialPort.Open();
                serialPort.NewLine = newLine;
            }
            catch (Exception e)
            {
                MessageBox.Show("Serial port is not reachable.\nPlease check the parameters and verify port is available.",
                    "Serial is Blocked!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        public void WriteLine(string cmd)
        {
            if (!serialPort.IsOpen) return;
            serialPort.WriteLine(cmd);
        }

        public string Read()
        {
            if (!serialPort.IsOpen) return "";
            string dor = serialPort.ReadExisting();
            return dor;
        }

        public void Release()
        {
            if (serialPort != null)
            {
                serialPort.Close();
                serialPort = null;
            }
        }

        public bool IsConnected
        {
            get
            {
                if (serialPort != null)
                    return serialPort.IsOpen;
                return false;
            }
        }

        public bool Connect()
        {
            bool isConnected = true;
            if (serialPort == null)
            {
                isConnected = false;
            }
            if (!isConnected)
            {
                try
                {
                    serialPort = new SerialPort(comPortName, baudRate, parity, dataBits, stopBits);
                    serialPort.Dispose();
                    serialPort.Open();
                    serialPort.NewLine = newLine;
                    Thread.Sleep(500);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Com port is not reachable.\nPlease check the parameters and verify port is available.",
                   "Telnet is Blocked!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            return serialPort.IsOpen;
        }
    }
}
