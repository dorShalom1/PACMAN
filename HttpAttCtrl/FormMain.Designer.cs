namespace PACMAN
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.textBoxStart = new System.Windows.Forms.TextBox();
            this.textBoxStop = new System.Windows.Forms.TextBox();
            this.textBoxStepSize = new System.Windows.Forms.TextBox();
            this.textBoxStepTime = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonStopStart = new System.Windows.Forms.Button();
            this.textBoxCurrentAtt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonAddAtt = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.panelParams = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panelAttList = new System.Windows.Forms.Panel();
            this.checkedListBoxAttList = new System.Windows.Forms.CheckedListBox();
            this.contextMenuStripAttList = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cloneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelCurrentAtt = new System.Windows.Forms.Panel();
            this.buttonSetAtt = new System.Windows.Forms.Button();
            this.panelControll = new System.Windows.Forms.Panel();
            this.buttonScript = new System.Windows.Forms.Button();
            this.trackBarAtt = new ColorSlider.ColorSlider();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonMin = new System.Windows.Forms.Button();
            this.buttonMax = new System.Windows.Forms.Button();
            this.buttonPlus = new System.Windows.Forms.Button();
            this.buttonMinus = new System.Windows.Forms.Button();
            this.WorkerMoveAtt = new System.ComponentModel.BackgroundWorker();
            this.WorkerMoveMax = new System.ComponentModel.BackgroundWorker();
            this.WorkerMoveMin = new System.ComponentModel.BackgroundWorker();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.saveAttListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scriptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editScriptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startScriptModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopScriptModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxLight = new System.Windows.Forms.PictureBox();
            this.WorkerRunScript = new System.ComponentModel.BackgroundWorker();
            this.loadScriptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveScriptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonEditScript = new System.Windows.Forms.Button();
            this.buttonLoadScript = new System.Windows.Forms.Button();
            this.buttonSaveScript = new System.Windows.Forms.Button();
            this.labelScript = new System.Windows.Forms.Label();
            this.textBoxScript = new System.Windows.Forms.TextBox();
            this.panelParams.SuspendLayout();
            this.panelAttList.SuspendLayout();
            this.contextMenuStripAttList.SuspendLayout();
            this.panelCurrentAtt.SuspendLayout();
            this.panelControll.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLight)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxStart
            // 
            this.textBoxStart.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxStart.Location = new System.Drawing.Point(11, 49);
            this.textBoxStart.Name = "textBoxStart";
            this.textBoxStart.Size = new System.Drawing.Size(72, 20);
            this.textBoxStart.TabIndex = 0;
            this.textBoxStart.Text = "0";
            this.textBoxStart.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxStart.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxStart_KeyDown);
            this.textBoxStart.Leave += new System.EventHandler(this.textBoxStart_Leave);
            // 
            // textBoxStop
            // 
            this.textBoxStop.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxStop.Location = new System.Drawing.Point(11, 94);
            this.textBoxStop.Name = "textBoxStop";
            this.textBoxStop.Size = new System.Drawing.Size(72, 20);
            this.textBoxStop.TabIndex = 1;
            this.textBoxStop.Text = "30";
            this.textBoxStop.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxStop.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxStop_KeyDown);
            this.textBoxStop.Leave += new System.EventHandler(this.textBoxStop_Leave);
            // 
            // textBoxStepSize
            // 
            this.textBoxStepSize.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxStepSize.Location = new System.Drawing.Point(11, 139);
            this.textBoxStepSize.Name = "textBoxStepSize";
            this.textBoxStepSize.Size = new System.Drawing.Size(72, 20);
            this.textBoxStepSize.TabIndex = 2;
            this.textBoxStepSize.Text = "2";
            this.textBoxStepSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxStepSize.TextChanged += new System.EventHandler(this.textBoxStepSize_TextChanged);
            // 
            // textBoxStepTime
            // 
            this.textBoxStepTime.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxStepTime.Location = new System.Drawing.Point(11, 184);
            this.textBoxStepTime.Name = "textBoxStepTime";
            this.textBoxStepTime.Size = new System.Drawing.Size(72, 20);
            this.textBoxStepTime.TabIndex = 3;
            this.textBoxStepTime.Text = "500";
            this.textBoxStepTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxStepTime.TextChanged += new System.EventHandler(this.textBoxStepTime_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(11, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Start [dB]";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(11, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Stop [dB]";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(11, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Step size [dB]";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(11, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Step time [ms]";
            // 
            // buttonStopStart
            // 
            this.buttonStopStart.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonStopStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStopStart.Location = new System.Drawing.Point(100, 157);
            this.buttonStopStart.Name = "buttonStopStart";
            this.buttonStopStart.Size = new System.Drawing.Size(75, 25);
            this.buttonStopStart.TabIndex = 8;
            this.buttonStopStart.Text = "Start/Stop";
            this.buttonStopStart.UseVisualStyleBackColor = false;
            this.buttonStopStart.Click += new System.EventHandler(this.buttonStopStart_Click);
            // 
            // textBoxCurrentAtt
            // 
            this.textBoxCurrentAtt.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxCurrentAtt.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCurrentAtt.ForeColor = System.Drawing.Color.Blue;
            this.textBoxCurrentAtt.Location = new System.Drawing.Point(20, 28);
            this.textBoxCurrentAtt.MaximumSize = new System.Drawing.Size(72, 72);
            this.textBoxCurrentAtt.Name = "textBoxCurrentAtt";
            this.textBoxCurrentAtt.Size = new System.Drawing.Size(72, 68);
            this.textBoxCurrentAtt.TabIndex = 9;
            this.textBoxCurrentAtt.Text = "0";
            this.textBoxCurrentAtt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxCurrentAtt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxCurrentAtt_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(17, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Current Attenuation";
            // 
            // buttonAddAtt
            // 
            this.buttonAddAtt.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.buttonAddAtt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddAtt.Location = new System.Drawing.Point(13, 75);
            this.buttonAddAtt.Name = "buttonAddAtt";
            this.buttonAddAtt.Size = new System.Drawing.Size(132, 23);
            this.buttonAddAtt.TabIndex = 13;
            this.buttonAddAtt.Text = "Add Attenuator";
            this.buttonAddAtt.UseVisualStyleBackColor = false;
            this.buttonAddAtt.Click += new System.EventHandler(this.buttonAddAtt_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(36, 2);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Attenuators list";
            // 
            // panelParams
            // 
            this.panelParams.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panelParams.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelParams.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelParams.Controls.Add(this.label7);
            this.panelParams.Controls.Add(this.textBoxStart);
            this.panelParams.Controls.Add(this.textBoxStop);
            this.panelParams.Controls.Add(this.textBoxStepSize);
            this.panelParams.Controls.Add(this.textBoxStepTime);
            this.panelParams.Controls.Add(this.label1);
            this.panelParams.Controls.Add(this.label2);
            this.panelParams.Controls.Add(this.label3);
            this.panelParams.Controls.Add(this.label4);
            this.panelParams.Location = new System.Drawing.Point(9, 36);
            this.panelParams.Name = "panelParams";
            this.panelParams.Size = new System.Drawing.Size(100, 220);
            this.panelParams.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(8, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 15);
            this.label7.TabIndex = 8;
            this.label7.Text = "Parameters";
            // 
            // panelAttList
            // 
            this.panelAttList.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panelAttList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelAttList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelAttList.Controls.Add(this.checkedListBoxAttList);
            this.panelAttList.Controls.Add(this.buttonAddAtt);
            this.panelAttList.Controls.Add(this.label6);
            this.panelAttList.Location = new System.Drawing.Point(115, 149);
            this.panelAttList.Name = "panelAttList";
            this.panelAttList.Size = new System.Drawing.Size(167, 107);
            this.panelAttList.TabIndex = 16;
            // 
            // checkedListBoxAttList
            // 
            this.checkedListBoxAttList.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.checkedListBoxAttList.ContextMenuStrip = this.contextMenuStripAttList;
            this.checkedListBoxAttList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBoxAttList.ForeColor = System.Drawing.SystemColors.WindowText;
            this.checkedListBoxAttList.FormattingEnabled = true;
            this.checkedListBoxAttList.Location = new System.Drawing.Point(13, 20);
            this.checkedListBoxAttList.Name = "checkedListBoxAttList";
            this.checkedListBoxAttList.Size = new System.Drawing.Size(132, 49);
            this.checkedListBoxAttList.TabIndex = 15;
            this.checkedListBoxAttList.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBoxAttList_ItemCheck);
            this.checkedListBoxAttList.MouseDown += new System.Windows.Forms.MouseEventHandler(this.checkedListBoxAttList_MouseDown);
            // 
            // contextMenuStripAttList
            // 
            this.contextMenuStripAttList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removeToolStripMenuItem,
            this.editToolStripMenuItem,
            this.cloneToolStripMenuItem});
            this.contextMenuStripAttList.Name = "contextMenuStripAttList";
            this.contextMenuStripAttList.Size = new System.Drawing.Size(118, 70);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.removeToolStripMenuItem.Text = "Remove";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.removeToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // cloneToolStripMenuItem
            // 
            this.cloneToolStripMenuItem.Name = "cloneToolStripMenuItem";
            this.cloneToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.cloneToolStripMenuItem.Text = "Clone";
            this.cloneToolStripMenuItem.Click += new System.EventHandler(this.cloneToolStripMenuItem_Click);
            // 
            // panelCurrentAtt
            // 
            this.panelCurrentAtt.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panelCurrentAtt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelCurrentAtt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCurrentAtt.Controls.Add(this.buttonSetAtt);
            this.panelCurrentAtt.Controls.Add(this.textBoxCurrentAtt);
            this.panelCurrentAtt.Controls.Add(this.label5);
            this.panelCurrentAtt.Location = new System.Drawing.Point(115, 36);
            this.panelCurrentAtt.Name = "panelCurrentAtt";
            this.panelCurrentAtt.Size = new System.Drawing.Size(167, 107);
            this.panelCurrentAtt.TabIndex = 17;
            // 
            // buttonSetAtt
            // 
            this.buttonSetAtt.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.buttonSetAtt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSetAtt.Location = new System.Drawing.Point(97, 69);
            this.buttonSetAtt.Name = "buttonSetAtt";
            this.buttonSetAtt.Size = new System.Drawing.Size(49, 27);
            this.buttonSetAtt.TabIndex = 15;
            this.buttonSetAtt.Text = "Apply";
            this.buttonSetAtt.UseVisualStyleBackColor = false;
            this.buttonSetAtt.Click += new System.EventHandler(this.buttonSetAtt_Click);
            // 
            // panelControll
            // 
            this.panelControll.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panelControll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelControll.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelControll.Controls.Add(this.textBoxScript);
            this.panelControll.Controls.Add(this.labelScript);
            this.panelControll.Controls.Add(this.buttonSaveScript);
            this.panelControll.Controls.Add(this.buttonLoadScript);
            this.panelControll.Controls.Add(this.buttonEditScript);
            this.panelControll.Controls.Add(this.buttonScript);
            this.panelControll.Controls.Add(this.trackBarAtt);
            this.panelControll.Controls.Add(this.label8);
            this.panelControll.Controls.Add(this.buttonMin);
            this.panelControll.Controls.Add(this.buttonMax);
            this.panelControll.Controls.Add(this.buttonPlus);
            this.panelControll.Controls.Add(this.buttonMinus);
            this.panelControll.Controls.Add(this.buttonStopStart);
            this.panelControll.Location = new System.Drawing.Point(288, 36);
            this.panelControll.Name = "panelControll";
            this.panelControll.Size = new System.Drawing.Size(283, 220);
            this.panelControll.TabIndex = 18;
            // 
            // buttonScript
            // 
            this.buttonScript.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.buttonScript.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonScript.Location = new System.Drawing.Point(79, 158);
            this.buttonScript.Name = "buttonScript";
            this.buttonScript.Size = new System.Drawing.Size(116, 25);
            this.buttonScript.TabIndex = 23;
            this.buttonScript.Text = "Start/Stop Script";
            this.buttonScript.UseVisualStyleBackColor = false;
            this.buttonScript.Visible = false;
            this.buttonScript.Click += new System.EventHandler(this.buttonScript_Click);
            // 
            // trackBarAtt
            // 
            this.trackBarAtt.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.trackBarAtt.BarPenColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(94)))), ((int)(((byte)(110)))));
            this.trackBarAtt.BarPenColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(60)))), ((int)(((byte)(74)))));
            this.trackBarAtt.BorderRoundRectSize = new System.Drawing.Size(8, 8);
            this.trackBarAtt.ColorSchema = ColorSlider.ColorSlider.ColorSchemas.GreenColors;
            this.trackBarAtt.ElapsedInnerColor = System.Drawing.Color.Green;
            this.trackBarAtt.ElapsedPenColorBottom = System.Drawing.Color.LightGreen;
            this.trackBarAtt.ElapsedPenColorTop = System.Drawing.Color.SpringGreen;
            this.trackBarAtt.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F);
            this.trackBarAtt.ForeColor = System.Drawing.SystemColors.ControlText;
            this.trackBarAtt.LargeChange = ((uint)(5u));
            this.trackBarAtt.Location = new System.Drawing.Point(42, 111);
            this.trackBarAtt.Maximum = 30;
            this.trackBarAtt.Name = "trackBarAtt";
            this.trackBarAtt.ScaleDivisions = 10;
            this.trackBarAtt.ScaleSubDivisions = 5;
            this.trackBarAtt.ShowDivisionsText = true;
            this.trackBarAtt.ShowSmallScale = false;
            this.trackBarAtt.Size = new System.Drawing.Size(200, 39);
            this.trackBarAtt.SmallChange = ((uint)(1u));
            this.trackBarAtt.TabIndex = 22;
            this.trackBarAtt.ThumbImage = ((System.Drawing.Image)(resources.GetObject("trackBarAtt.ThumbImage")));
            this.trackBarAtt.ThumbInnerColor = System.Drawing.Color.Transparent;
            this.trackBarAtt.ThumbOuterColor = System.Drawing.Color.Transparent;
            this.trackBarAtt.ThumbPenColor = System.Drawing.SystemColors.ButtonFace;
            this.trackBarAtt.ThumbRoundRectSize = new System.Drawing.Size(16, 16);
            this.trackBarAtt.ThumbSize = new System.Drawing.Size(16, 16);
            this.trackBarAtt.TickAdd = 0F;
            this.trackBarAtt.TickColor = System.Drawing.Color.Yellow;
            this.trackBarAtt.TickDivide = 0F;
            this.trackBarAtt.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarAtt.Value = 0;
            this.trackBarAtt.ValueChanged += new System.EventHandler(this.trackBarAtt_ValueChanged);
            this.trackBarAtt.Scroll += new System.Windows.Forms.ScrollEventHandler(this.trackBarAtt_Scroll);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(76, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(129, 15);
            this.label8.TabIndex = 21;
            this.label8.Text = "Attenuation Control";
            // 
            // buttonMin
            // 
            this.buttonMin.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.buttonMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMin.Location = new System.Drawing.Point(3, 113);
            this.buttonMin.Name = "buttonMin";
            this.buttonMin.Size = new System.Drawing.Size(35, 32);
            this.buttonMin.TabIndex = 20;
            this.buttonMin.Text = "0";
            this.buttonMin.UseVisualStyleBackColor = false;
            this.buttonMin.Click += new System.EventHandler(this.buttonMin_Click);
            // 
            // buttonMax
            // 
            this.buttonMax.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.buttonMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMax.Location = new System.Drawing.Point(246, 115);
            this.buttonMax.Name = "buttonMax";
            this.buttonMax.Size = new System.Drawing.Size(35, 32);
            this.buttonMax.TabIndex = 19;
            this.buttonMax.Text = "30";
            this.buttonMax.UseVisualStyleBackColor = false;
            this.buttonMax.Click += new System.EventHandler(this.buttonMax_Click);
            // 
            // buttonPlus
            // 
            this.buttonPlus.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.buttonPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPlus.Location = new System.Drawing.Point(143, 49);
            this.buttonPlus.Name = "buttonPlus";
            this.buttonPlus.Size = new System.Drawing.Size(32, 46);
            this.buttonPlus.TabIndex = 18;
            this.buttonPlus.Text = "+";
            this.buttonPlus.UseVisualStyleBackColor = false;
            this.buttonPlus.Click += new System.EventHandler(this.buttonPlus_Click);
            // 
            // buttonMinus
            // 
            this.buttonMinus.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.buttonMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMinus.Location = new System.Drawing.Point(100, 49);
            this.buttonMinus.Name = "buttonMinus";
            this.buttonMinus.Size = new System.Drawing.Size(32, 46);
            this.buttonMinus.TabIndex = 17;
            this.buttonMinus.Text = "-";
            this.buttonMinus.UseVisualStyleBackColor = false;
            this.buttonMinus.Click += new System.EventHandler(this.buttonMinus_Click);
            // 
            // WorkerMoveAtt
            // 
            this.WorkerMoveAtt.DoWork += new System.ComponentModel.DoWorkEventHandler(this.WorkerMoveAtt_DoWork);
            // 
            // WorkerMoveMax
            // 
            this.WorkerMoveMax.DoWork += new System.ComponentModel.DoWorkEventHandler(this.WorkerMoveMax_DoWork);
            // 
            // WorkerMoveMin
            // 
            this.WorkerMoveMin.DoWork += new System.ComponentModel.DoWorkEventHandler(this.WorkerMoveMin_DoWork);
            // 
            // menuStrip1
            // 
            this.menuStrip1.AccessibleDescription = "";
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.menuStrip1.BackgroundImage = global::PACMAN.Properties.Resources.pacmanMenu;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveAttListToolStripMenuItem,
            this.scriptToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(580, 28);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormMain_MouseDown);
            // 
            // saveAttListToolStripMenuItem
            // 
            this.saveAttListToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.loadToolStripMenuItem,
            this.addToolStripMenuItem});
            this.saveAttListToolStripMenuItem.Name = "saveAttListToolStripMenuItem";
            this.saveAttListToolStripMenuItem.Size = new System.Drawing.Size(124, 24);
            this.saveAttListToolStripMenuItem.Text = "AttenuatorList";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(112, 24);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(112, 24);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(112, 24);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // scriptToolStripMenuItem
            // 
            this.scriptToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startScriptModeToolStripMenuItem,
            this.stopScriptModeToolStripMenuItem,
            this.editScriptToolStripMenuItem,
            this.loadScriptToolStripMenuItem,
            this.saveScriptToolStripMenuItem});
            this.scriptToolStripMenuItem.Name = "scriptToolStripMenuItem";
            this.scriptToolStripMenuItem.Size = new System.Drawing.Size(61, 24);
            this.scriptToolStripMenuItem.Text = "Script";
            // 
            // editScriptToolStripMenuItem
            // 
            this.editScriptToolStripMenuItem.Name = "editScriptToolStripMenuItem";
            this.editScriptToolStripMenuItem.Size = new System.Drawing.Size(200, 24);
            this.editScriptToolStripMenuItem.Text = "Edit Script";
            this.editScriptToolStripMenuItem.Click += new System.EventHandler(this.editScriptToolStripMenuItem_Click);
            // 
            // startScriptModeToolStripMenuItem
            // 
            this.startScriptModeToolStripMenuItem.Name = "startScriptModeToolStripMenuItem";
            this.startScriptModeToolStripMenuItem.Size = new System.Drawing.Size(200, 24);
            this.startScriptModeToolStripMenuItem.Text = "Start Script Mode";
            this.startScriptModeToolStripMenuItem.Click += new System.EventHandler(this.startScriptModeToolStripMenuItem_Click);
            // 
            // stopScriptModeToolStripMenuItem
            // 
            this.stopScriptModeToolStripMenuItem.Name = "stopScriptModeToolStripMenuItem";
            this.stopScriptModeToolStripMenuItem.Size = new System.Drawing.Size(200, 24);
            this.stopScriptModeToolStripMenuItem.Text = "Stop Script Mode";
            this.stopScriptModeToolStripMenuItem.Click += new System.EventHandler(this.stopScriptModeToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::PACMAN.Properties.Resources.pacmanMenu;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::PACMAN.Properties.Resources.pacmanX1;
            this.pictureBox1.Location = new System.Drawing.Point(544, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBoxLight
            // 
            this.pictureBoxLight.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxLight.BackgroundImage = global::PACMAN.Properties.Resources.pacmanMenu;
            this.pictureBoxLight.Image = global::PACMAN.Properties.Resources.red_light;
            this.pictureBoxLight.Location = new System.Drawing.Point(510, -1);
            this.pictureBoxLight.Name = "pictureBoxLight";
            this.pictureBoxLight.Size = new System.Drawing.Size(29, 29);
            this.pictureBoxLight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLight.TabIndex = 22;
            this.pictureBoxLight.TabStop = false;
            // 
            // WorkerRunScript
            // 
            this.WorkerRunScript.DoWork += new System.ComponentModel.DoWorkEventHandler(this.WorkerRunScript_DoWork);
            // 
            // loadScriptToolStripMenuItem
            // 
            this.loadScriptToolStripMenuItem.Name = "loadScriptToolStripMenuItem";
            this.loadScriptToolStripMenuItem.Size = new System.Drawing.Size(200, 24);
            this.loadScriptToolStripMenuItem.Text = "Load Script";
            this.loadScriptToolStripMenuItem.Click += new System.EventHandler(this.loadScriptToolStripMenuItem_Click);
            // 
            // saveScriptToolStripMenuItem
            // 
            this.saveScriptToolStripMenuItem.Name = "saveScriptToolStripMenuItem";
            this.saveScriptToolStripMenuItem.Size = new System.Drawing.Size(200, 24);
            this.saveScriptToolStripMenuItem.Text = "Save Script";
            this.saveScriptToolStripMenuItem.Click += new System.EventHandler(this.saveScriptToolStripMenuItem_Click);
            // 
            // buttonEditScript
            // 
            this.buttonEditScript.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.buttonEditScript.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditScript.Location = new System.Drawing.Point(39, 70);
            this.buttonEditScript.Name = "buttonEditScript";
            this.buttonEditScript.Size = new System.Drawing.Size(51, 25);
            this.buttonEditScript.TabIndex = 24;
            this.buttonEditScript.Text = "Edit";
            this.buttonEditScript.UseVisualStyleBackColor = false;
            this.buttonEditScript.Visible = false;
            this.buttonEditScript.Click += new System.EventHandler(this.buttonEditScript_Click);
            // 
            // buttonLoadScript
            // 
            this.buttonLoadScript.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.buttonLoadScript.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLoadScript.Location = new System.Drawing.Point(115, 70);
            this.buttonLoadScript.Name = "buttonLoadScript";
            this.buttonLoadScript.Size = new System.Drawing.Size(51, 25);
            this.buttonLoadScript.TabIndex = 25;
            this.buttonLoadScript.Text = "Load";
            this.buttonLoadScript.UseVisualStyleBackColor = false;
            this.buttonLoadScript.Visible = false;
            this.buttonLoadScript.Click += new System.EventHandler(this.buttonLoadScript_Click);
            // 
            // buttonSaveScript
            // 
            this.buttonSaveScript.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.buttonSaveScript.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSaveScript.Location = new System.Drawing.Point(192, 69);
            this.buttonSaveScript.Name = "buttonSaveScript";
            this.buttonSaveScript.Size = new System.Drawing.Size(51, 25);
            this.buttonSaveScript.TabIndex = 26;
            this.buttonSaveScript.Text = "Save";
            this.buttonSaveScript.UseVisualStyleBackColor = false;
            this.buttonSaveScript.Visible = false;
            this.buttonSaveScript.Click += new System.EventHandler(this.buttonSaveScript_Click);
            // 
            // labelScript
            // 
            this.labelScript.AutoSize = true;
            this.labelScript.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelScript.Enabled = false;
            this.labelScript.ForeColor = System.Drawing.Color.White;
            this.labelScript.Location = new System.Drawing.Point(40, 37);
            this.labelScript.Name = "labelScript";
            this.labelScript.Size = new System.Drawing.Size(34, 13);
            this.labelScript.TabIndex = 9;
            this.labelScript.Text = "Script";
            this.labelScript.Visible = false;
            // 
            // textBoxScript
            // 
            this.textBoxScript.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxScript.Location = new System.Drawing.Point(79, 34);
            this.textBoxScript.Name = "textBoxScript";
            this.textBoxScript.ReadOnly = true;
            this.textBoxScript.Size = new System.Drawing.Size(163, 20);
            this.textBoxScript.TabIndex = 27;
            this.textBoxScript.Text = "No Script";
            this.textBoxScript.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxScript.Visible = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(580, 265);
            this.Controls.Add(this.pictureBoxLight);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panelControll);
            this.Controls.Add(this.panelCurrentAtt);
            this.Controls.Add(this.panelAttList);
            this.Controls.Add(this.panelParams);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PACMAN - Attenuator Control";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormMain_MouseDown);
            this.panelParams.ResumeLayout(false);
            this.panelParams.PerformLayout();
            this.panelAttList.ResumeLayout(false);
            this.panelAttList.PerformLayout();
            this.contextMenuStripAttList.ResumeLayout(false);
            this.panelCurrentAtt.ResumeLayout(false);
            this.panelCurrentAtt.PerformLayout();
            this.panelControll.ResumeLayout(false);
            this.panelControll.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxStart;
        private System.Windows.Forms.TextBox textBoxStop;
        private System.Windows.Forms.TextBox textBoxStepSize;
        private System.Windows.Forms.TextBox textBoxStepTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonStopStart;
        private System.Windows.Forms.TextBox textBoxCurrentAtt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonAddAtt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panelParams;
        private System.Windows.Forms.Panel panelAttList;
        private System.Windows.Forms.Panel panelCurrentAtt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panelControll;
        private System.Windows.Forms.Button buttonSetAtt;
        private System.Windows.Forms.CheckedListBox checkedListBoxAttList;
        private System.Windows.Forms.Button buttonMinus;
        private System.Windows.Forms.Button buttonPlus;
        private System.ComponentModel.BackgroundWorker WorkerMoveAtt;
        private System.Windows.Forms.Button buttonMin;
        private System.Windows.Forms.Button buttonMax;
        private System.ComponentModel.BackgroundWorker WorkerMoveMax;
        private System.ComponentModel.BackgroundWorker WorkerMoveMin;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripAttList;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem saveAttListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private ColorSlider.ColorSlider trackBarAtt;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem cloneToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBoxLight;
        private System.Windows.Forms.ToolStripMenuItem scriptToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editScriptToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startScriptModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopScriptModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.Button buttonScript;
        private System.ComponentModel.BackgroundWorker WorkerRunScript;
        private System.Windows.Forms.ToolStripMenuItem loadScriptToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveScriptToolStripMenuItem;
        private System.Windows.Forms.Button buttonSaveScript;
        private System.Windows.Forms.Button buttonLoadScript;
        private System.Windows.Forms.Button buttonEditScript;
        private System.Windows.Forms.TextBox textBoxScript;
        private System.Windows.Forms.Label labelScript;
    }
}

