using SimpleTCP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCP_IP_SerCli
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SimpleTcpClient client;
        SimpleTcpServer server;
        private void Form1_Load(object sender, EventArgs e)
        {
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnStart.BringToFront();
            btnStop.SendToBack();
            server = new SimpleTcpServer();
            client = new SimpleTcpClient();
            server.Delimiter = 0x13;//enter
            server.StringEncoder = Encoding.UTF8;
            server.DataReceived += Server_DataReceived;
            client.DataReceived += Client_DataReceived;
            server.ClientConnected += Server_ClientConnected;
            server.DelimiterDataReceived += Server_DelimiterDataReceived;

        }

        

        private void Server_DelimiterDataReceived(object sender, SimpleTCP.Message e)
        {
            throw new NotImplementedException();
        }

        private void Server_ClientConnected(object sender, TcpClient e)
        {
            txtConsole.Invoke((MethodInvoker)delegate ()
            {
                txtConsole.Text += $"Client connected!{Environment.NewLine}";
            });
        }

        private void Client_DataReceived(object sender, SimpleTCP.Message e)
        {
            string x = "";
            txtConsole.Invoke((MethodInvoker)delegate ()
            {
                x = e.MessageString;
                if (!string.IsNullOrWhiteSpace(x.ToString()) && rbtnClient.Checked)
                {
                    txtConsole.Text += "Server: " + x.ToString() + Environment.NewLine;
                }
            });
        }
        private void Server_DataReceived(object sender, SimpleTCP.Message e)
        {
            string a = "";
            txtConsole.Invoke((MethodInvoker)delegate ()
            {
                
                a = e.MessageString;
                if(!string.IsNullOrWhiteSpace(a.ToString()) && rbtnServer.Checked)
                {
                    txtConsole.Text += "Client: " + a.ToString() + Environment.NewLine;
                }
            });
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            
            //btnStop.BringToFront();
            if (rbtnServer.Checked)
            {
                
                try
                {
                    
                    System.Net.IPAddress ipAddress = System.Net.IPAddress.Parse(txtIP.Text);
                    server.Start(ipAddress, Convert.ToInt32(txtPort.Text));
                    txtConsole.Text += $"Server started...{Environment.NewLine}";
                    btnStop.BringToFront();
                    txtIP.Enabled = false;
                    txtPort.Enabled = false;
                    rbtnClient.Enabled = false;
                }
                catch (Exception)
                {
                    btnStop.SendToBack();
                    txtConsole.Text += "Could not start the server!" + Environment.NewLine;
                }
            }
            if (rbtnClient.Checked)
            {
                //btnStart.SendToBack();
                 
                try
                {
                    
                    //Connect to server
                    client.Connect(txtIP.Text, Convert.ToInt32(txtPort.Text));
                    btnStop.BringToFront();
                    txtConsole.Text += "Connected to server" + Environment.NewLine;
                    txtIP.Enabled = false;
                    txtPort.Enabled = false;
                    rbtnServer.Enabled = false;
                }
                catch (Exception)
                {
                    
                    txtConsole.Text += "Could not connect to server!" + Environment.NewLine;
                    btnStart.Enabled = true;
                }
            }

        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (server.IsStarted && rbtnServer.Checked)
            {
                server.Stop();
                txtConsole.Text += $"Server stopped...{Environment.NewLine}";
                btnStart.BringToFront();
                btnStop.SendToBack();
                txtIP.Enabled = true;
                txtPort.Enabled = true;
                rbtnClient.Enabled = true;
            }
            if(rbtnClient.Checked)
            {
                client.Disconnect();
                txtConsole.Text += "Disconnected" + Environment.NewLine;
                btnStart.BringToFront();
                btnStop.SendToBack();
                txtIP.Enabled = true;
                txtPort.Enabled = true;
                rbtnServer.Enabled = true;
            }
        }

        private void txtSend_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                btnSend_Click(this, new EventArgs());
            }
            
        }

        private void btnClear1_Click(object sender, EventArgs e)
        {
            txtSend.Text = "";
        }

        private void btnClear2_Click(object sender, EventArgs e)
        {
            txtConsole.Text = "";
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (rbtnServer.Checked && !string.IsNullOrEmpty(txtSend.Text))
            {
                server.Broadcast(txtSend.Text);
                txtConsole.Text += "Me: " + txtSend.Text + Environment.NewLine;
            }
            if (!string.IsNullOrEmpty(txtSend.Text)&&rbtnClient.Checked)
            {
                client.Write(txtSend.Text);
                txtConsole.Text += "Me: " + txtSend.Text + Environment.NewLine;
            }
        }
    }
}
