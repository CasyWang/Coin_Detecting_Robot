namespace ShapeDetection
{
    partial class MainForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.fileNameTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.loadImageButton = new System.Windows.Forms.Button();
            this.btn_OpenPort = new System.Windows.Forms.Button();
            this.comboBox_Device = new System.Windows.Forms.ComboBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.circleImageBox = new Emgu.CV.UI.ImageBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.triangleRectangleImageBox = new Emgu.CV.UI.ImageBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.btnRobotArmOff = new System.Windows.Forms.Button();
            this.btnRobotArmOn = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btn_Pull = new System.Windows.Forms.Button();
            this.btnDrop = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_Back2StartPos = new System.Windows.Forms.Button();
            this.btnGo2Pos = new System.Windows.Forms.Button();
            this.tbPosZ = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbPosY = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbPosX = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_ysub = new System.Windows.Forms.Button();
            this.btn_yplus = new System.Windows.Forms.Button();
            this.btn_xsub = new System.Windows.Forms.Button();
            this.btn_xplus = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_stop = new System.Windows.Forms.Button();
            this.btn_capture = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.lblOffsets = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.circleImageBox)).BeginInit();
            this.panel4.SuspendLayout();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.triangleRectangleImageBox)).BeginInit();
            this.panel3.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.fileNameTextBox);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.loadImageButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1350, 49);
            this.panel1.TabIndex = 0;
            // 
            // fileNameTextBox
            // 
            this.fileNameTextBox.Location = new System.Drawing.Point(49, 13);
            this.fileNameTextBox.Name = "fileNameTextBox";
            this.fileNameTextBox.ReadOnly = true;
            this.fileNameTextBox.Size = new System.Drawing.Size(215, 21);
            this.fileNameTextBox.TabIndex = 2;
            this.fileNameTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 12);
            this.label5.TabIndex = 1;
            this.label5.Text = "File:";
            // 
            // loadImageButton
            // 
            this.loadImageButton.Location = new System.Drawing.Point(270, 11);
            this.loadImageButton.Name = "loadImageButton";
            this.loadImageButton.Size = new System.Drawing.Size(30, 21);
            this.loadImageButton.TabIndex = 0;
            this.loadImageButton.Text = "...";
            this.loadImageButton.UseVisualStyleBackColor = true;
            this.loadImageButton.Click += new System.EventHandler(this.loadImageButton_Click);
            // 
            // btn_OpenPort
            // 
            this.btn_OpenPort.Location = new System.Drawing.Point(16, 76);
            this.btn_OpenPort.Name = "btn_OpenPort";
            this.btn_OpenPort.Size = new System.Drawing.Size(88, 23);
            this.btn_OpenPort.TabIndex = 5;
            this.btn_OpenPort.Text = "Connect Device";
            this.btn_OpenPort.UseVisualStyleBackColor = true;
            this.btn_OpenPort.Click += new System.EventHandler(this.btn_OpenPort_Click);
            // 
            // comboBox_Device
            // 
            this.comboBox_Device.FormattingEnabled = true;
            this.comboBox_Device.Location = new System.Drawing.Point(16, 26);
            this.comboBox_Device.Name = "comboBox_Device";
            this.comboBox_Device.Size = new System.Drawing.Size(88, 20);
            this.comboBox_Device.TabIndex = 3;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 49);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer1.Size = new System.Drawing.Size(1350, 641);
            this.splitContainer1.SplitterDistance = 612;
            this.splitContainer1.TabIndex = 1;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.panel2);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.circleImageBox);
            this.splitContainer2.Panel2.Controls.Add(this.panel4);
            this.splitContainer2.Size = new System.Drawing.Size(612, 641);
            this.splitContainer2.SplitterDistance = 294;
            this.splitContainer2.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(612, 23);
            this.panel2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Original Video";
            // 
            // circleImageBox
            // 
            this.circleImageBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.circleImageBox.Cursor = System.Windows.Forms.Cursors.Cross;
            this.circleImageBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.circleImageBox.Location = new System.Drawing.Point(0, 23);
            this.circleImageBox.Name = "circleImageBox";
            this.circleImageBox.Size = new System.Drawing.Size(612, 320);
            this.circleImageBox.TabIndex = 4;
            this.circleImageBox.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(612, 23);
            this.panel4.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "Detected Coins";
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.triangleRectangleImageBox);
            this.splitContainer3.Panel1.Controls.Add(this.panel3);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.groupBox7);
            this.splitContainer3.Panel2.Controls.Add(this.groupBox6);
            this.splitContainer3.Panel2.Controls.Add(this.groupBox5);
            this.splitContainer3.Panel2.Controls.Add(this.groupBox4);
            this.splitContainer3.Panel2.Controls.Add(this.groupBox3);
            this.splitContainer3.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer3.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer3.Panel2.Controls.Add(this.panel5);
            this.splitContainer3.Size = new System.Drawing.Size(734, 641);
            this.splitContainer3.SplitterDistance = 315;
            this.splitContainer3.TabIndex = 0;
            // 
            // triangleRectangleImageBox
            // 
            this.triangleRectangleImageBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.triangleRectangleImageBox.Cursor = System.Windows.Forms.Cursors.Cross;
            this.triangleRectangleImageBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.triangleRectangleImageBox.Location = new System.Drawing.Point(0, 23);
            this.triangleRectangleImageBox.Name = "triangleRectangleImageBox";
            this.triangleRectangleImageBox.Size = new System.Drawing.Size(734, 292);
            this.triangleRectangleImageBox.TabIndex = 4;
            this.triangleRectangleImageBox.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(734, 23);
            this.panel3.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "Camera";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.btnRobotArmOff);
            this.groupBox7.Controls.Add(this.btnRobotArmOn);
            this.groupBox7.Location = new System.Drawing.Point(554, 34);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(121, 127);
            this.groupBox7.TabIndex = 10;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Robot ARM";
            // 
            // btnRobotArmOff
            // 
            this.btnRobotArmOff.Location = new System.Drawing.Point(16, 70);
            this.btnRobotArmOff.Name = "btnRobotArmOff";
            this.btnRobotArmOff.Size = new System.Drawing.Size(88, 41);
            this.btnRobotArmOff.TabIndex = 1;
            this.btnRobotArmOff.Text = "OFF";
            this.btnRobotArmOff.UseVisualStyleBackColor = true;
            this.btnRobotArmOff.Click += new System.EventHandler(this.btnRobotArmOff_Click);
            // 
            // btnRobotArmOn
            // 
            this.btnRobotArmOn.Location = new System.Drawing.Point(16, 20);
            this.btnRobotArmOn.Name = "btnRobotArmOn";
            this.btnRobotArmOn.Size = new System.Drawing.Size(88, 43);
            this.btnRobotArmOn.TabIndex = 0;
            this.btnRobotArmOn.Text = "ON";
            this.btnRobotArmOn.UseVisualStyleBackColor = true;
            this.btnRobotArmOn.Click += new System.EventHandler(this.btnRobotArmOn_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btn_OpenPort);
            this.groupBox6.Controls.Add(this.comboBox_Device);
            this.groupBox6.Location = new System.Drawing.Point(414, 172);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(121, 119);
            this.groupBox6.TabIndex = 9;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Robot Device";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btn_Pull);
            this.groupBox5.Controls.Add(this.btnDrop);
            this.groupBox5.Location = new System.Drawing.Point(24, 237);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(156, 54);
            this.groupBox5.TabIndex = 8;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Hands";
            // 
            // btn_Pull
            // 
            this.btn_Pull.Location = new System.Drawing.Point(11, 25);
            this.btn_Pull.Name = "btn_Pull";
            this.btn_Pull.Size = new System.Drawing.Size(64, 23);
            this.btn_Pull.TabIndex = 2;
            this.btn_Pull.Text = "Grab";
            this.btn_Pull.UseVisualStyleBackColor = true;
            this.btn_Pull.Click += new System.EventHandler(this.btn_Pull_Click);
            // 
            // btnDrop
            // 
            this.btnDrop.Location = new System.Drawing.Point(81, 25);
            this.btnDrop.Name = "btnDrop";
            this.btnDrop.Size = new System.Drawing.Size(64, 23);
            this.btnDrop.TabIndex = 3;
            this.btnDrop.Text = "Drop";
            this.btnDrop.UseVisualStyleBackColor = true;
            this.btnDrop.Click += new System.EventHandler(this.btnDrop_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button4);
            this.groupBox4.Controls.Add(this.button3);
            this.groupBox4.Location = new System.Drawing.Point(18, 167);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(162, 59);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Z-Pos";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(90, 21);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(61, 23);
            this.button4.TabIndex = 1;
            this.button4.Text = "Z-";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(17, 21);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(64, 23);
            this.button3.TabIndex = 0;
            this.button3.Text = "Z+";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_Back2StartPos);
            this.groupBox3.Controls.Add(this.btnGo2Pos);
            this.groupBox3.Controls.Add(this.tbPosZ);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.tbPosY);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.tbPosX);
            this.groupBox3.Location = new System.Drawing.Point(186, 172);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(216, 119);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Any-Pos";
            // 
            // btn_Back2StartPos
            // 
            this.btn_Back2StartPos.Location = new System.Drawing.Point(146, 68);
            this.btn_Back2StartPos.Name = "btn_Back2StartPos";
            this.btn_Back2StartPos.Size = new System.Drawing.Size(64, 39);
            this.btn_Back2StartPos.TabIndex = 7;
            this.btn_Back2StartPos.Text = "Back";
            this.btn_Back2StartPos.UseVisualStyleBackColor = true;
            this.btn_Back2StartPos.Click += new System.EventHandler(this.btn_Back2StartPos_Click);
            // 
            // btnGo2Pos
            // 
            this.btnGo2Pos.Location = new System.Drawing.Point(146, 21);
            this.btnGo2Pos.Name = "btnGo2Pos";
            this.btnGo2Pos.Size = new System.Drawing.Size(64, 40);
            this.btnGo2Pos.TabIndex = 6;
            this.btnGo2Pos.Text = "Go";
            this.btnGo2Pos.UseVisualStyleBackColor = true;
            this.btnGo2Pos.Click += new System.EventHandler(this.btnGo2Pos_Click);
            // 
            // tbPosZ
            // 
            this.tbPosZ.Location = new System.Drawing.Point(36, 92);
            this.tbPosZ.Name = "tbPosZ";
            this.tbPosZ.Size = new System.Drawing.Size(88, 21);
            this.tbPosZ.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 95);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 12);
            this.label8.TabIndex = 4;
            this.label8.Text = "Z:";
            // 
            // tbPosY
            // 
            this.tbPosY.Location = new System.Drawing.Point(36, 58);
            this.tbPosY.Name = "tbPosY";
            this.tbPosY.Size = new System.Drawing.Size(87, 21);
            this.tbPosY.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 12);
            this.label7.TabIndex = 2;
            this.label7.Text = "Y:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 12);
            this.label6.TabIndex = 1;
            this.label6.Text = "X:";
            // 
            // tbPosX
            // 
            this.tbPosX.Location = new System.Drawing.Point(35, 23);
            this.tbPosX.Name = "tbPosX";
            this.tbPosX.Size = new System.Drawing.Size(88, 21);
            this.tbPosX.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblOffsets);
            this.groupBox2.Controls.Add(this.btn_ysub);
            this.groupBox2.Controls.Add(this.btn_yplus);
            this.groupBox2.Controls.Add(this.btn_xsub);
            this.groupBox2.Controls.Add(this.btn_xplus);
            this.groupBox2.Location = new System.Drawing.Point(18, 34);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(378, 127);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Offsets";
            // 
            // btn_ysub
            // 
            this.btn_ysub.Location = new System.Drawing.Point(142, 58);
            this.btn_ysub.Name = "btn_ysub";
            this.btn_ysub.Size = new System.Drawing.Size(65, 23);
            this.btn_ysub.TabIndex = 3;
            this.btn_ysub.Text = "Y-";
            this.btn_ysub.UseVisualStyleBackColor = true;
            this.btn_ysub.Click += new System.EventHandler(this.btn_ysub_Click);
            // 
            // btn_yplus
            // 
            this.btn_yplus.Location = new System.Drawing.Point(6, 58);
            this.btn_yplus.Name = "btn_yplus";
            this.btn_yplus.Size = new System.Drawing.Size(64, 23);
            this.btn_yplus.TabIndex = 2;
            this.btn_yplus.Text = "Y+";
            this.btn_yplus.UseVisualStyleBackColor = true;
            this.btn_yplus.Click += new System.EventHandler(this.btn_yplus_Click);
            // 
            // btn_xsub
            // 
            this.btn_xsub.Location = new System.Drawing.Point(75, 87);
            this.btn_xsub.Name = "btn_xsub";
            this.btn_xsub.Size = new System.Drawing.Size(60, 23);
            this.btn_xsub.TabIndex = 1;
            this.btn_xsub.Text = "X-";
            this.btn_xsub.UseVisualStyleBackColor = true;
            this.btn_xsub.Click += new System.EventHandler(this.btn_xsub_Click);
            // 
            // btn_xplus
            // 
            this.btn_xplus.Location = new System.Drawing.Point(75, 29);
            this.btn_xplus.Name = "btn_xplus";
            this.btn_xplus.Size = new System.Drawing.Size(60, 23);
            this.btn_xplus.TabIndex = 0;
            this.btn_xplus.Text = "X+";
            this.btn_xplus.UseVisualStyleBackColor = true;
            this.btn_xplus.Click += new System.EventHandler(this.btn_xplus_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_stop);
            this.groupBox1.Controls.Add(this.btn_capture);
            this.groupBox1.Location = new System.Drawing.Point(402, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(133, 127);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "System";
            // 
            // btn_stop
            // 
            this.btn_stop.Location = new System.Drawing.Point(26, 70);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(75, 23);
            this.btn_stop.TabIndex = 1;
            this.btn_stop.Text = "Stop";
            this.btn_stop.UseVisualStyleBackColor = true;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // btn_capture
            // 
            this.btn_capture.Location = new System.Drawing.Point(26, 29);
            this.btn_capture.Name = "btn_capture";
            this.btn_capture.Size = new System.Drawing.Size(75, 23);
            this.btn_capture.TabIndex = 0;
            this.btn_capture.Text = "Tracking";
            this.btn_capture.UseVisualStyleBackColor = true;
            this.btn_capture.Click += new System.EventHandler(this.btn_capture_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label4);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(734, 23);
            this.panel5.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "Control Panel";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lblOffsets
            // 
            this.lblOffsets.AutoSize = true;
            this.lblOffsets.Location = new System.Drawing.Point(250, 63);
            this.lblOffsets.Name = "lblOffsets";
            this.lblOffsets.Size = new System.Drawing.Size(0, 12);
            this.lblOffsets.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 690);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.Text = "Coin Detection";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.circleImageBox)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            this.splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.triangleRectangleImageBox)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label4;
        private Emgu.CV.UI.ImageBox circleImageBox;
        private Emgu.CV.UI.ImageBox triangleRectangleImageBox;
        private System.Windows.Forms.TextBox fileNameTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button loadImageButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnGo2Pos;
        private System.Windows.Forms.TextBox tbPosZ;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbPosY;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbPosX;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_ysub;
        private System.Windows.Forms.Button btn_yplus;
        private System.Windows.Forms.Button btn_xsub;
        private System.Windows.Forms.Button btn_xplus;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.Button btn_capture;
        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.Button btn_OpenPort;
        private System.Windows.Forms.ComboBox comboBox_Device;
        private System.Windows.Forms.Button btnDrop;
        private System.Windows.Forms.Button btn_Pull;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btn_Back2StartPos;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button btnRobotArmOff;
        private System.Windows.Forms.Button btnRobotArmOn;
        private System.Windows.Forms.Label lblOffsets;

    }
}

