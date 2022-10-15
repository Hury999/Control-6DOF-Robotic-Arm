
namespace MojRobot
{
    partial class JointContol
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_Zglob1 = new System.Windows.Forms.Label();
            this.circProgressB = new CircularProgressBar.CircularProgressBar();
            this.lbl_Angle = new System.Windows.Forms.Label();
            this.lbl_JointName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_Zglob1
            // 
            this.lbl_Zglob1.AutoSize = true;
            this.lbl_Zglob1.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Zglob1.CausesValidation = false;
            this.lbl_Zglob1.Font = new System.Drawing.Font("Segoe UI Emoji", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Zglob1.ForeColor = System.Drawing.Color.Lime;
            this.lbl_Zglob1.Location = new System.Drawing.Point(145, -277);
            this.lbl_Zglob1.Name = "lbl_Zglob1";
            this.lbl_Zglob1.Size = new System.Drawing.Size(71, 44);
            this.lbl_Zglob1.TabIndex = 33;
            this.lbl_Zglob1.Text = "90°";
            // 
            // circProgressB
            // 
            this.circProgressB.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.circProgressB.AnimationSpeed = 500;
            this.circProgressB.BackColor = System.Drawing.Color.Transparent;
            this.circProgressB.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold);
            this.circProgressB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.circProgressB.InnerColor = System.Drawing.Color.Transparent;
            this.circProgressB.InnerMargin = 2;
            this.circProgressB.InnerWidth = -1;
            this.circProgressB.Location = new System.Drawing.Point(21, 0);
            this.circProgressB.MarqueeAnimationSpeed = 2000;
            this.circProgressB.Maximum = 360;
            this.circProgressB.Name = "circProgressB";
            this.circProgressB.OuterColor = System.Drawing.Color.Black;
            this.circProgressB.OuterMargin = -25;
            this.circProgressB.OuterWidth = 26;
            this.circProgressB.ProgressColor = System.Drawing.Color.LimeGreen;
            this.circProgressB.ProgressWidth = 25;
            this.circProgressB.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.circProgressB.Size = new System.Drawing.Size(311, 281);
            this.circProgressB.StartAngle = 180;
            this.circProgressB.SubscriptColor = System.Drawing.Color.DarkGray;
            this.circProgressB.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.circProgressB.SubscriptText = ".23";
            this.circProgressB.SuperscriptColor = System.Drawing.Color.DarkGray;
            this.circProgressB.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.circProgressB.SuperscriptText = "°C";
            this.circProgressB.TabIndex = 31;
            this.circProgressB.TextMargin = new System.Windows.Forms.Padding(0);
            this.circProgressB.Value = 90;
            this.circProgressB.Click += new System.EventHandler(this.circProgressB_Click);
            this.circProgressB.MouseDown += new System.Windows.Forms.MouseEventHandler(this.circProgressB_MouseDown);
            this.circProgressB.MouseLeave += new System.EventHandler(this.circProgressB_MouseLeave);
            this.circProgressB.MouseMove += new System.Windows.Forms.MouseEventHandler(this.circProgressB_MouseMove);
            this.circProgressB.MouseUp += new System.Windows.Forms.MouseEventHandler(this.circProgressB_MouseUp);
            // 
            // lbl_Angle
            // 
            this.lbl_Angle.AutoSize = true;
            this.lbl_Angle.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Angle.CausesValidation = false;
            this.lbl_Angle.Font = new System.Drawing.Font("Segoe UI Emoji", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Angle.ForeColor = System.Drawing.Color.Lime;
            this.lbl_Angle.Location = new System.Drawing.Point(147, 310);
            this.lbl_Angle.Name = "lbl_Angle";
            this.lbl_Angle.Size = new System.Drawing.Size(71, 44);
            this.lbl_Angle.TabIndex = 34;
            this.lbl_Angle.Text = "90°";
            // 
            // lbl_JointName
            // 
            this.lbl_JointName.AutoSize = true;
            this.lbl_JointName.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_JointName.ForeColor = System.Drawing.Color.LimeGreen;
            this.lbl_JointName.Location = new System.Drawing.Point(107, 83);
            this.lbl_JointName.Name = "lbl_JointName";
            this.lbl_JointName.Size = new System.Drawing.Size(100, 37);
            this.lbl_JointName.TabIndex = 35;
            this.lbl_JointName.Text = "label1";
            // 
            // JointContol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbl_JointName);
            this.Controls.Add(this.lbl_Angle);
            this.Controls.Add(this.lbl_Zglob1);
            this.Controls.Add(this.circProgressB);
            this.Name = "JointContol";
            this.Size = new System.Drawing.Size(345, 359);
            this.Load += new System.EventHandler(this.JointContol_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Zglob1;
        private CircularProgressBar.CircularProgressBar circProgressB;
        private System.Windows.Forms.Label lbl_Angle;
        private System.Windows.Forms.Label lbl_JointName;
    }
}
