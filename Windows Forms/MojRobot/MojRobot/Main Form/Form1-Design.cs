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
using System.Security.Cryptography;

namespace MojRobot
{
    class Form1_Design
    {
    }

    //Code for my design
    public partial class Form1 : Form
    {

       

        //
        //Panels for moving form on dekstop
        //
        private bool TogMove;
        private int X1 = 0;
        private int Y1 = 0;

        private void panelDrag_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                TogMove = true;
                X1 = e.X;
                Y1 = e.Y;

            }
        }

        private void panelDrag_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                TogMove = false;

                if (Cursor.Position.Y == 0)
                {
                    //Maximize if you want
                }
            }
        }

        private void panelDrag_MouseMove(object sender, MouseEventArgs e)
        {
            if (TogMove == true)
            {
                int X2 = 0;
                int Y2 = 0;

                X2 = e.X - X1;
                Y2 = e.Y - Y1;

                this.Location = new Point(this.Location.X + X2, this.Location.Y + Y2);

                //if (_MouseDown == true && maximized == true)
                //{
                //    this.Refresh();
                //    int x = (Cursor.Position.X * 100) / Screen.PrimaryScreen.WorkingArea.Width;

                //    int _x = (1071 * x) / 100;

                //    //Minimze if you want
                //    this.Location = new Point(this.Location.X + _x, this.Location.Y);
                //}
            }
        }


      
    }
}
