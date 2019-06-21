using MySql.Data.MySqlClient;
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


            //cmd = new MySqlCommand("select * from emp where email = @email and password = @password", connection);
            //cmd.Parameters.AddWithValue("@email", txtEmailSI.Text);
            //cmd.Parameters.AddWithValue("@password", txtPassSI.Text);
            //connection.Open();
            //MySqlDataAdapter dataAdapter = new MySqlDataAdapter(cmd);
            //DataSet dataSet = new DataSet();
            //dataAdapter.Fill(dataSet);
            //connection.Close();
            //int count = dataSet.Tables[0].Rows.Count;
            //if (count == 1)
            //{
            //    MessageBox.Show("Successfully login");



            //ME U SHFAQ TE DHENAT SIPAS QATIJ EMAILI QE JEM LLOGIRAT PASI QE OSHT UNIQUE
            //GABIM DIQKA!!
            //try
            //{
            //    MySqlDataReader myReader = null;
            //    cmd = new MySqlCommand("select * from emp where email = @email", connection);
            //    cmd.Parameters.AddWithValue("@email", txtEmailSI.Text);
            //    myReader = cmd.ExecuteReader();
            //    if (myReader.HasRows)
            //    {
            //        while (myReader.Read())
            //        {
            //            txtNameInfo.Text = myReader.GetValue(1).ToString();
            //            txtSurnameInfo.Text = myReader.GetValue(2).ToString();
            //            txtEmailInfo.Text = myReader.GetValue(3).ToString();
            //            txtPassInfo.Text = myReader.GetValue(4).ToString();
            //            txtSalaryInfo.Text = myReader.GetInt32(5).ToString();
            //            //txtSalarySU.Text = myReader.GetValue(4).ToString();
            //            txtGradeInfo.Text = myReader.GetValue(6).ToString();
            //        }
            //        cmd.Dispose();

            //    }
            //}
            //catch (Exception ex1)
            //{
            //    MessageBox.Show(ex1.Message);
            //}

            //}
            //    else
            //    {
            //        MessageBox.Show("Failed login");
            //    }

            //}

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
            //connection.Close();
        }
      
        private void signUpBtn_Click(object sender, EventArgs e)
        {
            int serverPort = int.Parse(txtServerPort.Text);
            int clientPort = int.Parse(txtClientPort.Text);
            string hostName = txtHostname.Text;

            try
            {
                if (txtNameSU.Text == "" || txtSurnameSU.Text == "" || txtEmailSU.Text == "" || txtPassSU.Text == "" 
                    || txtSalarySU.Text == "" || txtGradeSU.Text == "")
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

                    client = new UdpClient(clientPort);
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
            
            //portnumber.hostname.msg
            string msg = clientPort + "%" + hostName + "%" + txtNameSU.Text + "%" + txtSurnameSU.Text + "%" + txtEmailSU.Text + "%" + txtPassSU.Text
                + "%" + txtSalarySU.Text + "%" + txtGradeSU.Text;
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
            //catch(Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void WriteCol(string msg)
        {
            MethodInvoker invoker = new MethodInvoker(delegate { messageClientTxt.AppendText("Client info: " + Environment.NewLine + msg + Environment.NewLine); });
            this.BeginInvoke(invoker);
        }

        private void signOutBtn_Click(object sender, EventArgs e)
        {
            //txtSurnameInfo.Clear();
            //txtEmailInfo.Clear();
            //txtNameInfo.Clear();
            //txtSalaryInfo.Clear();
            //txtPassInfo.Clear();
            //txtGradeInfo.Clear();               
        }
    }
}
