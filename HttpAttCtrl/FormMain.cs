using PACMAN.Objects;
using PACMAN.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace PACMAN
{
    public partial class FormMain : Form
    {
        #region Members
        bool directionUp;
        private object mylock = new object();
        bool isSucceeded;
        private bool isMoving;
        private bool IsMoving
        {
            get
            {
                lock (mylock)
                {
                    return isMoving;
                }
            }
            set
            {
                lock (mylock)
                {
                    isMoving = value;
                    if (isMoving == true)
                        panelParams.Enabled = false;
                    else
                        panelParams.Enabled = true;
                }
            }
        }
        private DateTime startMove;
        private int diff;
        int currentAttenuation;
        int start;
        int stop;
        int stepSize;
        int stepTime;
        bool isParsed;
        bool isSaved = true;
        List<Attenuator> attList = new List<Attenuator>();
        List<AttStep> stepList = null;
        #endregion

        #region winSupport
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void FormMain_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        #endregion

        #region Ctor
        public FormMain()
        {
            InitializeComponent();
            start = int.Parse(textBoxStart.Text);
            stop = int.Parse(textBoxStop.Text);
            stepSize = int.Parse(textBoxStepSize.Text);
            stepTime = int.Parse(textBoxStepTime.Text);
            TrackBar.CheckForIllegalCrossThreadCalls = false;
            // loadToolStripMenuItem_Click(this, new EventArgs());
        }
        #endregion

        #region Events
        #region Buttons
        private void buttonStopStart_Click(object sender, EventArgs e)
        {
            // stop
            if (IsMoving)
            {
                IsMoving = false;
            }
            // start
            else
            {
                if (!WorkerMoveAtt.IsBusy)
                {
                    IsMoving = true;
                    WorkerMoveAtt.RunWorkerAsync();
                }
            }
        }

        private void buttonSetAtt_Click(object sender, EventArgs e)
        {
            int val;
            isParsed = int.TryParse(textBoxCurrentAtt.Text, out val);
            if (isParsed)
            {
                if (val >= start && val <= stop)
                {
                    isSucceeded = setAttenuation(val);
                    return;
                }
            }

            textBoxCurrentAtt.Text = currentAttenuation.ToString();
            MessageBox.Show("The inserted value is out of range.",
                    "Out of range", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void buttonAddAtt_Click(object sender, EventArgs e)
        {
            FormAddAtt formAdd = new FormAddAtt();
            formAdd.ShowDialog();
            if (formAdd.isInputOk && formAdd.DialogResult.Equals(DialogResult.OK))
            {
                formAdd.attenuator.Init();
                if (formAdd.attenuator.IsConnected())
                {
                    isSaved = false;
                    attList.Add(formAdd.attenuator);
                    updateAttList();
                }
            }
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            directionUp = false;
            if (trackBarAtt.Value - stepSize < trackBarAtt.Minimum)
            {
                trackBarAtt.Value = trackBarAtt.Minimum;
                directionUp = true;
            }
            else
                trackBarAtt.Value -= stepSize;
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            directionUp = true;
            if (trackBarAtt.Value + stepSize > trackBarAtt.Maximum)
            {
                trackBarAtt.Value = trackBarAtt.Maximum;
                directionUp = false;
            }
            else
                trackBarAtt.Value += stepSize;
        }

        private void buttonMax_Click(object sender, EventArgs e)
        {
            // stop
            if (IsMoving)
            {
                IsMoving = false;
            }
            // start
            else
            {
                if (!WorkerMoveMax.IsBusy)
                {
                    IsMoving = true;
                    WorkerMoveMax.RunWorkerAsync();
                }
            }
        }

        private void buttonMin_Click(object sender, EventArgs e)
        {
            // stop
            if (IsMoving)
            {
                IsMoving = false;
            }
            // start
            else
            {
                if (!WorkerMoveMin.IsBusy)
                {
                    IsMoving = true;
                    WorkerMoveMin.RunWorkerAsync();
                }
            }
        }

        private void buttonScript_Click(object sender, EventArgs e)
        {
            // stop
            if (IsMoving)
            {
                IsMoving = false;
            }
            // start
            else
            {
                if (!WorkerRunScript.IsBusy)
                {
                    IsMoving = true;
                    WorkerRunScript.RunWorkerAsync();
                }
            }
        }

        private void buttonEditScript_Click(object sender, EventArgs e)
        {
            editScriptToolStripMenuItem_Click(this, new EventArgs());
        }

        private void buttonLoadScript_Click(object sender, EventArgs e)
        {
            loadScriptToolStripMenuItem_Click(this, new EventArgs());
        }

        private void buttonSaveScript_Click(object sender, EventArgs e)
        {
            saveScriptToolStripMenuItem_Click(this, new EventArgs());
        }
        #endregion

        #region Menu Items
        private void checkedListBoxAttList_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            attList[e.Index].isChecked = e.NewValue == CheckState.Checked;
            setAttenuation(currentAttenuation);
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (checkedListBoxAttList.SelectedItem != null)
            {
                isSaved = false;
                var item = attList.Single(x => x.description == checkedListBoxAttList.SelectedItem.ToString());
                item.releasePort();
                attList.Remove(item);
                checkedListBoxAttList.Items.Remove(checkedListBoxAttList.SelectedItem);
                updateAttList();
            }

        }

        private void cloneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (checkedListBoxAttList.SelectedItem != null)
            {
                var item = attList.Single(x => x.description == checkedListBoxAttList.SelectedItem.ToString());
                editOrCloneAtt(item, true);
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (checkedListBoxAttList.SelectedItem != null)
            {
                var item = attList.Single(x => x.description == checkedListBoxAttList.SelectedItem.ToString());
                editOrCloneAtt(item, false);
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            isSaved = true;
            AttenuatorList.attList = attList;
            AttenuatorList.save();
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AttenuatorList.load();
            attList = AttenuatorList.attList;
            if (attList.Count > 0)
            {
                updateAttList();
            }
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buttonAddAtt_Click(sender, e);
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("PACMAN - Perfect Attenuation Control Manager - Airspan Networks.\n\n" +
                "This tool is an improvment of all the attenuation controls we currently use in Airspan.\n" +
                "It is very easy to use and intuitive.\n\n" +
                "User Guide:\n" +
                "Parameters Panel - Allows the user to set parameters for the Attenuator set.\n" +
                    "\tStart - Min attenuation.\n" +
                    "\tStop - Max attenuation.\n" +
                    "\tStep Size - Step size in db.\n" +
                    "\tStep Time - Step time in milliseconds.\n\n" +
                "Current Attenuation Panel - User can watch and set the current attenuation.\n" +
                    "\tFor set just change the attenuation and click \"Apply\".\n" +
                    "\tCheck the \"Auto\" checkbox for automatic apply.\n\n" +
                "Attenuator List Panel - User can watch, add or remove attenuators.\n" +
                    "\tAdd Attenuator button - Opens an add attenuator dialog.\n" +
                    "\tRemove Attenuator - By right clicking on the attenuator and select \"Remove\".\n" +
                    "\tUncheck Attenuator - The tool will ignore any unchecked attenuator.\n\n" +
                "Attenuation Control Panel - Provides various ways for moving the attenuator set.\n" +
                    "\tTrack Bar - Choses the required attenuation by clicking on the bar.\n" +
                    "\t+\\- Buttons - Increase\\Decrease attenuation by one step size.\n" +
                    "\tMin\\Max Buttons - Move attenuation step by step to min\\max attenuation.\n" +
                    "\tStart\\Stop Button - Move the attenuation up and down constantly.\n\n" +
                "Attenuator List Menu - Allows the user to save\\load Attenuator list\n" +
                "\tsave - saves the current attenuators list.\n" +
                "\tload - loads the last saved attenuators list.\n\n\n" +
                "Author - Dor Shalom, dshalom@airspan.com\n" +
                "Automation Engineer in SWIT.", "PACMAN - Help", MessageBoxButtons.OK);
        }

        private void editScriptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormScript formScript = new FormScript(stepList);
            formScript.ShowDialog();
            if (formScript.DialogResult.Equals(DialogResult.OK))
            {
                stepList = formScript.stepList;
            }
            textBoxScript.Text = "Unsaved Script";
        }
                
        private void startScriptModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelCurrentAtt.Enabled = false;
            panelParams.Enabled = false;
            panelAttList.Enabled = false;
            buttonMax.Visible = false;
            buttonMin.Visible = false;
            buttonMinus.Visible = false;
            buttonPlus.Visible = false;
            buttonStopStart.Visible = false;
            buttonScript.Visible = true;
            buttonSaveScript.Visible = true;
            buttonLoadScript.Visible = true;
            buttonEditScript.Visible = true;
            textBoxScript.Visible = true;
            labelScript.Visible = true;
        }

        private void stopScriptModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelCurrentAtt.Enabled = true;
            panelParams.Enabled = true;
            panelAttList.Enabled = true;
            buttonMax.Visible = true;
            buttonMin.Visible = true;
            buttonMinus.Visible = true;
            buttonPlus.Visible = true;
            buttonStopStart.Visible = true;
            buttonScript.Visible = false;
            buttonSaveScript.Visible = false;
            buttonLoadScript.Visible = false;
            buttonEditScript.Visible = false;
            textBoxScript.Visible = false;
            labelScript.Visible = false;
        }

        private void saveScriptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();

            sfd.Filter = "Binary Files (.bin)|*.bin|All Files (*.*)|*.*";
            sfd.FilterIndex = 1;
            sfd.RestoreDirectory = true;

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    WriteToBinaryFile<List<AttStep>>(sfd.FileName, stepList);
                    textBoxScript.Text = sfd.FileName.Split('\\').Last();
                }
                catch (Exception)
                {

                }
            }
        }

        private void loadScriptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Binary Files (.bin)|*.bin|All Files (*.*)|*.*";
            ofd.FilterIndex = 1;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    stepList = ReadFromBinaryFile<List<AttStep>>(ofd.FileName);
                    textBoxScript.Text = ofd.FileName.Split('\\').Last();
                }
                catch (Exception)
                {

                }
            }
        }
        #endregion

        #region TextBoxes
        private void textBoxCurrentAtt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonSetAtt_Click(this, new EventArgs());
                buttonSetAtt.Select();
            }
        }

        private void textBoxStart_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                changeStart();
            }
        }

        private void textBoxStart_Leave(object sender, EventArgs e)
        {
            changeStart();
        }

        private void changeStart()
        {
            isParsed = int.TryParse(textBoxStart.Text, out start);
            if (isParsed)
            {
                if (start > stop)
                {
                    MessageBox.Show("Start value cannot be larger then Stop value.\nPlease change one of them.",
                        "Wrong Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (start > currentAttenuation)
                {
                    setAttenuation(start);
                }
                trackBarAtt.Minimum = start;
                buttonMin.Text = start.ToString();
            }
        }

        private void textBoxStop_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                changeStop();
            }
        }

        private void textBoxStop_Leave(object sender, EventArgs e)
        {
            changeStop();
        }

        private void changeStop()
        {
            isParsed = int.TryParse(textBoxStop.Text, out stop);
            if (isParsed)
            {
                if (stop < start)
                {
                    MessageBox.Show("Stop value cannot be less then Start value.\nPlease change one of them.",
                        "Wrong Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (stop < currentAttenuation)
                {
                    setAttenuation(start);
                }
                trackBarAtt.Maximum = stop;
                buttonMax.Text = stop.ToString();
            }
        }

        private void textBoxStepSize_TextChanged(object sender, EventArgs e)
        {
            isParsed = int.TryParse(textBoxStepSize.Text, out stepSize);
            if (isParsed)
                trackBarAtt.TickDivide = stepSize;
        }

        private void textBoxStepTime_TextChanged(object sender, EventArgs e)
        {
            isParsed = int.TryParse(textBoxStepTime.Text, out stepTime);
        }
        #endregion

        #region Workers
        private void WorkerMoveAtt_DoWork(object sender, DoWorkEventArgs e)
        {
            moveAtt();
        }

        private void WorkerMoveMax_DoWork(object sender, DoWorkEventArgs e)
        {
            moveMax();
        }

        private void WorkerMoveMin_DoWork(object sender, DoWorkEventArgs e)
        {
            moveMin();
        }

        private void WorkerRunScript_DoWork(object sender, DoWorkEventArgs e)
        {
            runScript();
        }

        #endregion

        #region Other
        private void trackBarAtt_Scroll(object sender, ScrollEventArgs e)
        {
            setAttenuation(trackBarAtt.Value);
        }

        private void trackBarAtt_ValueChanged(object sender, EventArgs e)
        {
            setAttenuation(trackBarAtt.Value);
        }

        private void checkedListBoxAttList_MouseDown(object sender, MouseEventArgs e)
        {
            checkedListBoxAttList.SelectedIndex = checkedListBoxAttList.IndexFromPoint(e.X, e.Y);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (attList.Count > 0 && !isSaved)
            {
                if (MessageBox.Show("Do you want to save Attenuator list before close?",
                           "Save before close",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    saveToolStripMenuItem_Click(this, new EventArgs());
                }
            }
        }
        #endregion

        #endregion

        #region Methods

        private bool setAttenuation(int attenuation)
        {
            bool status = true;
            int activeAttenuators = 0;
            if (attList.Count == 0)
            {
                MessageBox.Show("There are no configured attenuators.\nPlease add attenuators.",
                    "No attenuator to set", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                IsMoving = false;
                return false;
            }
            foreach (Attenuator att in attList)
            {
                if (att.isChecked)
                {
                    status &= att.setAttenuation(attenuation);
                    if (status)
                        activeAttenuators++;
                    else
                        att.isConnected = false;
                }
            }
            if (status && activeAttenuators > 0)
            {
                currentAttenuation = attenuation;
                textBoxCurrentAtt.Text = attenuation.ToString();
                if (trackBarAtt.Value != attenuation)
                    trackBarAtt.Value = attenuation;
                pictureBoxLight.Image = Resources.green_light;
            }
            else
                pictureBoxLight.Image = Resources.red_light;
            return status;
        }

        private void moveAtt()
        {
            while (IsMoving)
            {
                startMove = DateTime.Now;
                if (directionUp)
                    buttonPlus_Click(this, new EventArgs());
                else
                    buttonMinus_Click(this, new EventArgs());
                diff = (int)(DateTime.Now - startMove).TotalMilliseconds;
                if ( diff < stepTime)
                    Thread.Sleep(stepTime - diff);
            }
        }

        private void moveMax()
        {
            directionUp = true;
            while (IsMoving)
            {
                startMove = DateTime.Now;
                if (directionUp)
                    buttonPlus_Click(this, new EventArgs());
                else
                    IsMoving = false;
                diff = (int)(DateTime.Now - startMove).TotalMilliseconds;
                if (diff < stepTime)
                    Thread.Sleep(stepTime - diff);
            }
        }

        private void moveMin()
        {
            directionUp = false;
            while (IsMoving)
            {
                startMove = DateTime.Now;
                if (!directionUp)
                    buttonMinus_Click(this, new EventArgs());
                else
                    IsMoving = false;
                diff = (int)(DateTime.Now - startMove).TotalMilliseconds;
                if (diff < stepTime)
                    Thread.Sleep(stepTime - diff);
            }
        }

        private void runScript()
        {
            int i = 0;
            if(stepList.Count == 0)
            {
                MessageBox.Show("Script is empty.\nPlease edit script.",
                    "Invalid Script", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            while (IsMoving)
            {                
                startMove = DateTime.Now;
                setAttenuation(stepList[i].att);
                diff = (int)(DateTime.Now - startMove).TotalMilliseconds;
                if (diff < stepList[i].time)
                    Thread.Sleep(stepList[i].time - diff);
                if (i == stepList.Count - 1)
                    i = 0;
                else
                    i++;
            }
        }

        private void updateAttList()
        {
            bool status = true;
            AttenuatorList.attList = attList;
            checkedListBoxAttList.Items.Clear();
            foreach (Attenuator att in attList)
            {
                if (!att.IsConnected())
                    att.isChecked = false;
                checkedListBoxAttList.Items.Add(att.description, att.isChecked);
                status &= att.isChecked;
            }
            if (status)
                pictureBoxLight.Image = Resources.green_light;
            setAttenuation(currentAttenuation);
        }

        private void editOrCloneAtt(Attenuator att, bool isClone)
        {
            FormAddAtt formAdd;
            formAdd = new FormAddAtt(att);
            formAdd.ShowDialog();
            if (formAdd.isInputOk && formAdd.DialogResult.Equals(DialogResult.OK))
            {
                isSaved = false;
                if (!isClone)
                {
                    att.releasePort();
                    attList.Remove(att);
                }
                if (!verifyNewAtt(formAdd.attenuator))
                {
                    editOrCloneAtt(formAdd.attenuator, isClone);
                    return;
                }
                if (formAdd.attenuator.Init())
                    attList.Add(formAdd.attenuator);
                else if(!isClone)
                {
                    att.Init();
                    attList.Add(att);
                }
                updateAttList();
            }
        }

        private bool verifyNewAtt(Attenuator newAtt)
        {
            foreach(Attenuator att in AttenuatorList.attList)
            {
                if(att.description == newAtt.description)
                {
                    MessageBox.Show("Couldn't add attenuator,\nAttenuator with the same description already exist.",
                        "Wrong Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                switch (newAtt.conType)
                {
                    case Enums.ConnectionTypes.Http:
                    case Enums.ConnectionTypes.Telnet:
                        if (att.ipAddress == newAtt.ipAddress && att.port == newAtt.port)
                        {
                            MessageBox.Show("Couldn't add attenuator,\nAttenuator with the same ipaddress & port already exist.",
                                "Wrong Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return false;
                        }
                        break;
                    case Enums.ConnectionTypes.Serial:
                        if (att.comPortName == newAtt.comPortName)
                        {
                            MessageBox.Show("Couldn't add attenuator,\nAttenuator with the same COM port already exist.",
                                "Wrong Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return false;
                        }
                        break;
                    case Enums.ConnectionTypes.Usb:
                        if (att.serialNumber == newAtt.serialNumber)
                        {
                            MessageBox.Show("Couldn't add attenuator,\nAttenuator with the same serial number already exist.",
                                "Wrong Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return false;
                        }
                        break;
                }
            }
            return true;
        }

        public static void WriteToBinaryFile<T>(string filePath, T objectToWrite, bool append = false)
        {
            using (Stream stream = File.Open(filePath, append ? FileMode.Append : FileMode.Create))
            {
                var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                binaryFormatter.Serialize(stream, objectToWrite);
            }
        }

        public static T ReadFromBinaryFile<T>(string filePath)
        {
            using (Stream stream = File.Open(filePath, FileMode.Open))
            {
                var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                return (T)binaryFormatter.Deserialize(stream);
            }
        }

        #endregion
    }
}
