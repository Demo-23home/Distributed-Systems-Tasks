using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        Socket client;
        byte[] buffer = new byte[1024];
        public Form2()
        {
            InitializeComponent();
            SetIpAddress();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        private void SetIpAddress()
        {
            string hostname = Dns.GetHostName();
            IPHostEntry iphost = Dns.GetHostByName(hostname);
            txtIp.Text = iphost.AddressList[iphost.AddressList.Length-1].ToString();
        }
        private void UpdateGui(bool isconnected)
        {
            btnConnecttoServer.Enabled = !isconnected;
            btnsendtoserver.Enabled = isconnected;
            lblstatus.Text = isconnected ? "Connected" : "Disconnected";
            lblstatus.ForeColor = isconnected ? Color.Green : Color.Red;
        }

        private void btnConnecttoServer_Click(object sender, EventArgs e)
        {
            client = new Socket(AddressFamily.InterNetwork,SocketType.Stream,ProtocolType.Tcp);
            int portnum = int.Parse(txtPortnum.Text);
            IPAddress ip = IPAddress.Parse(txtIp.Text);
            client.Connect(new IPEndPoint(ip,portnum));
            UpdateGui(true);
            writelog("Connected to Server");
            WaitingforData(client);

        }
        private void WaitingforData(Socket client)
        {
            client.BeginReceive(buffer,0,buffer.Length,SocketFlags.None,new AsyncCallback(OnRecieve), null);
        }
        // Handle receiving messages from the server
        private void OnRecieve(IAsyncResult ar)
        {
            int bytesRead = client.EndReceive(ar);
            if (bytesRead > 0)
            {
                string msg = Encoding.Unicode.GetString(buffer, 0, bytesRead);
                writelog(msg);
                WaitingforData(client);
            }
            else
            {
                // Handle disconnection or errors
                client.Close();
                UpdateGui(false);
                writelog("Disconnected from server");
            }
        }
        private void writelog (string msg)
        {
            MethodInvoker inv = new MethodInvoker(delegate { txtLog.AppendText(msg + Environment.NewLine); });
            this.BeginInvoke(inv);
        }

        private void btnsendtoserver_Click(object sender, EventArgs e)
        {
            string msg = txtsendtoServer.Text;
            buffer = Encoding.Unicode.GetBytes(msg);
            client.Send(buffer);
        }
    }
}
