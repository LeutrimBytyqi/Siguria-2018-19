using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Route_Cipher_2
{
    public partial class PlainTxt : Form
    {
        public PlainTxt()
        {
            InitializeComponent();
        }

        private void lblPlainText_TextChanged(object sender, EventArgs e)
        {

        }

        private char [,] GjeneroMatricen(string lblPlainText)
        {
            char[,] matrica = new char[5, 5];
            StringBuilder teksti = new StringBuilder(lblPlainText);
            
            int k = 0;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (k < lblPlainText.Length)
                    {
                        matrica[i, j] = teksti[k++];
                    }
                    else
                    {
                        matrica[i, j] = 'X';
                    }
                }
            }

            
            return matrica;

            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < cols; j++)
            //    {
            //        stringu.Append(matrica[j, i]);
            //    }
            //}


            
            
        }
        private string Enkriptimi1(char[,] matrica)
        {
            StringBuilder stringu = new StringBuilder();
            var rows = matrica.GetLength(0);
            var cols = matrica.GetLength(1);
            int m = 0;
            for (int l = 2; l < (rows + 2); l++)
            {
                if (l % 2 == 0)
                {
                    for (int j = 4; j >= 0; j--)
                    {
                        stringu.Append(matrica[j, m]);
                    }
                    m++;
                }
                else
                {
                    for (int j = 0; j <= 4; j++)
                    {
                        stringu.Append(matrica[j, m]);
                    }
                    m++;
                }
            }
            return stringu.ToString();
        }

        private string Enkriptimi2(char[,] matrica)
        {
            StringBuilder stringu = new StringBuilder();
            var rows = matrica.GetLength(0);
            var cols = matrica.GetLength(1);
            int m = 0;
            for (int l = 2; l < (rows + 2); l++)
            {
                if (l % 2 == 0)
                {
                    for (int j = 4; j >= 0; j--)
                    {
                        stringu.Append(matrica[m, j]);
                    }
                    m++;
                }
                else
                {
                    for (int j = 0; j <= 4; j++)
                    {
                        stringu.Append(matrica[m, j]);
                    }
                    m++;
                }
            }
            return stringu.ToString();
        }

        private string Enkriptimi3(char[,] matrica)
        {
            StringBuilder stringu = new StringBuilder();
            var rows = matrica.GetLength(0);
            var cols = matrica.GetLength(1);
            int m = 4;
            for (int l = 2; l < (rows + 2); l++)
            {
                if (l % 2 == 0)
                {
                    for (int j = 4; j >= 0; j--)
                    {
                        stringu.Append(matrica[j, m]);
                    }
                    m--;
                }
                else
                {
                    for (int j = 0; j <= 4; j++)
                    {
                        stringu.Append(matrica[j, m]);
                    }
                    m--;
                }
            }
            return stringu.ToString();
        }

        private void btnEkripto_Click(object sender, EventArgs e)
        {
            
        }

        private void btn1_CheckedChanged(object sender, EventArgs e)
        {
            char[,] matrica = GjeneroMatricen(lblPlainText.Text);
            string ciphertexti = Enkriptimi1(matrica);
            CipherTXT.Text = ciphertexti;
        }

        private void btn2_CheckedChanged(object sender, EventArgs e)
        {
            char[,] matrica = GjeneroMatricen(lblPlainText.Text);
            string ciphertexti = Enkriptimi2(matrica);
            CipherTXT.Text = ciphertexti;
        }

        private void btn3_CheckedChanged(object sender, EventArgs e)
        {
            char[,] matrica = GjeneroMatricen(lblPlainText.Text);
            string ciphertexti = Enkriptimi3(matrica);
            CipherTXT.Text = ciphertexti;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void PlainTxt_Load(object sender, EventArgs e)
        {

        }
    }
}
