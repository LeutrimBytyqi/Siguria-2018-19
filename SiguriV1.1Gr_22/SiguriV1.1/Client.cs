using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SiguriV1._1
{
    public partial class Client : Form
    {
        UdpClient client;
        IPEndPoint endPoint;
        byte[] KEY;
        byte[] IV;
        byte[] encryptedKEY;
        byte[] encryptedMSG;
        byte[] pergjigjjaMsg;

        public Client()
        {
            InitializeComponent();
        }
        MySqlConnection connection
           = new MySqlConnection("datasource=localhost;" +
               "port=3306;database=employees;username=root;password=");
        MySqlCommand cmd;

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

        private void signInBtn_Click(object sender, EventArgs e)
        {
            int serverPort = int.Parse(txtServerPort.Text);
            int clientPort = int.Parse(txtClientPort.Text);
            string hostName = txtHostname.Text;

            try
            {
                if (txtEmailSI.Text == "" || txtPassSI.Text == "")
                {
                    MessageBox.Show("Enter email and password");
                }
                else
                {
                    string txtEmailSi = txtEmailSI.Text;
                    string txtPassSi = txtPassSI.Text;

                    client = new UdpClient(clientPort);
                    signUpBtn.Enabled = false;
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }

            

            //portnumber.hostname.msg
            string msg = clientPort + "%" + hostName + "%" + txtEmailSI.Text + "%" + txtPassSI.Text;
            byte[] buffer = Encoding.Unicode.GetBytes(msg);

            //send
            client.Send(buffer, buffer.Length, hostName, serverPort);

            //receive
            endPoint = new IPEndPoint(IPAddress.Any, 0);
            buffer = client.Receive(ref endPoint);

            msg = Encoding.Unicode.GetString(buffer);
            WriteCol(msg);


            
        }

     

        private void signUpBtn_Click(object sender, EventArgs e)
        {
            int serverPort = int.Parse(txtServerPort.Text);
            int clientPort = int.Parse(txtClientPort.Text);
            string hostName = txtHostname.Text;

            try
            {
                if (txtNameSU.Text == "" || txtSurnameSU.Text == "" || txtEmailSU.Text == "" || txtPassSU.Text == "" 
                    || txtSalarySU.Text == "" || txtGradeSU.Text == "" || txtDeptNameSU.Text == "")
                {
                    MessageBox.Show("Enter email and password");
                }
                else
                {
                    
                    string txtNameSu = txtNameSU.Text;
                    string txtSurnameSu = txtSurnameSU.Text;
                    string txtEmailSu = txtEmailSU.Text;
                    string txtPassSu = txtPassSU.Text;
                    double txtSalarySu = double.Parse(txtSalarySU.Text);
                    string txtGradeSu = txtGradeSU.Text;
                    string txtDeptNameSu = txtDeptNameSU.Text;
                    signInBtn.Enabled = false;
                    client = new UdpClient(clientPort);



                }
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
            
            //portnumber.hostname.msg
            string msg = clientPort + "%" + hostName + "%" + txtNameSU.Text + "%" + txtSurnameSU.Text + "%" + txtEmailSU.Text + "%" + txtPassSU.Text
                + "%" + txtSalarySU.Text + "%" + txtGradeSU.Text + "%" + txtDeptNameSU.Text;
            byte[] buffer = Encoding.Unicode.GetBytes(msg);

            //send
            client.Send(buffer, buffer.Length, hostName, serverPort);

            //receive
            endPoint = new IPEndPoint(IPAddress.Any, 0);
            buffer = client.Receive(ref endPoint);

            msg = Encoding.Unicode.GetString(buffer);
            WriteCol(msg);



            //string insertQuery = "insert into emp" +
            //    "(name, surname,email,password,salary,grade) " +
            //    "values (@name, @surname, @email, @password, @salary, @grade) ";

            //connection.Open();
            //cmd = new MySqlCommand(insertQuery, connection);
            //cmd.Parameters.AddWithValue("@name",txtNameSU.Text);
            //cmd.Parameters.AddWithValue("@surname", txtSurnameSU.Text);
            //cmd.Parameters.AddWithValue("@email", txtEmailSU.Text);
            //cmd.Parameters.AddWithValue("@password", txtPassSU.Text);
            //cmd.Parameters.AddWithValue("@salary", txtSalarySU.Text);
            //cmd.Parameters.AddWithValue("@grade", txtGradeSU.Text);

            //try
            //{
            //    if (cmd.ExecuteNonQuery() == 1)
            //    {
            //        //MessageBox.Show("Data Inserted");
            //        messageClientTxt.Text = "Inserted";
            //        signInBtn.Enabled = false;
            //    }
            //    else
            //    {
            //        MessageBox.Show("Not Inserted");
            //    }
            //    connection.Close();
            //}
            //c(Exception ex)
             
            }
        

        private void WriteCol(string msg)
        {
            MethodInvoker invoker = new MethodInvoker(delegate { messageClientTxt.AppendText("Client info: " + Environment.NewLine + msg + Environment.NewLine); });
            this.BeginInvoke(invoker);
        }

        private void signOutBtn_Click(object sender, EventArgs e)
        {
            txtSurnameSU.Clear();
            txtEmailSU.Clear();
            txtNameSU.Clear();
            txtSalarySU.Clear();
            txtPassSU.Clear();
            txtGradeSU.Clear();
            txtDeptNameSU.Clear();
            messageClientTxt.Clear();
            signInBtn.Enabled = true;
        }

        private void txtClientPort_TextChanged(object sender, EventArgs e)
        {
            //Random rnd = new Random();
            //int month = rnd.Next(1201, 22000);  //int x = 5;
            //string y = month.ToString();
            //txtClientPort.Text = y;


            
            //string y = x.ToString();

        }

        private void txtDeptNameSU_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
