using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            runQuery();
        }

        private void runQuery()
        {
            string query = textBox1.Text;

            if (query == "")
            {
                MessageBox.Show("Please insert some query");
                return;
            }

            string MySQLConnectionString = "datasource=125.564.12.1;port=3306;username=root;password=;database=Employees";

            MySqlConnection databaseConnection = new MySqlConnection(MySQLConnectionString);

            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;

            try
            {
                databaseConnection.Open();

                MySqlDataReader myReader = commandDatabase.ExecuteReader();

                if (myReader.HasRows)
                {
                    MessageBox.Show("Your query generated results, please see the console");
                    while (myReader.Read())
                    {                       //ID                                firstName                       surname                               email                           password                          salary                          grade
                        Console.WriteLine(myReader.GetString(0) + "  -  " + myReader.GetString(1) + "  -  " + myReader.GetString(2) + "  -  " + myReader.GetString(3) + "  -  " + myReader.GetString(4) + "  -  " + myReader.GetString(5) + "  -  " + myReader.GetString(6));
                    }
                }
                else
                {
                    MessageBox.Show("Query excecuted");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Faild " + e.Message);
            }
        }
    }
}