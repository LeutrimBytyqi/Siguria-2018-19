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
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SiguriV1._1
{
    public partial class Server : Form
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost;database=employees;" + "port=3306;username=root;password=");
        MySqlCommand cmd;

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
            Thread thr = new Thread(new ThreadStart(ServerStart));
            thr.Start();

            btnStart.Enabled = false;

        }

        private void ServerStart()
        {
            while (true)
            {
                //reveice
                byte[] buffer = server.Receive(ref endPoint);
                //portnumber.hostname.msg
                string[] msg = Encoding.Unicode.GetString(buffer).Split('%');
                StringBuilder palidhje = new StringBuilder();

                if (msg.Length == 9)
                {

                    connection.Open();
                    WriteLog(" Name :" + msg[2]);
                    WriteLog(" Surname :" + msg[3]);
                    WriteLog(" Email :" + msg[4]);
                    WriteLog(" Password :" + msg[5]);
                    WriteLog(" Salary :" + msg[6]);
                    WriteLog(" Grade :" + msg[7]);
                    WriteLog(" DeptName:" + msg[8]);
                    string insertQuery = "insert into emp" +
                        "(name, surname, email, password, salary, grade, deptName) " +
                        "values (@name, @surname, @email, @password, @salary, @grade, @deptName) ";

                    cmd = new MySqlCommand(insertQuery, connection);
                    cmd.Parameters.AddWithValue("@name", msg[2]);
                    cmd.Parameters.AddWithValue("@surname", msg[3]);
                    cmd.Parameters.AddWithValue("@email", msg[4]);
                    cmd.Parameters.AddWithValue("@password", msg[5]);
                    cmd.Parameters.AddWithValue("@salary", msg[6]);
                    cmd.Parameters.AddWithValue("@grade", msg[7]);
                    cmd.Parameters.AddWithValue("@deptName", msg[8]);

                    for (int i = 2; i < msg.Length; i++)
                    {
                        palidhje.Append(msg[i] + Environment.NewLine);
                    }

                    try
                    {
                        if (cmd.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show("Data Inserted");
                            //messageClientTxt.Text = "Inserted";
                            //signInBtn.Enabled = false;
                        }
                        else
                        {
                            MessageBox.Show("Not Inserted");
                        }
                        connection.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    buffer = Encoding.Unicode.GetBytes(palidhje.ToString());
                    server.Send(buffer, buffer.Length, msg[1], int.Parse(msg[0]));
                    connection.Close();
                }

                else if (msg.Length == 4)
                {
                    connection.Open();
                    cmd = new MySqlCommand("select * from emp where email = @email and password = @password", connection);
                    cmd.Parameters.AddWithValue("@email", msg[2]);
                    cmd.Parameters.AddWithValue("@password", msg[3]);
                   
                    MySqlDataAdapter dataAdapter = new MySqlDataAdapter(cmd);
                    DataSet dataSet = new DataSet();
                    dataAdapter.Fill(dataSet);
                   // connection.Close();
                    string[] mes = new string[9];
                    mes[0] = msg[0];
                    mes[1] = msg[1];
                    
                    int count = dataSet.Tables[0].Rows.Count;
                    if (count == 1)
                    {
                        MessageBox.Show("Successfully login");


                        try
                        {
                            MySqlDataReader myReader = null;
                            cmd = new MySqlCommand("select * from emp where email = @email", connection);
                            cmd.Parameters.AddWithValue("@email", msg[2]);
                            myReader = cmd.ExecuteReader();

                            if (myReader.HasRows)
                            {
                                while (myReader.Read())
                                {
                                    mes[2] = myReader.GetValue(1).ToString();
                                    mes[3] = myReader.GetValue(2).ToString();
                                    mes[4] = myReader.GetValue(3).ToString();
                                    mes[5] = myReader.GetValue(4).ToString();
                                    mes[6] = myReader.GetInt32(5).ToString();
                                    mes[7] = myReader.GetValue(6).ToString();
                                    mes[8] = myReader.GetValue(7).ToString();
                                }
                                cmd.Dispose();

                            }
                            for (int i = 2; i < mes.Length; i++)
                            {
                                palidhje.Append(mes[i] + Environment.NewLine);
                            }

                            buffer = Encoding.Unicode.GetBytes(palidhje.ToString());
                            server.Send(buffer, buffer.Length, mes[1], int.Parse(mes[0]));
                        }
                        catch (Exception ex1)
                        {
                            MessageBox.Show(ex1.Message);
                        }

                    }
                    else
                    {
                        MessageBox.Show("Failed login");
                    }
 
                    connection.Close();
                }



                else
                {
                    WriteLog("Client at Port :" + msg[0]);
                    WriteLog(" at Host :" + msg[1]);
                    WriteLog(" need :" + msg[2]);

                    //Send
                    buffer = Encoding.Unicode.GetBytes(DateTime.Now.ToString());
                    server.Send(buffer, buffer.Length, msg[1], int.Parse(msg[0]));

                }

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
