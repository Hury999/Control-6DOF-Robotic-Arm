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
    public partial class Form1 : Form
    {
        DapperFunctions dapfx = new DapperFunctions();


        // You will need these delegate to display your data from the other thread
        string dataReceived = string.Empty;
        private delegate void SetTextDeleg(string text);


        public Form1()
        {
            InitializeComponent();
            EnumaratePorts();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DapperFunctions dapfx = new DapperFunctions();
            List<VrijednostiMotora> lista = dapfx.GetAll_Motor();
        }
        private void EnumaratePorts()
        {
            foreach (var portName in SerialPort.GetPortNames())
            {
                toolStripComboBoxComPort.Items.Add(portName);
            }
        }

        private async void toolStripMenuItemComConnect_Click(object sender, EventArgs e)
        {
            var port = toolStripComboBoxComPort.SelectedIndex >= 0 ? (string)toolStripComboBoxComPort.Items[toolStripComboBoxComPort.SelectedIndex] : "";
            if (!string.IsNullOrEmpty(port))
                serialPort1.Close();

            //If string 'port' doesnt coontains "COM" word then its not connectable and then do nothing
            if (!port.Contains("COM"))
            {
                return;
            }


            serialPort1.PortName = port;
            try
            {
                serialPort1.Open();
                AutoClosingMessageBox.Show($"Uspjesno otvoren port {serialPort1.PortName} ", "Obavjest", 500);
                //Reset all motors to 90 degrees
                serialPort1.Write($"90a/90b/90c/90d/90e/90f");


            }
            catch (Exception ex)
            {
                MessageBox.Show($"Desila se greska prilikom konekcije na port: {ex.Message}");
            }
        }
        private void SendToMotorA(int a)
        {
            serialPort1.Write($"{a}a/");

        }
        private void SendToMotorB(int b)
        {
            serialPort1.Write($"{b}b/");
        }
        private void SendToMotorC(int c)
        {

            serialPort1.Write($"{c}c/");
        }
        private void SendToMotorD(int d)
        {

            serialPort1.Write($"{d}d/");


        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {

                // Read data from serial until it finds a carriage return
                string received = serialPort1.ReadLine();
                this.BeginInvoke(new SetTextDeleg(SerialDataReceived), new object[] { received });
            }
            catch
            {

            }
        }

        //Funkcija koja se okida kada app prima podatak sa serial sa uslovom carriage returna
        private void SerialDataReceived(string data)
        {
         

        }
        private void trackBarMotorC_Scroll(object sender, EventArgs e)
        {

        }

        private void trackBarMotorD_Scroll(object sender, EventArgs e)
        {

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EnumaratePorts();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void trackBar1_MouseUp(object sender, MouseEventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                var value = ((TrackBar)sender).Value;
                SendToMotorA(value);
            }
            else
            {
                serialPort1.Open();
            }
        }

        private void trackBar2_MouseUp(object sender, MouseEventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                var value = ((TrackBar)sender).Value;
                SendToMotorB(value);
            }
            else
            {
                serialPort1.Open();
            }

        }

        private void trackBar3_MouseUp(object sender, MouseEventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                var value = ((TrackBar)sender).Value;
                SendToMotorC(value);
            }
            else
            {
                serialPort1.Open();
            }
        }

        private void trackBar4_MouseUp(object sender, MouseEventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                var value = ((TrackBar)sender).Value;
                SendToMotorD(value);
            }
            else
            {
                serialPort1.Open();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        #region Cicrular progress HVATALJKA
        bool event_CircularA = false;
        private void circularProgressBar1_MouseUp(object sender, MouseEventArgs e)
        {
            event_CircularA = false;

        }

        private void circularProgressBar1_MouseDown(object sender, MouseEventArgs e)
        {
            event_CircularA = true;
        }



        private void circProgressA_MouseLeave(object sender, EventArgs e)
        {
            event_CircularA = false;
        }

        #endregion

        #region Cicrular progress Zglob1
        bool event_CircularB = false;
        private void circProgressB_MouseUp(object sender, MouseEventArgs e)
        {
            event_CircularB = false;

        }

        private void circProgressB_MouseDown(object sender, MouseEventArgs e)
        {
            event_CircularB = true;
        }

 


        private void circProgressB_MouseLeave(object sender, EventArgs e)
        {
            event_CircularB = false;
        }

        #endregion

        #region Cicrular progress Zglob2
        bool event_CircularC = false;
        private void circProgressC_MouseUp(object sender, MouseEventArgs e)
        {
            event_CircularC = false;

        }

        private void circProgressC_MouseDown(object sender, MouseEventArgs e)
        {
            event_CircularC = true;
        }

    


        private void circProgressC_MouseLeave(object sender, EventArgs e)
        {
            event_CircularC = false;
        }

        #endregion

        #region Cicrular progress PLATFORMA
        bool event_CircularD = false;
        private void circProgressD_MouseUp(object sender, MouseEventArgs e)
        {
            event_CircularD = false;

        }

        private void circProgressD_MouseDown(object sender, MouseEventArgs e)
        {
            event_CircularD = true;
        }



        private void circProgressD_MouseLeave(object sender, EventArgs e)
        {
            event_CircularD = false;
        }


        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            DapperFunctions dapFx = new DapperFunctions();

            List<VrijednostiMotora> vrijednostiMotora = dapFx.GetAll_Motor();

            string valueToSend = "";

            for (int i = 0; i < vrijednostiMotora.Count; i++)
            {
                valueToSend += $"{vrijednostiMotora[i].MotorHvataljka}a/{vrijednostiMotora[i].MotorZglob1}b/{vrijednostiMotora[i].MotorZglob2}c/{vrijednostiMotora[i].MotorPlatforma}d/";

            }

            serialPort1.Write(valueToSend);


        }

        private void editorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Editor editor = new Editor(this);
            editor.Show();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void jointContol1_Load(object sender, EventArgs e)
        {

        }

        private void jointContol7_Load(object sender, EventArgs e)
        {

        }

        private void closeSerialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
        }
    }
}
