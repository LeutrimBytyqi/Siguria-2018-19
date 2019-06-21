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
            this.txtNameSU = new System.Windows.Forms.TextBox();
            this.txtSurnameSU = new System.Windows.Forms.TextBox();
            this.txtEmailSU = new System.Windows.Forms.TextBox();
            this.txtPassSU = new System.Windows.Forms.TextBox();
            this.txtEmailSI = new System.Windows.Forms.TextBox();
            this.txtPassSI = new System.Windows.Forms.TextBox();
            this.txtServerPort = new System.Windows.Forms.TextBox();
            this.portServerCLbl = new System.Windows.Forms.Label();
            this.txtMsg = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.txtHostname = new System.Windows.Forms.TextBox();
            this.txtSalarySU = new System.Windows.Forms.TextBox();
            this.txtGradeSU = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.signOutBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(815, 75);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(111, 22);
            this.btnSend.TabIndex = 0;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // signUpBtn
            // 
            this.signUpBtn.Location = new System.Drawing.Point(135, 416);
            this.signUpBtn.Name = "signUpBtn";
            this.signUpBtn.Size = new System.Drawing.Size(93, 33);
            this.signUpBtn.TabIndex = 1;
            this.signUpBtn.Text = "Sign Up";
            this.signUpBtn.UseVisualStyleBackColor = true;
            this.signUpBtn.Click += new System.EventHandler(this.signUpBtn_Click);
            // 
            // signInBtn
            // 
            this.signInBtn.Location = new System.Drawing.Point(499, 333);
            this.signInBtn.Name = "signInBtn";
            this.signInBtn.Size = new System.Drawing.Size(91, 38);
            this.signInBtn.TabIndex = 2;
            this.signInBtn.Text = "Sign In";
            this.signInBtn.UseVisualStyleBackColor = true;
            this.signInBtn.Click += new System.EventHandler(this.signInBtn_Click);
            // 
            // hostClientLbl
            // 
            this.hostClientLbl.AutoSize = true;
            this.hostClientLbl.Location = new System.Drawing.Point(35, 20);
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
            // txtClientPort
            // 
            this.txtClientPort.Location = new System.Drawing.Point(440, 26);
            this.txtClientPort.Name = "txtClientPort";
            this.txtClientPort.Size = new System.Drawing.Size(194, 22);
            this.txtClientPort.TabIndex = 6;
            this.txtClientPort.Text = "11000";
            this.txtClientPort.TextChanged += new System.EventHandler(this.txtClientPort_TextChanged);
            // 
            // messageClientTxt
            // 
            this.messageClientTxt.Location = new System.Drawing.Point(783, 195);
            this.messageClientTxt.Multiline = true;
            this.messageClientTxt.Name = "messageClientTxt";
            this.messageClientTxt.Size = new System.Drawing.Size(194, 230);
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
            this.nameLbl.Location = new System.Drawing.Point(4, 195);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(53, 17);
            this.nameLbl.TabIndex = 10;
            this.nameLbl.Text = "Name :";
            // 
            // surnameLbl
            // 
            this.surnameLbl.AutoSize = true;
            this.surnameLbl.Location = new System.Drawing.Point(1, 233);
            this.surnameLbl.Name = "surnameLbl";
            this.surnameLbl.Size = new System.Drawing.Size(73, 17);
            this.surnameLbl.TabIndex = 11;
            this.surnameLbl.Text = "Surname :";
            // 
            // emLbl
            // 
            this.emLbl.AutoSize = true;
            this.emLbl.Location = new System.Drawing.Point(4, 268);
            this.emLbl.Name = "emLbl";
            this.emLbl.Size = new System.Drawing.Size(50, 17);
            this.emLbl.TabIndex = 12;
            this.emLbl.Text = "Email :";
            // 
            // pasLbl
            // 
            this.pasLbl.AutoSize = true;
            this.pasLbl.Location = new System.Drawing.Point(1, 301);
            this.pasLbl.Name = "pasLbl";
            this.pasLbl.Size = new System.Drawing.Size(77, 17);
            this.pasLbl.TabIndex = 13;
            this.pasLbl.Text = "Password :";
            // 
            // emailLbl
            // 
            this.emailLbl.AutoSize = true;
            this.emailLbl.Location = new System.Drawing.Point(385, 201);
            this.emailLbl.Name = "emailLbl";
            this.emailLbl.Size = new System.Drawing.Size(50, 17);
            this.emailLbl.TabIndex = 14;
            this.emailLbl.Text = "Email :";
            // 
            // passwordLbl
            // 
            this.passwordLbl.AutoSize = true;
            this.passwordLbl.Location = new System.Drawing.Point(377, 286);
            this.passwordLbl.Name = "passwordLbl";
            this.passwordLbl.Size = new System.Drawing.Size(77, 17);
            this.passwordLbl.TabIndex = 15;
            this.passwordLbl.Text = "Password :";
            // 
            // txtNameSU
            // 
            this.txtNameSU.Location = new System.Drawing.Point(94, 192);
            this.txtNameSU.Name = "txtNameSU";
            this.txtNameSU.Size = new System.Drawing.Size(173, 22);
            this.txtNameSU.TabIndex = 16;
            // 
            // txtSurnameSU
            // 
            this.txtSurnameSU.Location = new System.Drawing.Point(94, 233);
            this.txtSurnameSU.Name = "txtSurnameSU";
            this.txtSurnameSU.Size = new System.Drawing.Size(173, 22);
            this.txtSurnameSU.TabIndex = 17;
            // 
            // txtEmailSU
            // 
            this.txtEmailSU.Location = new System.Drawing.Point(94, 268);
            this.txtEmailSU.Name = "txtEmailSU";
            this.txtEmailSU.Size = new System.Drawing.Size(173, 22);
            this.txtEmailSU.TabIndex = 18;
            // 
            // txtPassSU
            // 
            this.txtPassSU.Location = new System.Drawing.Point(94, 301);
            this.txtPassSU.Name = "txtPassSU";
            this.txtPassSU.Size = new System.Drawing.Size(173, 22);
            this.txtPassSU.TabIndex = 19;
            // 
            // txtEmailSI
            // 
            this.txtEmailSI.Location = new System.Drawing.Point(460, 201);
            this.txtEmailSI.Name = "txtEmailSI";
            this.txtEmailSI.Size = new System.Drawing.Size(174, 22);
            this.txtEmailSI.TabIndex = 20;
            // 
            // txtPassSI
            // 
            this.txtPassSI.Location = new System.Drawing.Point(460, 283);
            this.txtPassSI.Name = "txtPassSI";
            this.txtPassSI.Size = new System.Drawing.Size(174, 22);
            this.txtPassSI.TabIndex = 21;
            // 
            // txtServerPort
            // 
            this.txtServerPort.Location = new System.Drawing.Point(783, 23);
            this.txtServerPort.Name = "txtServerPort";
            this.txtServerPort.Size = new System.Drawing.Size(194, 22);
            this.txtServerPort.TabIndex = 22;
            this.txtServerPort.Text = "12000";
            // 
            // portServerCLbl
            // 
            this.portServerCLbl.AutoSize = true;
            this.portServerCLbl.Location = new System.Drawing.Point(697, 26);
            this.portServerCLbl.Name = "portServerCLbl";
            this.portServerCLbl.Size = new System.Drawing.Size(80, 17);
            this.portServerCLbl.TabIndex = 23;
            this.portServerCLbl.Text = "Server Port";
            // 
            // txtMsg
            // 
            this.txtMsg.Location = new System.Drawing.Point(127, 77);
            this.txtMsg.Name = "txtMsg";
            this.txtMsg.Size = new System.Drawing.Size(126, 22);
            this.txtMsg.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 25;
            this.label1.Text = "Kerkesa:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Location = new System.Drawing.Point(362, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 26;
            this.label2.Text = "Rezultati:";
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(440, 75);
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(179, 22);
            this.txtLog.TabIndex = 27;
            // 
            // txtHostname
            // 
            this.txtHostname.Enabled = false;
            this.txtHostname.Location = new System.Drawing.Point(94, 20);
            this.txtHostname.Name = "txtHostname";
            this.txtHostname.Size = new System.Drawing.Size(187, 22);
            this.txtHostname.TabIndex = 28;
            this.txtHostname.Text = "localhost";
            // 
            // txtSalarySU
            // 
            this.txtSalarySU.Location = new System.Drawing.Point(94, 339);
            this.txtSalarySU.Name = "txtSalarySU";
            this.txtSalarySU.Size = new System.Drawing.Size(173, 22);
            this.txtSalarySU.TabIndex = 29;
            // 
            // txtGradeSU
            // 
            this.txtGradeSU.Location = new System.Drawing.Point(94, 379);
            this.txtGradeSU.Name = "txtGradeSU";
            this.txtGradeSU.Size = new System.Drawing.Size(173, 22);
            this.txtGradeSU.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 344);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 31;
            this.label3.Text = "Salary";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 383);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 17);
            this.label4.TabIndex = 32;
            this.label4.Text = "Grade";
            // 
            // signOutBtn
            // 
            this.signOutBtn.Location = new System.Drawing.Point(499, 389);
            this.signOutBtn.Name = "signOutBtn";
            this.signOutBtn.Size = new System.Drawing.Size(91, 36);
            this.signOutBtn.TabIndex = 33;
            this.signOutBtn.Text = "Sign Out";
            this.signOutBtn.UseVisualStyleBackColor = true;
            this.signOutBtn.Click += new System.EventHandler(this.signOutBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(794, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 17);
            this.label5.TabIndex = 40;
            this.label5.Text = "Users Info";
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 487);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.signOutBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtGradeSU);
            this.Controls.Add(this.txtSalarySU);
            this.Controls.Add(this.txtHostname);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMsg);
            this.Controls.Add(this.portServerCLbl);
            this.Controls.Add(this.txtServerPort);
            this.Controls.Add(this.txtPassSI);
            this.Controls.Add(this.txtEmailSI);
            this.Controls.Add(this.txtPassSU);
            this.Controls.Add(this.txtEmailSU);
            this.Controls.Add(this.txtSurnameSU);
            this.Controls.Add(this.txtNameSU);
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
        private System.Windows.Forms.TextBox txtNameSU;
        private System.Windows.Forms.TextBox txtSurnameSU;
        private System.Windows.Forms.TextBox txtEmailSU;
        private System.Windows.Forms.TextBox txtPassSU;
        private System.Windows.Forms.TextBox txtEmailSI;
        private System.Windows.Forms.TextBox txtPassSI;
        private System.Windows.Forms.TextBox txtServerPort;
        private System.Windows.Forms.Label portServerCLbl;
        private System.Windows.Forms.TextBox txtMsg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.TextBox txtHostname;
        private System.Windows.Forms.TextBox txtSalarySU;
        private System.Windows.Forms.TextBox txtGradeSU;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button signOutBtn;
        private System.Windows.Forms.Label label5;
    }
}