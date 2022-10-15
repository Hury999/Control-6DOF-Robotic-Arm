namespace MojRobot
{
    partial class Editor
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelDrag = new System.Windows.Forms.Panel();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_DodajPoziciju = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.robotBazaDataSet = new MojRobot.RobotBazaDataSet();
            this.motoriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.motoriTableAdapter = new MojRobot.RobotBazaDataSetTableAdapters.MotoriTableAdapter();
            this.btn_Pokreni = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panelDrag.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.robotBazaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.motoriBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1454, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // panelDrag
            // 
            this.panelDrag.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.panelDrag.Controls.Add(this.btn_Exit);
            this.panelDrag.Location = new System.Drawing.Point(59, 27);
            this.panelDrag.Name = "panelDrag";
            this.panelDrag.Size = new System.Drawing.Size(1395, 43);
            this.panelDrag.TabIndex = 26;
            this.panelDrag.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelDrag_MouseDown);
            this.panelDrag.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelDrag_MouseMove);
            this.panelDrag.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelDrag_MouseUp);
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.Color.LawnGreen;
            this.btn_Exit.FlatAppearance.BorderSize = 0;
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Exit.ForeColor = System.Drawing.Color.Black;
            this.btn_Exit.Location = new System.Drawing.Point(1371, 9);
            this.btn_Exit.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(24, 25);
            this.btn_Exit.TabIndex = 38;
            this.btn_Exit.TabStop = false;
            this.btn_Exit.Text = "X";
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_DodajPoziciju
            // 
            this.btn_DodajPoziciju.Location = new System.Drawing.Point(1258, 123);
            this.btn_DodajPoziciju.Name = "btn_DodajPoziciju";
            this.btn_DodajPoziciju.Size = new System.Drawing.Size(167, 70);
            this.btn_DodajPoziciju.TabIndex = 35;
            this.btn_DodajPoziciju.Text = "Dodaj novu poziciju";
            this.btn_DodajPoziciju.UseVisualStyleBackColor = true;
            this.btn_DodajPoziciju.Click += new System.EventHandler(this.btn_DodajPoziciju_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1258, 222);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(167, 70);
            this.button2.TabIndex = 36;
            this.button2.Text = "Briši";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.Location = new System.Drawing.Point(59, 76);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 50;
            this.dataGridView1.Size = new System.Drawing.Size(1151, 556);
            this.dataGridView1.TabIndex = 37;
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyDown);
            // 
            // robotBazaDataSet
            // 
            this.robotBazaDataSet.DataSetName = "RobotBazaDataSet";
            this.robotBazaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // motoriBindingSource
            // 
            this.motoriBindingSource.DataMember = "Motori";
            this.motoriBindingSource.DataSource = this.robotBazaDataSet;
            // 
            // motoriTableAdapter
            // 
            this.motoriTableAdapter.ClearBeforeFill = true;
            // 
            // btn_Pokreni
            // 
            this.btn_Pokreni.Location = new System.Drawing.Point(1216, 531);
            this.btn_Pokreni.Name = "btn_Pokreni";
            this.btn_Pokreni.Size = new System.Drawing.Size(167, 70);
            this.btn_Pokreni.TabIndex = 38;
            this.btn_Pokreni.Text = "Pokreni";
            this.btn_Pokreni.UseVisualStyleBackColor = true;
            this.btn_Pokreni.Click += new System.EventHandler(this.btn_Pokreni_Click);
            // 
            // Editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(1454, 644);
            this.Controls.Add(this.btn_Pokreni);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_DodajPoziciju);
            this.Controls.Add(this.panelDrag);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Editor";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelDrag.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.robotBazaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.motoriBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.Panel panelDrag;
        private System.Windows.Forms.Button btn_DodajPoziciju;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_Exit;
        private RobotBazaDataSet robotBazaDataSet;
        private System.Windows.Forms.BindingSource motoriBindingSource;
        private RobotBazaDataSetTableAdapters.MotoriTableAdapter motoriTableAdapter;
        private System.Windows.Forms.Button btn_Pokreni;
    }
}

