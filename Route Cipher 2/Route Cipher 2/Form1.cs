using System;
using System.Text;
using System.Windows.Forms;

namespace Route_Cipher_2
{
    public partial class PlainTxt : Form
    {
        public PlainTxt()
        {
            InitializeComponent();
        }

        public int btn;


        private char [,] GjeneroMatricen(string lblPlainText, int key)
        {
            lblPlainText = lblPlainText.Replace(" ", "");
            StringBuilder teksti = new StringBuilder(lblPlainText);
            
            int gjatesia;
            if (teksti.Length % key != 0)
            {
                gjatesia = Convert.ToInt32((teksti.Length / key) + 1);   //numrat qe dalin me presje e merr numrin e plote dhe ja shton +1
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
        private string Enkriptimi1(char[,] matrica)          //prej posht majtas--lart djathtas  
        {
            btn = 1;
            StringBuilder stringu = new StringBuilder();
            
            var rows = matrica.GetLength(0);
            var cols = matrica.GetLength(1);

            for (int l = 0; l < cols; l++) //l mirret si kolona 
            {
                if (l % 2 == 0)
                {
                    for (int j = (rows- 1); j >= 0; j--)//j mirret si rreshta
                    {
                        stringu.Append(matrica[j, l]); 
                    }
                }
                else
                {
                    for (int j = 0; j <= (rows - 1); j++)
                    {
                        stringu.Append(matrica[j, l]);
                    }
                }
            }
            return stringu.ToString();
        }

        private string Enkriptimi2(char[,] matrica) //prej djathtas nalt<-majtas posht
        {
            btn = 2;
            StringBuilder stringu = new StringBuilder();
            var rows = matrica.GetLength(0);
            var cols = matrica.GetLength(1);
            
            for (int l = 0; l < rows; l++)   //l mirret si rreshta
            {
                if (l % 2 == 0)                          
                {
                    for (int j = (cols - 1); j >= 0; j--) //j mirret kolona
                    {
                        stringu.Append(matrica[l, j]);
                    }
                    
                }
                else
                {
                    for (int j = 0; j <= (cols - 1); j++)
                    {
                        stringu.Append(matrica[l, j]);
                    }
                    
                }
            }
            return stringu.ToString();
        }

        private string Enkriptimi3(char[,] matrica)
        {
            btn = 3;
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

        private char[,] Dekriptimi(string stringu, int key)
        {
            var gjatesia = Convert.ToInt32(stringu.Length / key);
            char[,] matdek = new char[gjatesia, key];
            if (btn == 1)
            {
                int m = 0;
                for (int l = 0; l < key; l++)//kolone l
                {
                    if (l % 2 == 0)
                    {
                        for (int j = (gjatesia - 1); j >= 0; j--) //rresht j
                        {
                            matdek[j, l] = stringu[m++];
                        }
                    }
                    else
                    {
                        for (int j = 0; j <= (gjatesia - 1); j++)
                        {
                            matdek[j, l] = stringu[m];
                            m++;
                        }
                    }
                }
                return matdek;
            }
            else if (btn == 2)
            {
                int k = 0, m = 0;
                for (int l = 0; l < gjatesia; l++)
                {
                    if (l % 2 == 0)
                    {
                        for (int j = (key - 1); j >= 0; j--)
                        {
                            matdek[k, j] = stringu[m++];
                        }
                        k++;
                    }
                    else
                    {
                        for (int j = 0; j <= (key - 1); j++)
                        {
                            matdek[k, j] = stringu[m++];
                        }
                        k++;
                    }
                }
                return matdek;
            }
            else  //metoda 3
            {
                int k = (key - 1), m = 0;
                for (int l = 0; l < key; l++)
                {
                    if (l % 2 == 0)
                    {
                        for (int j = (gjatesia - 1); j >= 0; j--)
                        {
                            matdek[j, k] = stringu[m++];
                        }
                        k--;
                    }
                    else
                    {
                        for (int j = 0; j <= (gjatesia - 1); j++)
                        {
                            matdek[j, k] = stringu[m++];
                        }
                        k--;
                    }
                }
                return matdek;
            }
            
        }

        private string gjenerodek(char[,] matdek)
        {
            StringBuilder decriphted = new StringBuilder();
            var rows = matdek.GetLength(0);
            var cols = matdek.GetLength(1);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    decriphted.Append(matdek[i, j]);
                }
            }
            return decriphted.ToString();
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            char[,] dekriptimi = Dekriptimi(CipherTXT.Text, int.Parse(key.Text));
            string tekstidekriptuar = gjenerodek(dekriptimi);
            Decryption.Text = tekstidekriptuar;
        }
        
            
        private void btn1_CheckedChanged(object sender, EventArgs e)
        {
            char[,] matrica = GjeneroMatricen(lblPlainText.Text, int.Parse(key.Text));
            string ciphertexti = Enkriptimi1(matrica);
            CipherTXT.Text = ciphertexti;
            if (btn1.Enabled)
            {
                btn2.Enabled = false;
                btn3.Enabled = false;
            }
    
        }

        private void btn2_CheckedChanged(object sender, EventArgs e)
        {
            char[,] matrica = GjeneroMatricen(lblPlainText.Text, int.Parse(key.Text));
            string ciphertexti = Enkriptimi2(matrica);
            CipherTXT.Text = ciphertexti;
            if (btn2.Enabled)
            {
                btn1.Enabled = false;
                btn3.Enabled = false;
            }
        }

        private void btn3_CheckedChanged(object sender, EventArgs e)
        {
            char[,] matrica = GjeneroMatricen(lblPlainText.Text, int.Parse(key.Text));
            string ciphertexti = Enkriptimi3(matrica);
            CipherTXT.Text = ciphertexti;
            if (btn3.Enabled)
            {
                btn2.Enabled = false;
                btn1.Enabled = false;
            }
        }


        private void btnEkripto_Click(object sender, EventArgs e)
        {

        }
        private void Decryption_TextChanged(object sender, EventArgs e)
        {

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
        private void lblPlainText_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
