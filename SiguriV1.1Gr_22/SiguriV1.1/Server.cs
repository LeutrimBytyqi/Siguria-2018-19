using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SiguriV1._1
{
    public partial class Server : Form
    {
        UdpClient server;
        IPEndPoint endPoint;
        public Server()
        {
            InitializeComponent();
        }

      

        private void btnStart_Click(object sender, EventArgs e)
        {
            server = new UdpClient(int.Parse(txtServerPort.Text));
            endPoint = new IPEndPoint(IPAddress.Any, 0);
            WriteLog("Server started...");


            btnStart.Enabled = false;




        }

        private void ServerStart()
        {
            while (true)
            {
                //reveice
                byte[] buffer = server.Receive(ref endPoint);
                //portnumber.hostname.msg
                string[] msg = Encoding.Unicode.GetString(buffer).Split('.');

                WriteLog("Client at Port :" + msg[0]);
                WriteLog(" at Host :" + msg[1]);
                WriteLog(" need :" + msg[2]);

                //Send
                buffer = Encoding.Unicode.GetBytes(DateTime.Now.ToString());
                server.Send(buffer, buffer.Length, msg[1], int.Parse(msg[0]));

            }
        }


        private void WriteLog(string msg)
        {
            MethodInvoker invoker = new MethodInvoker
                (delegate { txtLog.AppendText(msg + Environment.NewLine); });
            this.BeginInvoke(invoker);
        }

        private void newClientBtn_Click(object sender, EventArgs e)
        {
            Client c = new Client();
            c.Show();
        }
    }
}
