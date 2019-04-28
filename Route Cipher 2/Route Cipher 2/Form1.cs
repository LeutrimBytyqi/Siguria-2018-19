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

        private char [,] GjeneroMatricen(string lblPlainText, int key)
        {
            StringBuilder teksti = new StringBuilder(lblPlainText);

            //if (!((lblplaintext.length % key) == 0))
            //{
            //    do
            //    {
            //        teksti = teksti + "x";
            //        lblplaintext.length = lblplaintext.length();
            //    } while (!((msgchar % key) == 0));
            //}

            //int gjatesiaETekstit = 0;
            //for (int i = 0; i < teksti.Length; i = (i + key.Length))
            //{
            //    gjatesiaETekstit++;
            //}
            //gjatesiaETekstit = gjatesiaETekstit - 1;
            int gjatesia;
            if (teksti.Length % key != 0)
            {
                gjatesia = Convert.ToInt32((teksti.Length / key) + 1);
            }
            else
            {
                gjatesia = Convert.ToInt32(teksti.Length / key);
            }
            
            char[,] matrica = new char[gjatesia, key];

            int k = 0;
            for (int i = 0; i < gjatesia; i++)
            {
                for (int j = 0; j < key; j++)
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

        }
        private string Enkriptimi1(char[,] matrica)
        {
            StringBuilder stringu = new StringBuilder();
            
            var rows = matrica.GetLength(0);
            var cols = matrica.GetLength(1);
            int m = 0;
            for (int l = 0; l < cols; l++)
            {
                if (l % 2 == 0)
                {
                    for (int j = (rows- 1); j >= 0; j--)
                    {
                        stringu.Append(matrica[j, m]);
                    }
                    m++;
                }
                else
                {
                    for (int j = 0; j <= (rows - 1); j++)
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
            for (int l = 0; l < rows; l++)
            {
                if (l % 2 == 0)
                {
                    for (int j = (cols - 1); j >= 0; j--)
                    {
                        stringu.Append(matrica[m, j]);
                    }
                    m++;
                }
                else
                {
                    for (int j = 0; j <= (cols - 1); j++)
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
            int m = (cols - 1);
            for (int l = 0; l < cols; l++)
            {
                if (l % 2 == 0)
                {
                    for (int j = (rows - 1); j >= 0; j--)
                    {
                    
                        stringu.Append(matrica[j,m]);
                        
                    }
                    m--;

                }
                else
                {
                    for (int j = 0; j <= (rows - 1); j++)
                    {
                        stringu.Append(matrica[j,m]);
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
            char[,] matrica = GjeneroMatricen(lblPlainText.Text, int.Parse(key.Text));
            string ciphertexti = Enkriptimi1(matrica);
            CipherTXT.Text = ciphertexti;
        }

        private void btn2_CheckedChanged(object sender, EventArgs e)
        {
            char[,] matrica = GjeneroMatricen(lblPlainText.Text, int.Parse(key.Text));
            string ciphertexti = Enkriptimi2(matrica);
            CipherTXT.Text = ciphertexti;
        }

        private void btn3_CheckedChanged(object sender, EventArgs e)
        {
            char[,] matrica = GjeneroMatricen(lblPlainText.Text, int.Parse(key.Text));
            string ciphertexti = Enkriptimi3(matrica);
            CipherTXT.Text = ciphertexti;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void PlainTxt_Load(object sender, EventArgs e)
        {

        }

        private void key_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
