namespace Test_GUI_Drawing_Graph
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
            this.components = new System.ComponentModel.Container();
            this.zedGraphControl1 = new ZedGraph.ZedGraphControl();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btConnect = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.btRun = new System.Windows.Forms.Button();
            this.btClear = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelStatus = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPID = new System.Windows.Forms.Button();
            this.txtKp = new System.Windows.Forms.TextBox();
            this.txtKi = new System.Windows.Forms.TextBox();
            this.txtKd = new System.Windows.Forms.TextBox();
            this.lbKp = new System.Windows.Forms.Label();
            this.lbKi = new System.Windows.Forms.Label();
            this.lbKd = new System.Windows.Forms.Label();
            this.lbBaud = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.lbSP = new System.Windows.Forms.Label();
            this.txtSp = new System.Windows.Forms.TextBox();
            this.lbPV = new System.Windows.Forms.Label();
            this.txtPv = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnReverse = new System.Windows.Forms.Button();
            this.btnForward = new System.Windows.Forms.Button();
            this.txtTemp = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // zedGraphControl1
            // 
            this.zedGraphControl1.Location = new System.Drawing.Point(481, 1);
            this.zedGraphControl1.Margin = new System.Windows.Forms.Padding(5);
            this.zedGraphControl1.Name = "zedGraphControl1";
            this.zedGraphControl1.ScrollGrace = 0D;
            this.zedGraphControl1.ScrollMaxX = 0D;
            this.zedGraphControl1.ScrollMaxY = 0D;
            this.zedGraphControl1.ScrollMaxY2 = 0D;
            this.zedGraphControl1.ScrollMinX = 0D;
            this.zedGraphControl1.ScrollMinY = 0D;
            this.zedGraphControl1.ScrollMinY2 = 0D;
            this.zedGraphControl1.Size = new System.Drawing.Size(867, 406);
            this.zedGraphControl1.TabIndex = 0;
            this.zedGraphControl1.UseExtendedPrintDialog = true;
            this.zedGraphControl1.Load += new System.EventHandler(this.zedGraphControl1_Load);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(11, 79);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btConnect
            // 
            this.btConnect.Location = new System.Drawing.Point(287, 86);
            this.btConnect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btConnect.Name = "btConnect";
            this.btConnect.Size = new System.Drawing.Size(86, 46);
            this.btConnect.TabIndex = 2;
            this.btConnect.Text = "Connect";
            this.btConnect.UseVisualStyleBackColor = true;
            this.btConnect.Click += new System.EventHandler(this.btConnect_Click);
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(100, 353);
            this.btExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(181, 54);
            this.btExit.TabIndex = 4;
            this.btExit.Text = "Exit";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // btRun
            // 
            this.btRun.Location = new System.Drawing.Point(379, 86);
            this.btRun.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btRun.Name = "btRun";
            this.btRun.Size = new System.Drawing.Size(85, 46);
            this.btRun.TabIndex = 5;
            this.btRun.Text = "Run";
            this.btRun.UseVisualStyleBackColor = true;
            this.btRun.Click += new System.EventHandler(this.btRun_Click);
            // 
            // btClear
            // 
            this.btClear.Location = new System.Drawing.Point(288, 141);
            this.btClear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(85, 46);
            this.btClear.TabIndex = 7;
            this.btClear.Text = "Clear";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(11, 116);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(120, 23);
            this.progressBar1.TabIndex = 8;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // serialPort
            // 
            this.serialPort.PortName = "COM13";
            this.serialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.SerialDataReceived);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(22, 141);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(7, 16);
            this.labelStatus.TabIndex = 10;
            this.labelStatus.Text = "\r\n";
            this.labelStatus.Click += new System.EventHandler(this.labelStatus_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "_____________";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnPID
            // 
            this.btnPID.Location = new System.Drawing.Point(22, 200);
            this.btnPID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPID.Name = "btnPID";
            this.btnPID.Size = new System.Drawing.Size(75, 47);
            this.btnPID.TabIndex = 12;
            this.btnPID.Text = "PID";
            this.btnPID.UseVisualStyleBackColor = true;
            this.btnPID.Click += new System.EventHandler(this.btnPID_Click);
            // 
            // txtKp
            // 
            this.txtKp.Location = new System.Drawing.Point(52, 281);
            this.txtKp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtKp.Name = "txtKp";
            this.txtKp.Size = new System.Drawing.Size(57, 22);
            this.txtKp.TabIndex = 16;
            // 
            // txtKi
            // 
            this.txtKi.Location = new System.Drawing.Point(151, 281);
            this.txtKi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtKi.Name = "txtKi";
            this.txtKi.Size = new System.Drawing.Size(57, 22);
            this.txtKi.TabIndex = 17;
            // 
            // txtKd
            // 
            this.txtKd.Location = new System.Drawing.Point(262, 281);
            this.txtKd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtKd.Name = "txtKd";
            this.txtKd.Size = new System.Drawing.Size(57, 22);
            this.txtKd.TabIndex = 18;
            // 
            // lbKp
            // 
            this.lbKp.AutoSize = true;
            this.lbKp.Location = new System.Drawing.Point(22, 286);
            this.lbKp.Name = "lbKp";
            this.lbKp.Size = new System.Drawing.Size(23, 16);
            this.lbKp.TabIndex = 19;
            this.lbKp.Text = "Kp";
            // 
            // lbKi
            // 
            this.lbKi.AutoSize = true;
            this.lbKi.Location = new System.Drawing.Point(126, 286);
            this.lbKi.Name = "lbKi";
            this.lbKi.Size = new System.Drawing.Size(18, 16);
            this.lbKi.TabIndex = 20;
            this.lbKi.Text = "Ki";
            // 
            // lbKd
            // 
            this.lbKd.AutoSize = true;
            this.lbKd.Location = new System.Drawing.Point(230, 286);
            this.lbKd.Name = "lbKd";
            this.lbKd.Size = new System.Drawing.Size(23, 16);
            this.lbKd.TabIndex = 21;
            this.lbKd.Text = "Kd";
            // 
            // lbBaud
            // 
            this.lbBaud.AutoSize = true;
            this.lbBaud.Location = new System.Drawing.Point(137, 86);
            this.lbBaud.Name = "lbBaud";
            this.lbBaud.Size = new System.Drawing.Size(126, 16);
            this.lbBaud.TabIndex = 22;
            this.lbBaud.Text = "_________________";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(379, 201);
            this.btnSend.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(85, 46);
            this.btnSend.TabIndex = 23;
            this.btnSend.Text = "Send Data";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(379, 141);
            this.btnStop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(85, 46);
            this.btnStop.TabIndex = 24;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // lbSP
            // 
            this.lbSP.AutoSize = true;
            this.lbSP.Location = new System.Drawing.Point(1068, 18);
            this.lbSP.Name = "lbSP";
            this.lbSP.Size = new System.Drawing.Size(57, 16);
            this.lbSP.TabIndex = 26;
            this.lbSP.Text = "SetPoint";
            // 
            // txtSp
            // 
            this.txtSp.Location = new System.Drawing.Point(1196, 15);
            this.txtSp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSp.Name = "txtSp";
            this.txtSp.Size = new System.Drawing.Size(57, 22);
            this.txtSp.TabIndex = 25;
            this.txtSp.TextChanged += new System.EventHandler(this.txtSp_TextChanged);
            // 
            // lbPV
            // 
            this.lbPV.AutoSize = true;
            this.lbPV.Location = new System.Drawing.Point(1068, 53);
            this.lbPV.Name = "lbPV";
            this.lbPV.Size = new System.Drawing.Size(118, 16);
            this.lbPV.TabIndex = 28;
            this.lbPV.Text = "Process Variables";
            // 
            // txtPv
            // 
            this.txtPv.Location = new System.Drawing.Point(1196, 50);
            this.txtPv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPv.Name = "txtPv";
            this.txtPv.Size = new System.Drawing.Size(57, 22);
            this.txtPv.TabIndex = 27;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(287, 201);
            this.btnOK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(86, 46);
            this.btnOK.TabIndex = 33;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnReverse
            // 
            this.btnReverse.Location = new System.Drawing.Point(206, 210);
            this.btnReverse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReverse.Name = "btnReverse";
            this.btnReverse.Size = new System.Drawing.Size(75, 47);
            this.btnReverse.TabIndex = 34;
            this.btnReverse.Text = "Reverse";
            this.btnReverse.UseVisualStyleBackColor = true;
            this.btnReverse.Click += new System.EventHandler(this.btnReverse_Click);
            // 
            // btnForward
            // 
            this.btnForward.Location = new System.Drawing.Point(125, 210);
            this.btnForward.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnForward.Name = "btnForward";
            this.btnForward.Size = new System.Drawing.Size(75, 47);
            this.btnForward.TabIndex = 35;
            this.btnForward.Text = "Forward";
            this.btnForward.UseVisualStyleBackColor = true;
            this.btnForward.Click += new System.EventHandler(this.btnForward_Click);
            // 
            // txtTemp
            // 
            this.txtTemp.Location = new System.Drawing.Point(393, 353);
            this.txtTemp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTemp.Name = "txtTemp";
            this.txtTemp.Size = new System.Drawing.Size(57, 22);
            this.txtTemp.TabIndex = 36;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1361, 435);
            this.Controls.Add(this.txtTemp);
            this.Controls.Add(this.btnForward);
            this.Controls.Add(this.btnReverse);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lbPV);
            this.Controls.Add(this.txtPv);
            this.Controls.Add(this.lbSP);
            this.Controls.Add(this.txtSp);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.lbBaud);
            this.Controls.Add(this.lbKd);
            this.Controls.Add(this.lbKi);
            this.Controls.Add(this.lbKp);
            this.Controls.Add(this.txtKd);
            this.Controls.Add(this.txtKi);
            this.Controls.Add(this.txtKp);
            this.Controls.Add(this.btnPID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.btRun);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btConnect);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.zedGraphControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ZedGraph.ZedGraphControl zedGraphControl1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btConnect;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Button btRun;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPID;
        private System.Windows.Forms.TextBox txtKp;
        private System.Windows.Forms.TextBox txtKi;
        private System.Windows.Forms.TextBox txtKd;
        private System.Windows.Forms.Label lbKp;
        private System.Windows.Forms.Label lbKi;
        private System.Windows.Forms.Label lbKd;
        private System.Windows.Forms.Label lbBaud;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label lbSP;
        private System.Windows.Forms.TextBox txtSp;
        private System.Windows.Forms.Label lbPV;
        private System.Windows.Forms.TextBox txtPv;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnReverse;
        private System.Windows.Forms.Button btnForward;
        private System.Windows.Forms.TextBox txtTemp;
    }
}

