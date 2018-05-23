using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace PACMAN.Objects
{
    enum Verbs {
        WILL = 251,
        WONT = 252,
        DO = 253,
        DONT = 254,
        IAC = 255
    }

    enum Options
    {
        SGA = 3
    }

    public class TelnetConnection
    {
        TcpClient tcpSocket;
        string hostname;
        int port;
        int TimeOutMs = 100;
        public string newLine = "\r";

        public TelnetConnection(string Hostname, int Port)
        {
            hostname = Hostname;
            port = Port;
            try
            {
                tcpSocket = new TcpClient(Hostname, Port);
            } 
            catch(SocketException se)
            {
                MessageBox.Show("Telnet socket is not reachable.\nPlease check the parameters and verify port is available.",
                    "Telnet is Blocked!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void WriteLine(string cmd)
        {
            Write(cmd + newLine);
        }

        public void Write(string cmd)
        {
            if (!tcpSocket.Connected) return;
            byte[] buf = System.Text.ASCIIEncoding.ASCII.GetBytes(cmd.Replace("\0xFF","\0xFF\0xFF"));
            tcpSocket.GetStream().Write(buf, 0, buf.Length);
        }

        public string Read()
        {
            if (!tcpSocket.Connected) return null;
            StringBuilder sb=new StringBuilder();
            do
            {
                ParseTelnet(sb);
                System.Threading.Thread.Sleep(TimeOutMs);
            } while (tcpSocket.Available > 0);
            return sb.ToString();
        }

        public bool IsConnected
        {
            get
            {
              if(tcpSocket != null)
                    return tcpSocket.Connected;
                return false;
            }
        }

        public void Release()
        {
            if (tcpSocket != null)
            {
                tcpSocket.Close();
                tcpSocket = null;
            }
        }

        public bool Connect()
        {
            bool isConnected = true;
            if(tcpSocket == null)
            {
                isConnected = false;
            }
            if(!isConnected)
            {
                try
                {
                    tcpSocket = new TcpClient(hostname, port);
                    Thread.Sleep(500);
                }
                catch (SocketException ex)
                {
                    MessageBox.Show("Telnet socket is not reachable.\nPlease check the parameters and verify port is available.",
                   "Telnet is Blocked!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            return tcpSocket.Connected;
        }

        void ParseTelnet(StringBuilder sb)
        {
            while (tcpSocket.Available > 0)
            {
                int input = tcpSocket.GetStream().ReadByte();
                switch (input)
                {
                    case -1 :
                        break;
                    case (int)Verbs.IAC:
                        // interpret as command
                        int inputverb = tcpSocket.GetStream().ReadByte();
                        if (inputverb == -1) break;
                        switch (inputverb)
                        {
                            case (int)Verbs.IAC: 
                                //literal IAC = 255 escaped, so append char 255 to string
                                sb.Append(inputverb);
                                break;
                            case (int)Verbs.DO: 
                            case (int)Verbs.DONT:
                            case (int)Verbs.WILL:
                            case (int)Verbs.WONT:
                                // reply to all commands with "WONT", unless it is SGA (suppres go ahead)
                                int inputoption = tcpSocket.GetStream().ReadByte();
                                if (inputoption == -1) break;
                                tcpSocket.GetStream().WriteByte((byte)Verbs.IAC);
                                if (inputoption == (int)Options.SGA )
                                    tcpSocket.GetStream().WriteByte(inputverb == (int)Verbs.DO ? (byte)Verbs.WILL:(byte)Verbs.DO); 
                                else
                                    tcpSocket.GetStream().WriteByte(inputverb == (int)Verbs.DO ? (byte)Verbs.WONT : (byte)Verbs.DONT); 
                                tcpSocket.GetStream().WriteByte((byte)inputoption);
                                break;
                            default:
                                break;
                        }
                        break;
                    default:
                        sb.Append( (char)input );
                        break;
                }
            }
        }
    }
}
