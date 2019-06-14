namespace Route_Cipher_2
{
    partial class PlainTxt
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PlainText = new System.Windows.Forms.Label();
            this.lblPlainText = new System.Windows.Forms.TextBox();
            this.CipherTXT = new System.Windows.Forms.TextBox();
            this.btn1 = new System.Windows.Forms.RadioButton();
            this.btn2 = new System.Windows.Forms.RadioButton();
            this.btn3 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.key = new System.Windows.Forms.TextBox();
            this.btnDekripto = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Decryption = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PlainText
            // 
            this.PlainText.AutoSize = true;
            this.PlainText.Location = new System.Drawing.Point(12, 9);
            this.PlainText.Name = "PlainText";
            this.PlainText.Size = new System.Drawing.Size(70, 17);
            this.PlainText.TabIndex = 0;
            this.PlainText.Text = "Plain Text";
            // 
            // lblPlainText
            // 
            this.lblPlainText.AccessibleName = "lblPlainText";
            this.lblPlainText.Location = new System.Drawing.Point(13, 30);
            this.lblPlainText.Name = "lblPlainText";
            this.lblPlainText.Size = new System.Drawing.Size(629, 22);
            this.lblPlainText.TabIndex = 1;
            this.lblPlainText.TextChanged += new System.EventHandler(this.lblPlainText_TextChanged);
            // 
            // CipherTXT
            // 
            this.CipherTXT.Location = new System.Drawing.Point(12, 203);
            this.CipherTXT.Name = "CipherTXT";
            this.CipherTXT.Size = new System.Drawing.Size(630, 22);
            this.CipherTXT.TabIndex = 3;
            // 
            // btn1
            // 
            this.btn1.AutoSize = true;
            this.btn1.Location = new System.Drawing.Point(12, 142);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(213, 21);
            this.btn1.TabIndex = 4;
            this.btn1.TabStop = true;
            this.btn1.Text = "Nga poshtmajtas, lartdjathtas";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.CheckedChanged += new System.EventHandler(this.btn1_CheckedChanged);
            // 
            // btn2
            // 
            this.btn2.AutoSize = true;
            this.btn2.Location = new System.Drawing.Point(226, 142);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(213, 21);
            this.btn2.TabIndex = 5;
            this.btn2.TabStop = true;
            this.btn2.Text = "Nga lartdjathtas, majtasposht";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.CheckedChanged += new System.EventHandler(this.btn2_CheckedChanged);
            // 
            // btn3
            // 
            this.btn3.AutoSize = true;
            this.btn3.Location = new System.Drawing.Point(437, 142);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(213, 21);
            this.btn3.TabIndex = 6;
            this.btn3.TabStop = true;
            this.btn3.Text = "Nga poshtdjathtas, lartmajtas";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.CheckedChanged += new System.EventHandler(this.btn3_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Cipher Text";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // key
            // 
            this.key.Location = new System.Drawing.Point(12, 92);
            this.key.Name = "key";
            this.key.Size = new System.Drawing.Size(630, 22);
            this.key.TabIndex = 8;
            this.key.TextChanged += new System.EventHandler(this.key_TextChanged);
            // 
            // btnDekripto
            // 
            this.btnDekripto.Location = new System.Drawing.Point(458, 242);
            this.btnDekripto.Name = "btnDekripto";
            this.btnDekripto.Size = new System.Drawing.Size(184, 37);
            this.btnDekripto.TabIndex = 9;
            this.btnDekripto.Text = "Dekripto";
            this.btnDekripto.UseVisualStyleBackColor = true;
            this.btnDekripto.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 291);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 274);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Decryption";
            // 
            // Decryption
            // 
            this.Decryption.Location = new System.Drawing.Point(12, 312);
            this.Decryption.Name = "Decryption";
            this.Decryption.Size = new System.Drawing.Size(630, 22);
            this.Decryption.TabIndex = 12;
            this.Decryption.TextChanged += new System.EventHandler(this.Decryption_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Key";
            // 
            // PlainTxt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 420);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Decryption);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDekripto);
            this.Controls.Add(this.key);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.CipherTXT);
            this.Controls.Add(this.lblPlainText);
            this.Controls.Add(this.PlainText);
            this.Name = "PlainTxt";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.PlainTxt_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PlainText;
        private System.Windows.Forms.TextBox lblPlainText;
        private System.Windows.Forms.TextBox CipherTXT;
        private System.Windows.Forms.RadioButton btn1;
        private System.Windows.Forms.RadioButton btn2;
        private System.Windows.Forms.RadioButton btn3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox key;
        private System.Windows.Forms.Button btnDekripto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Decryption;
        private System.Windows.Forms.Label label4;
    }
}

