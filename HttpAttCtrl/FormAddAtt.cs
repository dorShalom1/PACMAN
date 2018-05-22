using PACMAN.Enums;
using PACMAN.Objects;
using System;
using System.IO.Ports;
using System.Net;
using System.Windows.Forms;


namespace PACMAN
{
    public partial class FormAddAtt : Form
    {
        public Attenuator attenuator { get; private set; }
        public bool isInputOk = false;
        private IPAddress ipAdd;
        private long res;

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void FormAddAtt_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        public FormAddAtt()
        {
            InitializeComponent();
        }

        public FormAddAtt(Attenuator att)
        {
            InitializeComponent();
            buttonAdd.Text = "Apply";
            panelHttp.Visible = false;
            panelUsb.Visible = false;
            panelSerial.Visible = false;
            textBoxDescription.Text = att.description;
            comboBoxAttType.Text = att.GetType().Name.Equals("Rudat") ? "RUDAT" : "RCDAT";
            comboBoxConType.Text = att.conType.ToString().ToUpper();
            switch (att.conType)
            {
                case ConnectionTypes.Http:
                case ConnectionTypes.Telnet:
                    panelHttp.Visible = true;
                    textBoxHttpIp.Text = att.ipAddress;
                    textBoxHttpPort.Text = att.port;
                    break;
                case ConnectionTypes.Serial:
                    foreach (string id in SerialPort.GetPortNames())
                        comboBoxComPort.Items.Add(id);
                    comboBoxComPort.Text = att.comPortName;
                    textBoxBaudRate.Text = att.baudRate.ToString();
                    comboBoxParity.Text = att.parity.ToString();
                    comboBoxDataBits.Text = att.dataBits.ToString();
                    comboBoxStopBits.Text = att.stopBits.ToString();
                    panelSerial.Visible = true;
                    break;
                case ConnectionTypes.Usb:
                    panelUsb.Visible = true;
                    foreach (string id in UsbConnection.GetAvailableSNList())
                        comboBoxDeviceId.Items.Add(id);
                    comboBoxDeviceId.Text = att.serialNumber;
                    break;
                default:
                    break;
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            isInputOk = true;
            if (!verifyInputs())
                return;
            switch (comboBoxConType.SelectedItem.ToString())
            {
                case "HTTP":
                    if (comboBoxAttType.SelectedItem.ToString() == "RCDAT")
                        attenuator = new Rcdat(textBoxHttpIp.Text, textBoxHttpPort.Text, textBoxDescription.Text, ConnectionTypes.Http);
                    else
                        attenuator = new Rudat(textBoxHttpIp.Text, textBoxHttpPort.Text, textBoxDescription.Text, ConnectionTypes.Http);
                    break;
                case "TELNET":
                    if(comboBoxAttType.SelectedItem.ToString() == "RCDAT")
                        attenuator = new Rcdat(textBoxHttpIp.Text, textBoxHttpPort.Text, textBoxDescription.Text, ConnectionTypes.Telnet);
                    else
                        attenuator = new Rudat(textBoxHttpIp.Text, textBoxHttpPort.Text, textBoxDescription.Text, ConnectionTypes.Telnet);
                    break;
                case "USB":
                    if (comboBoxAttType.SelectedItem.ToString() == "RCDAT")
                        attenuator = new Rcdat(comboBoxDeviceId.SelectedItem.ToString(), textBoxDescription.Text);
                    else
                        attenuator = new Rudat(comboBoxDeviceId.SelectedItem.ToString(), textBoxDescription.Text);
                    break;
                case "SERIAL":
                    if (comboBoxAttType.SelectedItem.ToString() == "RCDAT")
                        attenuator = new Rcdat(comboBoxComPort.SelectedItem.ToString(), textBoxBaudRate.Text, comboBoxParity.Text,comboBoxDataBits.Text, comboBoxStopBits.Text, textBoxDescription.Text, ConnectionTypes.Serial);
                    else
                        attenuator = new Rudat(comboBoxComPort.SelectedItem.ToString(), textBoxBaudRate.Text, comboBoxParity.Text, comboBoxDataBits.Text, comboBoxStopBits.Text, textBoxDescription.Text, ConnectionTypes.Serial);
                    break;
                default:
                    break;
            }
            if (isInputOk)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void comboBoxConType_SelectedIndexChanged(object sender, EventArgs e)
        {
            panelHttp.Visible = false;
            panelUsb.Visible = false;
            panelSerial.Visible = false;
            switch (comboBoxConType.SelectedItem.ToString())
            {
                case "HTTP":
                    panelHttp.Visible = true;
                    labelPort.Text = "Port (optional)";
                    textBoxHttpPort.Text = "80";
                    break;
                case "TELNET":
                    panelHttp.Visible = true;
                    labelPort.Text = "Port";
                    textBoxHttpPort.Text = "23";
                    break;
                case "USB":
                    foreach (string id in UsbConnection.GetAvailableSNList())
                        comboBoxDeviceId.Items.Add(id);
                    panelUsb.Visible = true;
                    break;
                case "SERIAL":
                    foreach (string id in SerialPort.GetPortNames())
                        comboBoxComPort.Items.Add(id);
                    textBoxBaudRate.Text = "9600";
                    comboBoxParity.Text = "None";
                    comboBoxDataBits.Text = "8";
                    comboBoxStopBits.Text = "1";
                    panelSerial.Visible = true;
                    break;
                default:
                    break;
            }
        }

        private bool verifyInputs()
        {
            
            if (textBoxDescription.Text == "")
            {
                MessageBox.Show("Please provide description!",
                        "Wrong Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                isInputOk = false;
            }

            else if (panelHttp.Enabled)
            {
                if (!IPAddress.TryParse(textBoxHttpIp.Text, out ipAdd))
                {
                    MessageBox.Show("Wrong IP Address!",
                    "Wrong Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    isInputOk = false;
                }

                if (comboBoxDeviceId.Text != "" && !long.TryParse(comboBoxDeviceId.Text, out res))
                {
                    MessageBox.Show("Wrong Port!",
                        "Wrong Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    isInputOk = false;
                }
            }

            else if (panelUsb.Enabled)
            {
                if (comboBoxDeviceId.Text == "")
                {
                    MessageBox.Show("Please select USB Device!",
                        "Wrong Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    isInputOk = false;
                }
            }

            else if (panelSerial.Enabled)
            {
                if (comboBoxComPort.Text == "" )
                {
                    MessageBox.Show("Please select Serial Device!",
                        "Wrong Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    isInputOk = false;
                }
            }

            if (AttenuatorList.attList != null)
            {
                foreach(Attenuator att in AttenuatorList.attList)
                {
                    if(att.description == textBoxDescription.Text && buttonAdd.Text != "Apply")
                    {
                        MessageBox.Show("Attenuator with the same description already exists, \nPlease change description!",
                        "Wrong Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        isInputOk = false;
                    }
                }
            }
            return isInputOk;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
