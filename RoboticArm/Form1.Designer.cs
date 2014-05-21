namespace RoboticArms
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
            this.lblTextGrip = new System.Windows.Forms.Label();
            this.lblTextWrist = new System.Windows.Forms.Label();
            this.lblTextJoint4 = new System.Windows.Forms.Label();
            this.lblTextJoint3 = new System.Windows.Forms.Label();
            this.lblTextJoint2 = new System.Windows.Forms.Label();
            this.lblTextJoint1 = new System.Windows.Forms.Label();
            this.lblGrip = new System.Windows.Forms.Label();
            this.vScrollBGrip = new System.Windows.Forms.VScrollBar();
            this.lblWrist = new System.Windows.Forms.Label();
            this.vScrollBWrist = new System.Windows.Forms.VScrollBar();
            this.lblJoint4 = new System.Windows.Forms.Label();
            this.vScrollBJoint4 = new System.Windows.Forms.VScrollBar();
            this.lblJoint3 = new System.Windows.Forms.Label();
            this.vScrollBJoint3 = new System.Windows.Forms.VScrollBar();
            this.lblJoint2 = new System.Windows.Forms.Label();
            this.vScrollBJoint2 = new System.Windows.Forms.VScrollBar();
            this.lblJoint1 = new System.Windows.Forms.Label();
            this.vScrollBJoint1 = new System.Windows.Forms.VScrollBar();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.btn_Connect = new System.Windows.Forms.Button();
            this.vScrollBAcell = new System.Windows.Forms.VScrollBar();
            this.lblTextAccel = new System.Windows.Forms.Label();
            this.lblAccel = new System.Windows.Forms.Label();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.vScrollBSpeed = new System.Windows.Forms.VScrollBar();
            this.lblTextSpeed = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTextGrip
            // 
            this.lblTextGrip.AutoSize = true;
            this.lblTextGrip.Location = new System.Drawing.Point(319, 21);
            this.lblTextGrip.Name = "lblTextGrip";
            this.lblTextGrip.Size = new System.Drawing.Size(30, 13);
            this.lblTextGrip.TabIndex = 64;
            this.lblTextGrip.Text = "Stisk";
            // 
            // lblTextWrist
            // 
            this.lblTextWrist.AutoSize = true;
            this.lblTextWrist.Location = new System.Drawing.Point(246, 21);
            this.lblTextWrist.Name = "lblTextWrist";
            this.lblTextWrist.Size = new System.Drawing.Size(65, 13);
            this.lblTextWrist.TabIndex = 63;
            this.lblTextWrist.Text = "Rotace záp.";
            // 
            // lblTextJoint4
            // 
            this.lblTextJoint4.AutoSize = true;
            this.lblTextJoint4.Location = new System.Drawing.Point(194, 21);
            this.lblTextJoint4.Name = "lblTextJoint4";
            this.lblTextJoint4.Size = new System.Drawing.Size(43, 13);
            this.lblTextJoint4.TabIndex = 62;
            this.lblTextJoint4.Text = "Kloub 4";
            // 
            // lblTextJoint3
            // 
            this.lblTextJoint3.AutoSize = true;
            this.lblTextJoint3.Location = new System.Drawing.Point(136, 21);
            this.lblTextJoint3.Name = "lblTextJoint3";
            this.lblTextJoint3.Size = new System.Drawing.Size(43, 13);
            this.lblTextJoint3.TabIndex = 61;
            this.lblTextJoint3.Text = "Kloub 3";
            // 
            // lblTextJoint2
            // 
            this.lblTextJoint2.AutoSize = true;
            this.lblTextJoint2.Location = new System.Drawing.Point(75, 21);
            this.lblTextJoint2.Name = "lblTextJoint2";
            this.lblTextJoint2.Size = new System.Drawing.Size(43, 13);
            this.lblTextJoint2.TabIndex = 60;
            this.lblTextJoint2.Text = "Kloub 2";
            // 
            // lblTextJoint1
            // 
            this.lblTextJoint1.AutoSize = true;
            this.lblTextJoint1.Location = new System.Drawing.Point(21, 21);
            this.lblTextJoint1.Name = "lblTextJoint1";
            this.lblTextJoint1.Size = new System.Drawing.Size(43, 13);
            this.lblTextJoint1.TabIndex = 59;
            this.lblTextJoint1.Text = "Kloub 1";
            // 
            // lblGrip
            // 
            this.lblGrip.AutoSize = true;
            this.lblGrip.Location = new System.Drawing.Point(324, 238);
            this.lblGrip.Name = "lblGrip";
            this.lblGrip.Size = new System.Drawing.Size(13, 13);
            this.lblGrip.TabIndex = 58;
            this.lblGrip.Text = "0";
            // 
            // vScrollBGrip
            // 
            this.vScrollBGrip.Enabled = false;
            this.vScrollBGrip.Location = new System.Drawing.Point(317, 46);
            this.vScrollBGrip.Maximum = 1400;
            this.vScrollBGrip.Minimum = -1400;
            this.vScrollBGrip.Name = "vScrollBGrip";
            this.vScrollBGrip.Size = new System.Drawing.Size(32, 178);
            this.vScrollBGrip.TabIndex = 57;
            this.vScrollBGrip.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBGrip_Scroll);
            this.vScrollBGrip.MouseLeave += new System.EventHandler(this.vScrollBGrip_MouseLeave);
            // 
            // lblWrist
            // 
            this.lblWrist.AutoSize = true;
            this.lblWrist.Location = new System.Drawing.Point(267, 238);
            this.lblWrist.Name = "lblWrist";
            this.lblWrist.Size = new System.Drawing.Size(13, 13);
            this.lblWrist.TabIndex = 56;
            this.lblWrist.Text = "0";
            // 
            // vScrollBWrist
            // 
            this.vScrollBWrist.Enabled = false;
            this.vScrollBWrist.Location = new System.Drawing.Point(260, 46);
            this.vScrollBWrist.Maximum = 1400;
            this.vScrollBWrist.Minimum = -1400;
            this.vScrollBWrist.Name = "vScrollBWrist";
            this.vScrollBWrist.Size = new System.Drawing.Size(32, 178);
            this.vScrollBWrist.TabIndex = 55;
            this.vScrollBWrist.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBWrist_Scroll);
            this.vScrollBWrist.MouseLeave += new System.EventHandler(this.vScrollBWrist_MouseLeave);
            // 
            // lblJoint4
            // 
            this.lblJoint4.AutoSize = true;
            this.lblJoint4.Location = new System.Drawing.Point(204, 238);
            this.lblJoint4.Name = "lblJoint4";
            this.lblJoint4.Size = new System.Drawing.Size(13, 13);
            this.lblJoint4.TabIndex = 54;
            this.lblJoint4.Text = "0";
            // 
            // vScrollBJoint4
            // 
            this.vScrollBJoint4.Enabled = false;
            this.vScrollBJoint4.Location = new System.Drawing.Point(197, 46);
            this.vScrollBJoint4.Maximum = 1400;
            this.vScrollBJoint4.Minimum = -1400;
            this.vScrollBJoint4.Name = "vScrollBJoint4";
            this.vScrollBJoint4.Size = new System.Drawing.Size(32, 178);
            this.vScrollBJoint4.TabIndex = 53;
            this.vScrollBJoint4.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBJoint4_Scroll);
            this.vScrollBJoint4.MouseLeave += new System.EventHandler(this.vScrollBJoint4_MouseLeave);
            // 
            // lblJoint3
            // 
            this.lblJoint3.AutoSize = true;
            this.lblJoint3.Location = new System.Drawing.Point(147, 238);
            this.lblJoint3.Name = "lblJoint3";
            this.lblJoint3.Size = new System.Drawing.Size(13, 13);
            this.lblJoint3.TabIndex = 52;
            this.lblJoint3.Text = "0";
            // 
            // vScrollBJoint3
            // 
            this.vScrollBJoint3.Enabled = false;
            this.vScrollBJoint3.Location = new System.Drawing.Point(139, 46);
            this.vScrollBJoint3.Maximum = 1400;
            this.vScrollBJoint3.Minimum = -1400;
            this.vScrollBJoint3.Name = "vScrollBJoint3";
            this.vScrollBJoint3.Size = new System.Drawing.Size(32, 178);
            this.vScrollBJoint3.TabIndex = 51;
            this.vScrollBJoint3.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBJoint3_Scroll);
            this.vScrollBJoint3.MouseLeave += new System.EventHandler(this.vScrollBJoint3_MouseLeave);
            // 
            // lblJoint2
            // 
            this.lblJoint2.AutoSize = true;
            this.lblJoint2.Location = new System.Drawing.Point(86, 238);
            this.lblJoint2.Name = "lblJoint2";
            this.lblJoint2.Size = new System.Drawing.Size(13, 13);
            this.lblJoint2.TabIndex = 50;
            this.lblJoint2.Text = "0";
            // 
            // vScrollBJoint2
            // 
            this.vScrollBJoint2.Enabled = false;
            this.vScrollBJoint2.Location = new System.Drawing.Point(78, 46);
            this.vScrollBJoint2.Maximum = 1400;
            this.vScrollBJoint2.Minimum = -1400;
            this.vScrollBJoint2.Name = "vScrollBJoint2";
            this.vScrollBJoint2.Size = new System.Drawing.Size(32, 178);
            this.vScrollBJoint2.TabIndex = 49;
            this.vScrollBJoint2.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBJoint2_Scroll);
            this.vScrollBJoint2.MouseLeave += new System.EventHandler(this.vScrollBJoint2_MouseLeave);
            // 
            // lblJoint1
            // 
            this.lblJoint1.AutoSize = true;
            this.lblJoint1.Location = new System.Drawing.Point(31, 238);
            this.lblJoint1.Name = "lblJoint1";
            this.lblJoint1.Size = new System.Drawing.Size(13, 13);
            this.lblJoint1.TabIndex = 48;
            this.lblJoint1.Text = "0";
            // 
            // vScrollBJoint1
            // 
            this.vScrollBJoint1.Enabled = false;
            this.vScrollBJoint1.Location = new System.Drawing.Point(23, 46);
            this.vScrollBJoint1.Maximum = 1400;
            this.vScrollBJoint1.Minimum = -1400;
            this.vScrollBJoint1.Name = "vScrollBJoint1";
            this.vScrollBJoint1.Size = new System.Drawing.Size(32, 178);
            this.vScrollBJoint1.TabIndex = 47;
            this.vScrollBJoint1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBJoint1_Scroll);
            this.vScrollBJoint1.MouseLeave += new System.EventHandler(this.vScrollBJoint1_MouseLeave);
            // 
            // btn_Reset
            // 
            this.btn_Reset.Enabled = false;
            this.btn_Reset.Location = new System.Drawing.Point(16, 285);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(333, 31);
            this.btn_Reset.TabIndex = 65;
            this.btn_Reset.Text = "Reset na výchozí pozici";
            this.btn_Reset.UseVisualStyleBackColor = true;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // btn_Connect
            // 
            this.btn_Connect.Location = new System.Drawing.Point(16, 324);
            this.btn_Connect.Name = "btn_Connect";
            this.btn_Connect.Size = new System.Drawing.Size(333, 31);
            this.btn_Connect.TabIndex = 66;
            this.btn_Connect.Text = "Připojit";
            this.btn_Connect.UseVisualStyleBackColor = true;
            this.btn_Connect.Click += new System.EventHandler(this.btn_Connect_Click);
            // 
            // vScrollBAcell
            // 
            this.vScrollBAcell.Enabled = false;
            this.vScrollBAcell.Location = new System.Drawing.Point(440, 46);
            this.vScrollBAcell.Maximum = 1000;
            this.vScrollBAcell.Minimum = 1;
            this.vScrollBAcell.Name = "vScrollBAcell";
            this.vScrollBAcell.Size = new System.Drawing.Size(32, 178);
            this.vScrollBAcell.TabIndex = 47;
            this.vScrollBAcell.Value = 1;
            this.vScrollBAcell.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBAccel_Scroll);
            this.vScrollBAcell.MouseLeave += new System.EventHandler(this.vScrollBAccel_MouseLeave);
            // 
            // lblTextAccel
            // 
            this.lblTextAccel.AutoSize = true;
            this.lblTextAccel.Location = new System.Drawing.Point(437, 21);
            this.lblTextAccel.Name = "lblTextAccel";
            this.lblTextAccel.Size = new System.Drawing.Size(52, 13);
            this.lblTextAccel.TabIndex = 59;
            this.lblTextAccel.Text = "Zrychlení";
            // 
            // lblAccel
            // 
            this.lblAccel.AutoSize = true;
            this.lblAccel.Location = new System.Drawing.Point(452, 238);
            this.lblAccel.Name = "lblAccel";
            this.lblAccel.Size = new System.Drawing.Size(13, 13);
            this.lblAccel.TabIndex = 56;
            this.lblAccel.Text = "0";
            // 
            // lblSpeed
            // 
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.Location = new System.Drawing.Point(522, 238);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(13, 13);
            this.lblSpeed.TabIndex = 58;
            this.lblSpeed.Text = "0";
            // 
            // vScrollBSpeed
            // 
            this.vScrollBSpeed.Enabled = false;
            this.vScrollBSpeed.Location = new System.Drawing.Point(512, 46);
            this.vScrollBSpeed.Maximum = 1000;
            this.vScrollBSpeed.Name = "vScrollBSpeed";
            this.vScrollBSpeed.Size = new System.Drawing.Size(32, 178);
            this.vScrollBSpeed.TabIndex = 47;
            this.vScrollBSpeed.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBSpeed_Scroll);
            this.vScrollBSpeed.MouseLeave += new System.EventHandler(this.vScrollBSpeed_MouseLeave);
            // 
            // lblTextSpeed
            // 
            this.lblTextSpeed.AutoSize = true;
            this.lblTextSpeed.Location = new System.Drawing.Point(496, 21);
            this.lblTextSpeed.Name = "lblTextSpeed";
            this.lblTextSpeed.Size = new System.Drawing.Size(69, 13);
            this.lblTextSpeed.TabIndex = 59;
            this.lblTextSpeed.Text = "Max. rychlost";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 367);
            this.Controls.Add(this.btn_Connect);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.lblTextGrip);
            this.Controls.Add(this.lblTextWrist);
            this.Controls.Add(this.lblTextJoint4);
            this.Controls.Add(this.lblTextJoint3);
            this.Controls.Add(this.lblTextJoint2);
            this.Controls.Add(this.lblTextSpeed);
            this.Controls.Add(this.lblTextAccel);
            this.Controls.Add(this.lblTextJoint1);
            this.Controls.Add(this.lblSpeed);
            this.Controls.Add(this.lblGrip);
            this.Controls.Add(this.lblAccel);
            this.Controls.Add(this.vScrollBGrip);
            this.Controls.Add(this.lblWrist);
            this.Controls.Add(this.vScrollBWrist);
            this.Controls.Add(this.lblJoint4);
            this.Controls.Add(this.vScrollBJoint4);
            this.Controls.Add(this.lblJoint3);
            this.Controls.Add(this.vScrollBJoint3);
            this.Controls.Add(this.lblJoint2);
            this.Controls.Add(this.vScrollBJoint2);
            this.Controls.Add(this.lblJoint1);
            this.Controls.Add(this.vScrollBSpeed);
            this.Controls.Add(this.vScrollBAcell);
            this.Controls.Add(this.vScrollBJoint1);
            this.Name = "Form1";
            this.Text = "Robotická paže Robix";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTextGrip;
        private System.Windows.Forms.Label lblTextWrist;
        private System.Windows.Forms.Label lblTextJoint4;
        private System.Windows.Forms.Label lblTextJoint3;
        private System.Windows.Forms.Label lblTextJoint2;
        private System.Windows.Forms.Label lblTextJoint1;
        private System.Windows.Forms.Label lblGrip;
        private System.Windows.Forms.VScrollBar vScrollBGrip;
        private System.Windows.Forms.Label lblWrist;
        private System.Windows.Forms.VScrollBar vScrollBWrist;
        private System.Windows.Forms.Label lblJoint4;
        private System.Windows.Forms.VScrollBar vScrollBJoint4;
        private System.Windows.Forms.Label lblJoint3;
        private System.Windows.Forms.VScrollBar vScrollBJoint3;
        private System.Windows.Forms.Label lblJoint2;
        private System.Windows.Forms.VScrollBar vScrollBJoint2;
        private System.Windows.Forms.Label lblJoint1;
        private System.Windows.Forms.VScrollBar vScrollBJoint1;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.Button btn_Connect;
        private System.Windows.Forms.VScrollBar vScrollBAcell;
        private System.Windows.Forms.Label lblTextAccel;
        private System.Windows.Forms.Label lblAccel;
        private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.VScrollBar vScrollBSpeed;
        private System.Windows.Forms.Label lblTextSpeed;
    }
}

