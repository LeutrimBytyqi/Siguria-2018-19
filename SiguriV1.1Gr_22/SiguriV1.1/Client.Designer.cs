namespace SiguriV1._1
{
    partial class Client
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
            this.btnSend = new System.Windows.Forms.Button();
            this.signUpBtn = new System.Windows.Forms.Button();
            this.signInBtn = new System.Windows.Forms.Button();
            this.hostClientLbl = new System.Windows.Forms.Label();
            this.portLbl = new System.Windows.Forms.Label();
            this.txtHostname = new System.Windows.Forms.TextBox();
            this.txtClientPort = new System.Windows.Forms.TextBox();
            this.messageClientTxt = new System.Windows.Forms.TextBox();
            this.signUpLbl = new System.Windows.Forms.Label();
            this.signInLbl = new System.Windows.Forms.Label();
            this.nameLbl = new System.Windows.Forms.Label();
            this.surnameLbl = new System.Windows.Forms.Label();
            this.emLbl = new System.Windows.Forms.Label();
            this.pasLbl = new System.Windows.Forms.Label();
            this.emailLbl = new System.Windows.Forms.Label();
            this.passwordLbl = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.txtServerPort = new System.Windows.Forms.TextBox();
            this.portServerCLbl = new System.Windows.Forms.Label();
            this.txtMsg = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(674, 12);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(111, 51);
            this.btnSend.TabIndex = 0;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // signUpBtn
            // 
            this.signUpBtn.Location = new System.Drawing.Point(135, 416);
            this.signUpBtn.Name = "signUpBtn";
            this.signUpBtn.Size = new System.Drawing.Size(75, 23);
            this.signUpBtn.TabIndex = 1;
            this.signUpBtn.Text = "Sign Up";
            this.signUpBtn.UseVisualStyleBackColor = true;
            // 
            // signInBtn
            // 
            this.signInBtn.Location = new System.Drawing.Point(515, 339);
            this.signInBtn.Name = "signInBtn";
            this.signInBtn.Size = new System.Drawing.Size(75, 23);
            this.signInBtn.TabIndex = 2;
            this.signInBtn.Text = "Sign In";
            this.signInBtn.UseVisualStyleBackColor = true;
            // 
            // hostClientLbl
            // 
            this.hostClientLbl.AutoSize = true;
            this.hostClientLbl.Location = new System.Drawing.Point(35, 26);
            this.hostClientLbl.Name = "hostClientLbl";
            this.hostClientLbl.Size = new System.Drawing.Size(45, 17);
            this.hostClientLbl.TabIndex = 3;
            this.hostClientLbl.Text = "Host :";
            // 
            // portLbl
            // 
            this.portLbl.AutoSize = true;
            this.portLbl.Location = new System.Drawing.Point(362, 26);
            this.portLbl.Name = "portLbl";
            this.portLbl.Size = new System.Drawing.Size(73, 17);
            this.portLbl.TabIndex = 4;
            this.portLbl.Text = "Client Port";
            // 
            // txtHostname
            // 
            this.txtHostname.Location = new System.Drawing.Point(113, 26);
            this.txtHostname.Name = "txtHostname";
            this.txtHostname.Size = new System.Drawing.Size(201, 22);
            this.txtHostname.TabIndex = 5;
            this.txtHostname.TextChanged += new System.EventHandler(this.hostClientTxt_TextChanged);
            // 
            // txtClientPort
            // 
            this.txtClientPort.Location = new System.Drawing.Point(440, 26);
            this.txtClientPort.Name = "txtClientPort";
            this.txtClientPort.Size = new System.Drawing.Size(194, 22);
            this.txtClientPort.TabIndex = 6;
            this.txtClientPort.Text = "11000";
            // 
            // messageClientTxt
            // 
            this.messageClientTxt.Location = new System.Drawing.Point(708, 102);
            this.messageClientTxt.Multiline = true;
            this.messageClientTxt.Name = "messageClientTxt";
            this.messageClientTxt.Size = new System.Drawing.Size(297, 311);
            this.messageClientTxt.TabIndex = 7;
            // 
            // signUpLbl
            // 
            this.signUpLbl.AutoSize = true;
            this.signUpLbl.Location = new System.Drawing.Point(35, 161);
            this.signUpLbl.Name = "signUpLbl";
            this.signUpLbl.Size = new System.Drawing.Size(240, 17);
            this.signUpLbl.TabIndex = 8;
            this.signUpLbl.Text = "Sign Up if you don\'t have an account";
            // 
            // signInLbl
            // 
            this.signInLbl.AutoSize = true;
            this.signInLbl.Location = new System.Drawing.Point(385, 161);
            this.signInLbl.Name = "signInLbl";
            this.signInLbl.Size = new System.Drawing.Size(249, 17);
            this.signInLbl.TabIndex = 9;
            this.signInLbl.Text = "Sign In if you already have an account";
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Location = new System.Drawing.Point(4, 201);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(53, 17);
            this.nameLbl.TabIndex = 10;
            this.nameLbl.Text = "Name :";
            // 
            // surnameLbl
            // 
            this.surnameLbl.AutoSize = true;
            this.surnameLbl.Location = new System.Drawing.Point(4, 261);
            this.surnameLbl.Name = "surnameLbl";
            this.surnameLbl.Size = new System.Drawing.Size(73, 17);
            this.surnameLbl.TabIndex = 11;
            this.surnameLbl.Text = "Surname :";
            // 
            // emLbl
            // 
            this.emLbl.AutoSize = true;
            this.emLbl.Location = new System.Drawing.Point(4, 313);
            this.emLbl.Name = "emLbl";
            this.emLbl.Size = new System.Drawing.Size(50, 17);
            this.emLbl.TabIndex = 12;
            this.emLbl.Text = "Email :";
            // 
            // pasLbl
            // 
            this.pasLbl.AutoSize = true;
            this.pasLbl.Location = new System.Drawing.Point(4, 366);
            this.pasLbl.Name = "pasLbl";
            this.pasLbl.Size = new System.Drawing.Size(77, 17);
            this.pasLbl.TabIndex = 13;
            this.pasLbl.Text = "Password :";
            // 
            // emailLbl
            // 
            this.emailLbl.AutoSize = true;
            this.emailLbl.Location = new System.Drawing.Point(368, 195);
            this.emailLbl.Name = "emailLbl";
            this.emailLbl.Size = new System.Drawing.Size(50, 17);
            this.emailLbl.TabIndex = 14;
            this.emailLbl.Text = "Email :";
            // 
            // passwordLbl
            // 
            this.passwordLbl.AutoSize = true;
            this.passwordLbl.Location = new System.Drawing.Point(368, 286);
            this.passwordLbl.Name = "passwordLbl";
            this.passwordLbl.Size = new System.Drawing.Size(77, 17);
            this.passwordLbl.TabIndex = 15;
            this.passwordLbl.Text = "Password :";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(94, 195);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(173, 22);
            this.textBox3.TabIndex = 16;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(94, 256);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(173, 22);
            this.textBox4.TabIndex = 17;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(94, 308);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(173, 22);
            this.textBox5.TabIndex = 18;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(94, 366);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(173, 22);
            this.textBox6.TabIndex = 19;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(460, 201);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(174, 22);
            this.textBox7.TabIndex = 20;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(460, 283);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(174, 22);
            this.textBox8.TabIndex = 21;
            // 
            // txtServerPort
            // 
            this.txtServerPort.Location = new System.Drawing.Point(440, 74);
            this.txtServerPort.Name = "txtServerPort";
            this.txtServerPort.Size = new System.Drawing.Size(194, 22);
            this.txtServerPort.TabIndex = 22;
            this.txtServerPort.Text = "12000";
            // 
            // portServerCLbl
            // 
            this.portServerCLbl.AutoSize = true;
            this.portServerCLbl.Location = new System.Drawing.Point(364, 74);
            this.portServerCLbl.Name = "portServerCLbl";
            this.portServerCLbl.Size = new System.Drawing.Size(80, 17);
            this.portServerCLbl.TabIndex = 23;
            this.portServerCLbl.Text = "Server Port";
            // 
            // txtMsg
            // 
            this.txtMsg.Location = new System.Drawing.Point(12, 94);
            this.txtMsg.Name = "txtMsg";
            this.txtMsg.Size = new System.Drawing.Size(93, 22);
            this.txtMsg.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 25;
            this.label1.Text = "kerkesa:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(147, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 26;
            this.label2.Text = "Rezultati";
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(135, 93);
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(100, 22);
            this.txtLog.TabIndex = 27;
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 487);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMsg);
            this.Controls.Add(this.portServerCLbl);
            this.Controls.Add(this.txtServerPort);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.passwordLbl);
            this.Controls.Add(this.emailLbl);
            this.Controls.Add(this.pasLbl);
            this.Controls.Add(this.emLbl);
            this.Controls.Add(this.surnameLbl);
            this.Controls.Add(this.nameLbl);
            this.Controls.Add(this.signInLbl);
            this.Controls.Add(this.signUpLbl);
            this.Controls.Add(this.messageClientTxt);
            this.Controls.Add(this.txtClientPort);
            this.Controls.Add(this.txtHostname);
            this.Controls.Add(this.portLbl);
            this.Controls.Add(this.hostClientLbl);
            this.Controls.Add(this.signInBtn);
            this.Controls.Add(this.signUpBtn);
            this.Controls.Add(this.btnSend);
            this.Name = "Client";
            this.Text = "Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button signUpBtn;
        private System.Windows.Forms.Button signInBtn;
        private System.Windows.Forms.Label hostClientLbl;
        private System.Windows.Forms.Label portLbl;
        private System.Windows.Forms.TextBox txtHostname;
        private System.Windows.Forms.TextBox txtClientPort;
        private System.Windows.Forms.TextBox messageClientTxt;
        private System.Windows.Forms.Label signUpLbl;
        private System.Windows.Forms.Label signInLbl;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.Label surnameLbl;
        private System.Windows.Forms.Label emLbl;
        private System.Windows.Forms.Label pasLbl;
        private System.Windows.Forms.Label emailLbl;
        private System.Windows.Forms.Label passwordLbl;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox txtServerPort;
        private System.Windows.Forms.Label portServerCLbl;
        private System.Windows.Forms.TextBox txtMsg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLog;
    }
}