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
        private int acceleration=10, maxSpeed=100;
        private int [] motorPosition = new int[6];
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
            robotickaPazeRobix.Initioalization();
            robotickaPazeRobix.SetMaxSpeed(maxSpeed);
            robotickaPazeRobix.SetAcceleration(acceleration);
            vScrollBJoint1.Enabled = true;
            vScrollBJoint2.Enabled = true;
            vScrollBJoint3.Enabled = true;
            vScrollBJoint4.Enabled = true;
            vScrollBWrist.Enabled = true;
            vScrollBGrip.Enabled = true;
            vScrollBAcell.Enabled = true;
            vScrollBSpeed.Enabled = true;

            vScrollBAcell.Value = acceleration;
            vScrollBSpeed.Value = maxSpeed;

            lblAccel.Text=acceleration.ToString();
            lblSpeed.Text = maxSpeed.ToString();

            btn_Reset.Enabled = true;

        }

        private void vScrollBJoint1_Scroll(object sender, ScrollEventArgs e)
        {
            motorPosition[0] = vScrollBJoint1.Value;
            lblJoint1.Text = Convert.ToString(motorPosition[0]);
        }
        private void vScrollBJoint2_Scroll(object sender, ScrollEventArgs e)
        {
            motorPosition[1] = vScrollBJoint2.Value;
            lblJoint2.Text = Convert.ToString(motorPosition[1]);

        }

        private void vScrollBJoint3_Scroll(object sender, ScrollEventArgs e)
        {
            motorPosition[2] = vScrollBJoint3.Value;
            lblJoint3.Text = Convert.ToString(motorPosition[2]);

        }

        private void vScrollBJoint4_Scroll(object sender, ScrollEventArgs e)
        {
            motorPosition[3] = vScrollBJoint4.Value;
            lblJoint4.Text = Convert.ToString(motorPosition[3]);
        }

        private void vScrollBWrist_Scroll(object sender, ScrollEventArgs e)
        {
            motorPosition[4] = vScrollBWrist.Value;
            lblWrist.Text = Convert.ToString(motorPosition[4]);
        }

        private void vScrollBGrip_Scroll(object sender, ScrollEventArgs e)
        {
            motorPosition[5] = vScrollBGrip.Value;
            lblGrip.Text = Convert.ToString(motorPosition[5]);
        }

        private void vScrollBAccel_Scroll(object sender, ScrollEventArgs e)
        {
            acceleration = vScrollBAcell.Value;
            lblAccel.Text = Convert.ToString(acceleration);
        }

        private void vScrollBSpeed_Scroll(object sender, ScrollEventArgs e)
        {
            maxSpeed = vScrollBSpeed.Value;
            lblSpeed.Text = Convert.ToString(maxSpeed);
        }

        private void vScrollBJoint1_MouseLeave(object sender, EventArgs e)
        {
            robotickaPazeRobix.JointList[0].MoveToPosition(1, motorPosition[0]);
        }
        private void vScrollBJoint2_MouseLeave(object sender, EventArgs e)
        {
            robotickaPazeRobix.JointList[1].MoveToPosition(2, motorPosition[1]);
        }
        private void vScrollBJoint3_MouseLeave(object sender, EventArgs e)
        {
            robotickaPazeRobix.JointList[2].MoveToPosition(3, motorPosition[2]);
        }
        private void vScrollBJoint4_MouseLeave(object sender, EventArgs e)
        {
            robotickaPazeRobix.JointList[3].MoveToPosition(4, motorPosition[3]);
        }
        private void vScrollBWrist_MouseLeave(object sender, EventArgs e)
        {
            robotickaPazeRobix.JointList[4].MoveToPosition(5, motorPosition[4]);
        }
        private void vScrollBGrip_MouseLeave(object sender, EventArgs e)
        {
            robotickaPazeRobix.JointList[5].MoveToPosition(6, motorPosition[5]);
        }
        private void vScrollBAccel_MouseLeave(object sender, EventArgs e)
        {
            robotickaPazeRobix.SetAcceleration(acceleration);
        }
        private void vScrollBSpeed_MouseLeave(object sender, EventArgs e)
        {
            robotickaPazeRobix.SetMaxSpeed(maxSpeed);
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            robotickaPazeRobix.Initioalization();
            vScrollBJoint1.Value = 0;
            vScrollBJoint2.Value = 0;
            vScrollBJoint3.Value = 0;
            vScrollBJoint4.Value = 0;
            vScrollBWrist.Value = 0;
            vScrollBGrip.Value = 0;

            lblJoint1.Text = "0";
            lblJoint2.Text = "0";
            lblJoint3.Text = "0";
            lblJoint4.Text = "0";
            lblWrist.Text = "0";
            lblGrip.Text = "0";
        }


    }
}
