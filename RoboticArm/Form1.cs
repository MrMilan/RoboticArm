using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RoboticArms
{
    public partial class Form1 : Form
    {

        private IRoboticControl robotickaPazeRobix = new RoboticArm();
        private int motorPosition1, motorPosition2, motorPosition3, motorPosition4, motorPosition5, motorPosition6, acceleration, maxSpeed;

        public Form1()
        {
            InitializeComponent();
            CreateRoboticArm();
        }

        private void CreateRoboticArm()
        {
            for (int i = 0; i < 6; i++)
            {
                robotickaPazeRobix.JointList.Add(new Joint());
            }

        }

        private void btn_Connect_Click(object sender, EventArgs e)
        {
            robotickaPazeRobix.Connection();
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            motorPosition1 = vScrollBar1.Value;
            label1.Text = Convert.ToString(motorPosition1);
        }
        private void vScrollBar2_Scroll(object sender, ScrollEventArgs e)
        {
            motorPosition2 = vScrollBar2.Value;
            label2.Text = Convert.ToString(motorPosition2);

        }

        private void vScrollBar3_Scroll(object sender, ScrollEventArgs e)
        {
            motorPosition3 = vScrollBar3.Value;
            label3.Text = Convert.ToString(motorPosition3);

        }

        private void vScrollBar4_Scroll(object sender, ScrollEventArgs e)
        {
            motorPosition4 = vScrollBar4.Value;
            label4.Text = Convert.ToString(motorPosition4);
        }

        private void vScrollBar5_Scroll(object sender, ScrollEventArgs e)
        {
            motorPosition5 = vScrollBar5.Value;
            label5.Text = Convert.ToString(motorPosition5);
        }

        private void vScrollBar6_Scroll(object sender, ScrollEventArgs e)
        {
            motorPosition6 = vScrollBar6.Value;
            label6.Text = Convert.ToString(motorPosition6);
        }

        private void vScrollBar7_Scroll(object sender, ScrollEventArgs e)
        {
            acceleration = vScrollBar7.Value;
            label15.Text = Convert.ToString(acceleration);
        }

        private void vScrollBar8_Scroll(object sender, ScrollEventArgs e)
        {
            maxSpeed = vScrollBar8.Value;
            label16.Text = Convert.ToString(maxSpeed);
        }

        private void vScrollBar1_MouseLeave(object sender, EventArgs e)
        {
            robotickaPazeRobix.JointList[0].MoveToPosition(1, motorPosition1);
        }
        private void vScrollBar2_MouseLeave(object sender, EventArgs e)
        {
            robotickaPazeRobix.JointList[1].MoveToPosition(2, motorPosition2);
        }
        private void vScrollBar3_MouseLeave(object sender, EventArgs e)
        {
            robotickaPazeRobix.JointList[2].MoveToPosition(3, motorPosition3);
        }
        private void vScrollBar4_MouseLeave(object sender, EventArgs e)
        {
            robotickaPazeRobix.JointList[3].MoveToPosition(4, motorPosition4);
        }
        private void vScrollBar5_MouseLeave(object sender, EventArgs e)
        {
            robotickaPazeRobix.JointList[4].MoveToPosition(5, motorPosition5);
        }
        private void vScrollBar6_MouseLeave(object sender, EventArgs e)
        {
            robotickaPazeRobix.JointList[5].MoveToPosition(6, motorPosition6);
        }
        private void vScrollBar7_MouseLeave(object sender, EventArgs e)
        {
            robotickaPazeRobix.SetAcceleration(acceleration);
        }
        private void vScrollBar8_MouseLeave(object sender, EventArgs e)
        {
            robotickaPazeRobix.SetMaxSpeed(maxSpeed);
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            robotickaPazeRobix.Initioalization();
        }


    }
}
