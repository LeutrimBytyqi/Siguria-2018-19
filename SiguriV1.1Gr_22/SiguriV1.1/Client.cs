using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SiguriV1._1
{
    public partial class Client : Form
    {
        UdpClient client;
        IPEndPoint endPoint;
        public Client()
        {
            InitializeComponent();
        }


       

        private void btnSend_Click(object sender, EventArgs e)
        {
            //send message to server...
            int serverPort = int.Parse(txtServerPort.Text);
            int clientPort = int.Parse(txtClientPort.Text);
            string hostName = txtHostname.Text;

            
            client = new UdpClient(clientPort);

            //portnumber.hostname.msg
            string msg = clientPort + "." + hostName + "." + txtMsg.Text;
            byte[] buffer = Encoding.Unicode.GetBytes(msg);



            //send msg
            client.Send(buffer, buffer.Length, hostName, serverPort);

            //receive
            endPoint = new IPEndPoint(IPAddress.Any, 0);
            buffer = client.Receive(ref endPoint);

            msg = Encoding.Unicode.GetString(buffer);
            WriteLog(msg);

        }

        private void    WriteLog(string msg)
        {
            MethodInvoker invoker = new MethodInvoker (delegate { txtLog.AppendText("Server said:" + msg + Environment.NewLine); });
            this.BeginInvoke(invoker);
        }


    }
}
