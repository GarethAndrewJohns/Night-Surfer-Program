using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Night_Surfer_Program
{
    public partial class formMain : Form
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);
        //Mouse actions
        private const int mouseLeftDown = 0x02;
        private const int mouseLeftUp = 0x04;

        public int time1 = 100;
        public int time2 = 200;

        public formMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void DoMouseClick()
        {
            //Call the imported function with the cursor's current position
            uint X = (uint)Cursor.Position.X;
            uint Y = (uint)Cursor.Position.Y;
            mouse_event(mouseLeftDown | mouseLeftUp, X, Y, 0, 0);
        }

        public void DoMouseWiggle()
        {
            // Set the Current cursor, move the cursor's Position,
            // and set its clipping rectangle to the form. 

            this.Cursor = new Cursor(Cursor.Current.Handle);
            Cursor.Position = new Point(Cursor.Position.X - 10, Cursor.Position.Y - 10);
            System.Threading.Thread.Sleep(100);
            Cursor.Position = new Point(Cursor.Position.X + 10, Cursor.Position.Y + 10);
            //Cursor.Clip = new Rectangle(this.Location, this.Size);
        }

        private void buttonTime1_Click(object sender, EventArgs e)
        {
            //converts the entered values into a single number in seconds
            time1 = (int)hourTime1.Value*3600 + 
                    (int)minuteTime1.Value*60 + 
                    (int)secondTime1.Value;
            labelTime1.Text = time1.ToString();
        }

        private void buttonTime2_Click(object sender, EventArgs e)
        {
            //converts the entered values into a single number in seconds
            time2 = (int)hourTime2.Value*3600 + 
                    (int)minuteTime2.Value*60 + 
                    (int)secondTime2.Value;
            labelTime2.Text = time2.ToString();
        }

        private void timerClick1_Tick(object sender, EventArgs e)
        {
            //subtracts the time by 1 every second
            time1--;
            labelProgress1.Text = time1.ToString();

            // Wiggles the mouse 5 - 10 seconds before it needs to click to activate the screen
            if (time1 <= 10 && time1 >= 5)
            {
                DoMouseWiggle();
            }

            if (time1 <= 0)
            {
                DoMouseClick(); //clicks left mouse button when the time1 reaches 0
                timerClick1.Stop(); //Stops the timer, as it's no longer needed
                time1 = 100; //Sets time1 a high number so it doesn't trigger the if statements
            }
        }

        private void timerClick2_Tick(object sender, EventArgs e)
        {
            //subtracts the time by 1 every second
            time2--;
            labelProgress2.Text = time2.ToString();

            // Wiggles the mouse 5 - 10 seconds before it needs to click to activate the screen
            if (time2 <= 10 && time2 >= 5)
            {
                DoMouseWiggle();
            }

            if (time2 <= 0)
            {
                DoMouseClick(); //clicks left mouse button when the time2 reaces 0
                timerClick2.Stop(); //Stops the timer, as it's no longer needed
                time2 = 200; //Sets time1 a high number so it doesn't trigger the if statements
                System.Threading.Thread.Sleep(3000); //pauses the program for 3 seconds
                Close(); //closes the program as its function is complete
            }
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            timerClick1.Start();
            timerClick2.Start();
        }

    }
}
