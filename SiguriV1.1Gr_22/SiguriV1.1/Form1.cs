using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.IO;

namespace SiguriV1._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Client_Click(object sender, EventArgs e)
        {
            int recv;
            byte[] data =new byte[1024];

           IPEndPoint endpoint = new IPEndPoint(IPAddress.Any, 904);

            Socket newSocket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            newSocket.Bind(endpoint);

            Console.WriteLine("Waiting for a client...");

            IPEndPoint send = new IPEndPoint(IPAddress.Any, 904);
            EndPoint tmpRemote = (EndPoint)send;


            recv = newSocket.ReceiveFrom(data, ref tmpRemote);

            Console.Write("Message received from {0}", tmpRemote.ToString());
            Console.WriteLine(Encoding.ASCII.GetString(data, 0, recv));

            string welcome= "Welcome to my server";
            data = Encoding.ASCII.GetBytes(welcome);

            if (newSocket.Connected)
            {
                newSocket.Send(data);
            }
            while (true)
            {
                if (!newSocket.Connected)
                {
                    Console.WriteLine("Client Disconnected.");
                }

                data = new byte[1024];
                recv = newSocket.ReceiveFrom(data, ref tmpRemote);

                if (recv == 0)
                {
                    break;
                }
                Console.WriteLine(Encoding.ASCII.GetString(data, 0, recv));
            }

            newSocket.Close();
        }
    }
}
