namespace MojRobot
{
    partial class Form1
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
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cOMPORTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBoxComPort = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripMenuItemComConnect = new System.Windows.Forms.ToolStripMenuItem();
            this.editorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeSerialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelDrag = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.trackBar4 = new System.Windows.Forms.TrackBar();
            this.trackBar3 = new System.Windows.Forms.TrackBar();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.lbl_Zglob2 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.jointContol1 = new MojRobot.JointContol();
            this.jointContol2 = new MojRobot.JointContol();
            this.jointContol3 = new MojRobot.JointContol();
            this.jointContol4 = new MojRobot.JointContol();
            this.jointContol5 = new MojRobot.JointContol();
            this.jointContol6 = new MojRobot.JointContol();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1472, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cOMPORTToolStripMenuItem,
            this.toolStripMenuItemComConnect,
            this.editorToolStripMenuItem,
            this.closeSerialToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // cOMPORTToolStripMenuItem
            // 
            this.cOMPORTToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBoxComPort});
            this.cOMPORTToolStripMenuItem.Name = "cOMPORTToolStripMenuItem";
            this.cOMPORTToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.cOMPORTToolStripMenuItem.Text = "COM PORT";
            // 
            // toolStripComboBoxComPort
            // 
            this.toolStripComboBoxComPort.Name = "toolStripComboBoxComPort";
            this.toolStripComboBoxComPort.Size = new System.Drawing.Size(121, 23);
            // 
            // toolStripMenuItemComConnect
            // 
            this.toolStripMenuItemComConnect.Name = "toolStripMenuItemComConnect";
            this.toolStripMenuItemComConnect.Size = new System.Drawing.Size(134, 22);
            this.toolStripMenuItemComConnect.Text = "Connect";
            this.toolStripMenuItemComConnect.Click += new System.EventHandler(this.toolStripMenuItemComConnect_Click);
            // 
            // editorToolStripMenuItem
            // 
            this.editorToolStripMenuItem.Name = "editorToolStripMenuItem";
            this.editorToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.editorToolStripMenuItem.Text = "Editor";
            this.editorToolStripMenuItem.Click += new System.EventHandler(this.editorToolStripMenuItem_Click);
            // 
            // closeSerialToolStripMenuItem
            // 
            this.closeSerialToolStripMenuItem.Name = "closeSerialToolStripMenuItem";
            this.closeSerialToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.closeSerialToolStripMenuItem.Text = "Close Serial";
            this.closeSerialToolStripMenuItem.Click += new System.EventHandler(this.closeSerialToolStripMenuItem_Click);
            // 
            // panelDrag
            // 
            this.panelDrag.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.panelDrag.Location = new System.Drawing.Point(25, 27);
            this.panelDrag.Name = "panelDrag";
            this.panelDrag.Size = new System.Drawing.Size(1395, 43);
            this.panelDrag.TabIndex = 26;
            this.panelDrag.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelDrag_MouseDown);
            this.panelDrag.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelDrag_MouseMove);
            this.panelDrag.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelDrag_MouseUp);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1258, 123);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 70);
            this.button1.TabIndex = 35;
            this.button1.Text = "Snimi Poziciju 1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1258, 222);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(167, 70);
            this.button2.TabIndex = 36;
            this.button2.Text = "Snimi Poziciju 2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // trackBar4
            // 
            this.trackBar4.Location = new System.Drawing.Point(407, 247);
            this.trackBar4.Maximum = 180;
            this.trackBar4.Name = "trackBar4";
            this.trackBar4.Size = new System.Drawing.Size(610, 45);
            this.trackBar4.TabIndex = 13;
            this.trackBar4.Visible = false;
            this.trackBar4.MouseUp += new System.Windows.Forms.MouseEventHandler(this.trackBar4_MouseUp);
            // 
            // trackBar3
            // 
            this.trackBar3.Location = new System.Drawing.Point(407, 196);
            this.trackBar3.Maximum = 180;
            this.trackBar3.Name = "trackBar3";
            this.trackBar3.Size = new System.Drawing.Size(610, 45);
            this.trackBar3.TabIndex = 12;
            this.trackBar3.Visible = false;
            this.trackBar3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.trackBar3_MouseUp);
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(407, 123);
            this.trackBar2.Maximum = 180;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(610, 45);
            this.trackBar2.TabIndex = 11;
            this.trackBar2.Visible = false;
            this.trackBar2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.trackBar2_MouseUp);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(407, 56);
            this.trackBar1.Maximum = 180;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(610, 45);
            this.trackBar1.TabIndex = 3;
            this.trackBar1.Visible = false;
            this.trackBar1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.trackBar1_MouseUp);
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.Color.LawnGreen;
            this.btn_Exit.FlatAppearance.BorderSize = 0;
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Exit.ForeColor = System.Drawing.Color.Black;
            this.btn_Exit.Location = new System.Drawing.Point(1439, 36);
            this.btn_Exit.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(24, 25);
            this.btn_Exit.TabIndex = 39;
            this.btn_Exit.TabStop = false;
            this.btn_Exit.Text = "X";
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // lbl_Zglob2
            // 
            this.lbl_Zglob2.AutoSize = true;
            this.lbl_Zglob2.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Zglob2.CausesValidation = false;
            this.lbl_Zglob2.Font = new System.Drawing.Font("Segoe UI Emoji", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Zglob2.ForeColor = System.Drawing.Color.Lime;
            this.lbl_Zglob2.Location = new System.Drawing.Point(1152, 277);
            this.lbl_Zglob2.Name = "lbl_Zglob2";
            this.lbl_Zglob2.Size = new System.Drawing.Size(71, 44);
            this.lbl_Zglob2.TabIndex = 31;
            this.lbl_Zglob2.Text = "90°";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.jointContol1);
            this.flowLayoutPanel1.Controls.Add(this.jointContol2);
            this.flowLayoutPanel1.Controls.Add(this.jointContol3);
            this.flowLayoutPanel1.Controls.Add(this.jointContol4);
            this.flowLayoutPanel1.Controls.Add(this.jointContol5);
            this.flowLayoutPanel1.Controls.Add(this.jointContol6);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 289);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1472, 355);
            this.flowLayoutPanel1.TabIndex = 40;
            // 
            // jointContol1
            // 
            this.jointContol1.CustomJointName = "Platfroma";
            this.jointContol1.Location = new System.Drawing.Point(3, 3);
            this.jointContol1.Name = "jointContol1";
            this.jointContol1.serialPort = this.serialPort1;
            this.jointContol1.Size = new System.Drawing.Size(345, 359);
            this.jointContol1.strMotor = "a";
            this.jointContol1.TabIndex = 0;
            // 
            // jointContol2
            // 
            this.jointContol2.CustomJointName = "Zglob1";
            this.jointContol2.Location = new System.Drawing.Point(354, 3);
            this.jointContol2.Name = "jointContol2";
            this.jointContol2.serialPort = this.serialPort1;
            this.jointContol2.Size = new System.Drawing.Size(345, 359);
            this.jointContol2.strMotor = "b";
            this.jointContol2.TabIndex = 1;
            // 
            // jointContol3
            // 
            this.jointContol3.CustomJointName = "Zglob2";
            this.jointContol3.Location = new System.Drawing.Point(705, 3);
            this.jointContol3.Name = "jointContol3";
            this.jointContol3.serialPort = this.serialPort1;
            this.jointContol3.Size = new System.Drawing.Size(345, 359);
            this.jointContol3.strMotor = "c";
            this.jointContol3.TabIndex = 2;
            // 
            // jointContol4
            // 
            this.jointContol4.CustomJointName = "Zglob3";
            this.jointContol4.Location = new System.Drawing.Point(1056, 3);
            this.jointContol4.Name = "jointContol4";
            this.jointContol4.serialPort = this.serialPort1;
            this.jointContol4.Size = new System.Drawing.Size(345, 359);
            this.jointContol4.strMotor = "d";
            this.jointContol4.TabIndex = 3;
            // 
            // jointContol5
            // 
            this.jointContol5.CustomJointName = "EndRot";
            this.jointContol5.Location = new System.Drawing.Point(3, 368);
            this.jointContol5.Name = "jointContol5";
            this.jointContol5.serialPort = this.serialPort1;
            this.jointContol5.Size = new System.Drawing.Size(345, 359);
            this.jointContol5.strMotor = "e";
            this.jointContol5.TabIndex = 4;
            // 
            // jointContol6
            // 
            this.jointContol6.CustomJointName = "Hvataljka";
            this.jointContol6.Location = new System.Drawing.Point(354, 368);
            this.jointContol6.Name = "jointContol6";
            this.jointContol6.serialPort = this.serialPort1;
            this.jointContol6.Size = new System.Drawing.Size(345, 359);
            this.jointContol6.strMotor = "f";
            this.jointContol6.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(1472, 644);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.lbl_Zglob2);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panelDrag);
            this.Controls.Add(this.trackBar4);
            this.Controls.Add(this.trackBar3);
            this.Controls.Add(this.trackBar2);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cOMPORTToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBoxComPort;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemComConnect;
        private System.Windows.Forms.Panel panelDrag;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TrackBar trackBar4;
        private System.Windows.Forms.TrackBar trackBar3;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.ToolStripMenuItem editorToolStripMenuItem;
        private System.Windows.Forms.Button btn_Exit;
        public System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label lbl_Zglob2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private JointContol jointContol1;
        private JointContol jointContol2;
        private JointContol jointContol3;
        private JointContol jointContol4;
        private JointContol jointContol5;
        private JointContol jointContol6;
        private System.Windows.Forms.ToolStripMenuItem closeSerialToolStripMenuItem;
    }
}

