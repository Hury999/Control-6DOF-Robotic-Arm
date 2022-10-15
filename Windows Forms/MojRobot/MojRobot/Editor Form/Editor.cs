using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;
using System.Threading;

namespace MojRobot
{
    public partial class Editor : Form
    {
        // You will need these delegate to display your data from the other thread



        Form1 Parent;
        DapperFunctions dapfx = new DapperFunctions();



        public Editor(Form1 Parent)
        {
            this.Parent = Parent;

            InitializeComponent();

            populateDataGridView();
            dapfx.ResetIds_VrijednostiMotor();
            Parent.Enabled = false;

        }




        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'robotBazaDataSet.Motori' table. You can move, or remove it, as needed.
            this.motoriTableAdapter.Fill(this.robotBazaDataSet.Motori);

            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.SeaGreen;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridView1.BackgroundColor = Color.FromArgb(30, 30, 30);
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;//optional
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("MS Reference Sans Serif", 15);
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(37, 37, 38);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.DefaultCellStyle.Font = new Font("Segoe UI", 13);
            dataGridView1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeight = 35;
        }


        private void toolStripMenuItemComConnect_Click(object sender, EventArgs e)
        {

        }
        private void SendToMotorA(int a)
        {
            Parent.serialPort1.Write($"{a}a/");
        }
        private void SendToMotorB(int b)
        {
            Parent.serialPort1.Write($"{b}b/");
        }
        private void SendToMotorC(int c)
        {
            Parent.serialPort1.Write($"{c}c/");
        }
        private void SendToMotorD(int d)
        {
            Parent.serialPort1.Write($"{d}d/");
        }
        private void SendToMotorE(int d)
        {
            Parent.serialPort1.Write($"{d}e/");
        }
        private void SendToMotorF(int d)
        {
            Parent.serialPort1.Write($"{d}f/");
        }
        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {

        }

        //Funkcija koja se okida kada app prima podatak sa serial sa uslovom carriage returna
        private void SerialDataReceived(string data)
        {

        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Parent.Enabled = true;
            this.Close();
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            VrijednostiMotora vrijMot = new VrijednostiMotora
            {
                Id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value),
                MotorHvataljka = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[1].Value),
                MotorZglob1 = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[2].Value),
                MotorZglob2 = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[3].Value),
                MotorPlatforma = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[4].Value)
            };

            dapfx.Update_VrijednostiMotor(vrijMot);
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
                {
                    dapfx.Delete_VrijednostiMotor(Convert.ToInt32(dataGridView1.SelectedRows[i].Cells[0].Value));
                }

                populateDataGridView();
            }
        }

        private void btn_DodajPoziciju_Click(object sender, EventArgs e)
        {

            List<VrijednostiMotora> motori = dapfx.GetAll_Motor();

            VrijednostiMotora noviMotor = new VrijednostiMotora
            {
                Id = (int)dataGridView1.Rows[dataGridView1.RowCount - 1].Cells["Id"].Value + 1,
                MotorHvataljka = 0,
                MotorPlatforma = 0,
                MotorZglob1 = 0,
                MotorZglob2 = 0,
                MotorZglob3 = 0,
                MotorZglobHvataljka = 0,
            };

            dapfx.Insert_VrijednostiMotor(noviMotor);


            populateDataGridView();
        }

        private void DataGridView_Align(DataGridView dataGridView)
        {
            for (int i = 0; i < dataGridView.ColumnCount; i++)
            {
                dataGridView.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void populateDataGridView()
        {
            dataGridView1.DataSource = dapfx.GetAll_Motor();
            dataGridView1.Columns["Id"].Visible = false;
            DataGridView_Align(dataGridView1);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        bool StopLoop = true;
        async void Loop()
        {
            while (true)
            {
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    if (StopLoop)
                        break;

                    await Task.Run(() => { Thread.Sleep(2500); });
                    if (StopLoop)
                        break;
                    SendToMotorA(Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value));

                    await Task.Run(() => { Thread.Sleep(2500); });
                    if (StopLoop)
                        break;
                    SendToMotorB(Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value));

                    await Task.Run(() => { Thread.Sleep(2500); });
                    if (StopLoop)
                        break;
                    SendToMotorC(Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value));

                    await Task.Run(() => { Thread.Sleep(2500); });
                    if (StopLoop)
                        break;
                    SendToMotorD(Convert.ToInt32(dataGridView1.Rows[i].Cells[4].Value));

                    await Task.Run(() => { Thread.Sleep(2500); });
                    if (StopLoop)
                        break;
                    SendToMotorE(Convert.ToInt32(dataGridView1.Rows[i].Cells[5].Value));

                    await Task.Run(() => { Thread.Sleep(2500); });
                    if (StopLoop)
                        break;
                    SendToMotorF(Convert.ToInt32(dataGridView1.Rows[i].Cells[6].Value));
                }
                if (StopLoop)
                    break;
            }
        }
        private void btn_Pokreni_Click(object sender, EventArgs e)
        {
            if (!StopLoop)
                StopLoop = true;
            else
                StopLoop = false;

            Thread.Sleep(1000);

            Loop();

        }
    }
}
