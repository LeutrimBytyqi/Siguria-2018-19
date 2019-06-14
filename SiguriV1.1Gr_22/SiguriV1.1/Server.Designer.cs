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
            this.portServerTxt = new System.Windows.Forms.TextBox();
            this.startBtn = new System.Windows.Forms.Button();
            this.stopBtn = new System.Windows.Forms.Button();
            this.hostLblServer = new System.Windows.Forms.Label();
            this.portLblServer = new System.Windows.Forms.Label();
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
            this.hostServerTxt.Location = new System.Drawing.Point(89, 42);
            this.hostServerTxt.Name = "hostServerTxt";
            this.hostServerTxt.Size = new System.Drawing.Size(185, 22);
            this.hostServerTxt.TabIndex = 1;
            // 
            // portServerTxt
            // 
            this.portServerTxt.Location = new System.Drawing.Point(379, 45);
            this.portServerTxt.Name = "portServerTxt";
            this.portServerTxt.Size = new System.Drawing.Size(183, 22);
            this.portServerTxt.TabIndex = 2;
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(597, 45);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(75, 23);
            this.startBtn.TabIndex = 3;
            this.startBtn.Text = "Start";
            this.startBtn.UseVisualStyleBackColor = true;
            // 
            // stopBtn
            // 
            this.stopBtn.Location = new System.Drawing.Point(713, 44);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(75, 23);
            this.stopBtn.TabIndex = 4;
            this.stopBtn.Text = "Stop";
            this.stopBtn.UseVisualStyleBackColor = true;
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
            // Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.portLblServer);
            this.Controls.Add(this.hostLblServer);
            this.Controls.Add(this.stopBtn);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.portServerTxt);
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
        private System.Windows.Forms.TextBox portServerTxt;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Button stopBtn;
        private System.Windows.Forms.Label hostLblServer;
        private System.Windows.Forms.Label portLblServer;
    }
}