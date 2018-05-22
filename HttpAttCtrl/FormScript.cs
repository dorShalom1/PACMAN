using PACMAN.Objects;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PACMAN
{
    public partial class FormScript : Form
    {
        public bool isInputOk = false;
        public List<AttStep> stepList;
        private AttStep newStep;

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

        public FormScript(List<AttStep> StepList)
        {
            InitializeComponent();
            if (StepList == null)
                stepList = new List<AttStep>();
            else
            {
                stepList = StepList;
                updateGridView();
            }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            isInputOk = true;
            if (!verifyInputs())
                return;
            updateStepList();
            if (isInputOk)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void updateStepList()
        {
            stepList.Clear();
            bool parseSucceeded;
            foreach (DataGridViewRow row in dataGridViewScript.Rows)
            {
                if (row.Cells[1].Value == null)
                    continue;
                newStep = new AttStep();
                parseSucceeded = int.TryParse(row.Cells[0].Value.ToString(), out newStep.att);
                parseSucceeded &= int.TryParse(row.Cells[1].Value.ToString(), out newStep.time);
                if (!parseSucceeded)
                {
                    isInputOk = false;
                    break;
                }
                stepList.Add(newStep);
            }
        }

        private void updateGridView()
        {
            dataGridViewScript.Rows.Clear();
            dataGridViewScript.Rows.Add(stepList.Count);
            int i = 0;
            foreach (AttStep step in stepList)
            {
                dataGridViewScript.Rows[i].Cells[0].Value = step.att.ToString();
                dataGridViewScript.Rows[i].Cells[1].Value = step.time.ToString();
                i++;
            }
        }

        private bool verifyInputs()
        {
            int x;
            foreach(DataGridViewRow row in dataGridViewScript.Rows)
            {
                foreach(DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null && !int.TryParse(cell.Value.ToString(), out x))
                    {
                        MessageBox.Show("The values should contain numbers only!",
                        "Wrong Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                }
            }
            return true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
