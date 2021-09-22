
namespace TCP_IP_SerCli
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
            this.rbtnServer = new System.Windows.Forms.RadioButton();
            this.rbtnClient = new System.Windows.Forms.RadioButton();
            this.btnStart = new System.Windows.Forms.Button();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.lbIP = new System.Windows.Forms.Label();
            this.lblPort = new System.Windows.Forms.Label();
            this.bxSend = new System.Windows.Forms.GroupBox();
            this.btnClear1 = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtSend = new System.Windows.Forms.TextBox();
            this.bxConsole = new System.Windows.Forms.GroupBox();
            this.btnClear2 = new System.Windows.Forms.Button();
            this.txtConsole = new System.Windows.Forms.TextBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.bxSend.SuspendLayout();
            this.bxConsole.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbtnServer
            // 
            this.rbtnServer.AutoSize = true;
            this.rbtnServer.Checked = true;
            this.rbtnServer.Location = new System.Drawing.Point(283, 22);
            this.rbtnServer.Name = "rbtnServer";
            this.rbtnServer.Size = new System.Drawing.Size(56, 17);
            this.rbtnServer.TabIndex = 2;
            this.rbtnServer.TabStop = true;
            this.rbtnServer.Text = "Server";
            this.rbtnServer.UseVisualStyleBackColor = true;
            // 
            // rbtnClient
            // 
            this.rbtnClient.AutoSize = true;
            this.rbtnClient.Location = new System.Drawing.Point(283, 62);
            this.rbtnClient.Name = "rbtnClient";
            this.rbtnClient.Size = new System.Drawing.Size(51, 17);
            this.rbtnClient.TabIndex = 3;
            this.rbtnClient.Text = "Client";
            this.rbtnClient.UseVisualStyleBackColor = true;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.YellowGreen;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnStart.Location = new System.Drawing.Point(383, 20);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(107, 59);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(61, 20);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(164, 20);
            this.txtIP.TabIndex = 5;
            this.txtIP.Text = "169.254.209.135";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(61, 60);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(81, 20);
            this.txtPort.TabIndex = 6;
            this.txtPort.Text = "5000";
            // 
            // lbIP
            // 
            this.lbIP.AutoSize = true;
            this.lbIP.Location = new System.Drawing.Point(12, 24);
            this.lbIP.Name = "lbIP";
            this.lbIP.Size = new System.Drawing.Size(17, 13);
            this.lbIP.TabIndex = 7;
            this.lbIP.Text = "IP";
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Location = new System.Drawing.Point(12, 64);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(26, 13);
            this.lblPort.TabIndex = 8;
            this.lblPort.Text = "Port";
            // 
            // bxSend
            // 
            this.bxSend.Controls.Add(this.btnClear1);
            this.bxSend.Controls.Add(this.btnSend);
            this.bxSend.Controls.Add(this.txtSend);
            this.bxSend.Location = new System.Drawing.Point(3, 105);
            this.bxSend.Name = "bxSend";
            this.bxSend.Size = new System.Drawing.Size(487, 78);
            this.bxSend.TabIndex = 9;
            this.bxSend.TabStop = false;
            this.bxSend.Text = "Send";
            // 
            // btnClear1
            // 
            this.btnClear1.Location = new System.Drawing.Point(346, 45);
            this.btnClear1.Name = "btnClear1";
            this.btnClear1.Size = new System.Drawing.Size(132, 23);
            this.btnClear1.TabIndex = 3;
            this.btnClear1.Text = "Clear";
            this.btnClear1.UseVisualStyleBackColor = true;
            this.btnClear1.Click += new System.EventHandler(this.btnClear1_Click);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(9, 45);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(132, 24);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtSend
            // 
            this.txtSend.Location = new System.Drawing.Point(9, 19);
            this.txtSend.Name = "txtSend";
            this.txtSend.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSend.Size = new System.Drawing.Size(469, 20);
            this.txtSend.TabIndex = 1;
            this.txtSend.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSend_KeyDown);
            // 
            // bxConsole
            // 
            this.bxConsole.Controls.Add(this.btnClear2);
            this.bxConsole.Controls.Add(this.txtConsole);
            this.bxConsole.Location = new System.Drawing.Point(3, 204);
            this.bxConsole.Name = "bxConsole";
            this.bxConsole.Size = new System.Drawing.Size(487, 199);
            this.bxConsole.TabIndex = 10;
            this.bxConsole.TabStop = false;
            this.bxConsole.Text = "Console";
            // 
            // btnClear2
            // 
            this.btnClear2.Location = new System.Drawing.Point(346, 168);
            this.btnClear2.Name = "btnClear2";
            this.btnClear2.Size = new System.Drawing.Size(132, 23);
            this.btnClear2.TabIndex = 4;
            this.btnClear2.Text = "Clear";
            this.btnClear2.UseVisualStyleBackColor = true;
            this.btnClear2.Click += new System.EventHandler(this.btnClear2_Click);
            // 
            // txtConsole
            // 
            this.txtConsole.Location = new System.Drawing.Point(9, 19);
            this.txtConsole.Multiline = true;
            this.txtConsole.Name = "txtConsole";
            this.txtConsole.ReadOnly = true;
            this.txtConsole.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtConsole.Size = new System.Drawing.Size(469, 143);
            this.txtConsole.TabIndex = 1;
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.DarkRed;
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnStop.Location = new System.Drawing.Point(383, 20);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(107, 59);
            this.btnStop.TabIndex = 11;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 409);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.bxConsole);
            this.Controls.Add(this.bxSend);
            this.Controls.Add(this.lblPort);
            this.Controls.Add(this.lbIP);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.txtIP);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.rbtnClient);
            this.Controls.Add(this.rbtnServer);
            this.Name = "Form1";
            this.Text = "TCP/IP SerCli";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.bxSend.ResumeLayout(false);
            this.bxSend.PerformLayout();
            this.bxConsole.ResumeLayout(false);
            this.bxConsole.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbtnServer;
        private System.Windows.Forms.RadioButton rbtnClient;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label lbIP;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.GroupBox bxSend;
        private System.Windows.Forms.TextBox txtSend;
        private System.Windows.Forms.GroupBox bxConsole;
        private System.Windows.Forms.TextBox txtConsole;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnClear1;
        private System.Windows.Forms.Button btnClear2;
    }
}

