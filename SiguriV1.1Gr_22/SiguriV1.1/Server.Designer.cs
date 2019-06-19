namespace SiguriV1._1
{
    partial class Server
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
            this.messageServerTxt = new System.Windows.Forms.TextBox();
            this.hostServerTxt = new System.Windows.Forms.TextBox();
            this.txtServerPort = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.newClientBtn = new System.Windows.Forms.Button();
            this.hostLblServer = new System.Windows.Forms.Label();
            this.portLblServer = new System.Windows.Forms.Label();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // messageServerTxt
            // 
            this.messageServerTxt.Location = new System.Drawing.Point(24, 109);
            this.messageServerTxt.Multiline = true;
            this.messageServerTxt.Name = "messageServerTxt";
            this.messageServerTxt.Size = new System.Drawing.Size(764, 329);
            this.messageServerTxt.TabIndex = 0;
            // 
            // hostServerTxt
            // 
            this.hostServerTxt.Enabled = false;
            this.hostServerTxt.Location = new System.Drawing.Point(89, 42);
            this.hostServerTxt.Name = "hostServerTxt";
            this.hostServerTxt.Size = new System.Drawing.Size(185, 22);
            this.hostServerTxt.TabIndex = 1;
            this.hostServerTxt.Text = "localhost";
            // 
            // txtServerPort
            // 
            this.txtServerPort.Enabled = false;
            this.txtServerPort.Location = new System.Drawing.Point(379, 45);
            this.txtServerPort.Name = "txtServerPort";
            this.txtServerPort.Size = new System.Drawing.Size(183, 22);
            this.txtServerPort.TabIndex = 2;
            this.txtServerPort.Text = "12000";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(597, 45);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // newClientBtn
            // 
            this.newClientBtn.Location = new System.Drawing.Point(713, 44);
            this.newClientBtn.Name = "newClientBtn";
            this.newClientBtn.Size = new System.Drawing.Size(75, 23);
            this.newClientBtn.TabIndex = 4;
            this.newClientBtn.Text = "New Client";
            this.newClientBtn.UseVisualStyleBackColor = true;
            this.newClientBtn.Click += new System.EventHandler(this.newClientBtn_Click);
            // 
            // hostLblServer
            // 
            this.hostLblServer.AutoSize = true;
            this.hostLblServer.Location = new System.Drawing.Point(21, 42);
            this.hostLblServer.Name = "hostLblServer";
            this.hostLblServer.Size = new System.Drawing.Size(37, 17);
            this.hostLblServer.TabIndex = 5;
            this.hostLblServer.Text = "Host";
            // 
            // portLblServer
            // 
            this.portLblServer.AutoSize = true;
            this.portLblServer.Location = new System.Drawing.Point(312, 45);
            this.portLblServer.Name = "portLblServer";
            this.portLblServer.Size = new System.Drawing.Size(34, 17);
            this.portLblServer.TabIndex = 6;
            this.portLblServer.Text = "Port";
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(151, 81);
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(123, 22);
            this.txtLog.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "te dhenat e klientit";
            // 
            // Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.portLblServer);
            this.Controls.Add(this.hostLblServer);
            this.Controls.Add(this.newClientBtn);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtServerPort);
            this.Controls.Add(this.hostServerTxt);
            this.Controls.Add(this.messageServerTxt);
            this.Name = "Server";
            this.Text = "Server";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox messageServerTxt;
        private System.Windows.Forms.TextBox hostServerTxt;
        private System.Windows.Forms.TextBox txtServerPort;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button newClientBtn;
        private System.Windows.Forms.Label hostLblServer;
        private System.Windows.Forms.Label portLblServer;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.Label label1;
    }
}