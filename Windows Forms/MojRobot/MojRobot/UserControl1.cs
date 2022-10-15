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

namespace MojRobot
{
    public partial class JointContol : UserControl
    {
        public JointContol()
        {
            InitializeComponent();
        }

        [Description("Name of joint"), Category("CustomData")]
        public String CustomJointName { get; set; }

        [Description("Serial port to which progress bar will send data."), Category("CustomData")]
        public SerialPort serialPort { get; set; }

        [Description("String to signal to which motor to send text."), Category("CustomData")]
        public String strMotor { get; set; }

        bool event_CircularB = false;
        private void circProgressB_Click(object sender, EventArgs e)
        {
            
        }

        private void circProgressB_MouseUp(object sender, MouseEventArgs e)
        {
            event_CircularB = false;
        }

        private void circProgressB_MouseDown(object sender, MouseEventArgs e)
        {
            event_CircularB = true;
        }

        int staraVrijednostPozicijeMisa_Zglob1 = 0;
        private void circProgressB_MouseMove(object sender, MouseEventArgs e)
        {
            //Zglob1 -> y osa

            if (event_CircularB == true)
            {
                int valueFromMouse = e.Y - staraVrijednostPozicijeMisa_Zglob1;

                int testing = circProgressB.Value;
                int valueToSend = circProgressB.Value + valueFromMouse;

                if ((circProgressB.Value + valueFromMouse) < 0)
                {
                    circProgressB.Value = 0;
                }
                else if ((circProgressB.Value + valueFromMouse) >= 180)
                {
                    circProgressB.Value = 177;
                    valueToSend = 177;
                }
                else
                {
                    circProgressB.Value = valueToSend;
                    lbl_Angle.Text = valueToSend + "°";
                }

                if (serialPort.IsOpen)
                {
                    serialPort.Write($"{valueToSend + strMotor}/");
                }
                else
                {
                    serialPort.Open();
                }
            }

            staraVrijednostPozicijeMisa_Zglob1 = e.Location.Y;
        }

        private void circProgressB_MouseLeave(object sender, EventArgs e)
        {
            event_CircularB = false;
        }

        private void JointContol_Load(object sender, EventArgs e)
        {
            lbl_JointName.Text = CustomJointName;
        }
    }
}
