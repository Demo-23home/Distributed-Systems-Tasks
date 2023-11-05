namespace WindowsFormsApp1
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtlog = new System.Windows.Forms.RichTextBox();
            this.txtserverport = new System.Windows.Forms.TextBox();
            this.btnstartserver = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSendtoAllClients = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnnewclient = new System.Windows.Forms.Button();
            this.btnsend = new System.Windows.Forms.Button();
            this.lblstatus = new System.Windows.Forms.Label();
            this.listBoxConnectedClients = new System.Windows.Forms.ListBox();
            this.btnSendToSelectedClient = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(416, 53);
            this.button1.TabIndex = 0;
            this.button1.Text = "Server";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 70);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Server POrt";
            // 
            // txtlog
            // 
            this.txtlog.Location = new System.Drawing.Point(36, 146);
            this.txtlog.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtlog.Name = "txtlog";
            this.txtlog.Size = new System.Drawing.Size(363, 143);
            this.txtlog.TabIndex = 2;
            this.txtlog.Text = "";
            // 
            // txtserverport
            // 
            this.txtserverport.Location = new System.Drawing.Point(107, 70);
            this.txtserverport.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtserverport.Name = "txtserverport";
            this.txtserverport.Size = new System.Drawing.Size(159, 22);
            this.txtserverport.TabIndex = 3;
            this.txtserverport.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnstartserver
            // 
            this.btnstartserver.Location = new System.Drawing.Point(279, 60);
            this.btnstartserver.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnstartserver.Name = "btnstartserver";
            this.btnstartserver.Size = new System.Drawing.Size(124, 53);
            this.btnstartserver.TabIndex = 4;
            this.btnstartserver.Text = "Start Server";
            this.btnstartserver.UseVisualStyleBackColor = true;
            this.btnstartserver.Click += new System.EventHandler(this.btnstartserver_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 127);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Log";
            // 
            // txtSendtoAllClients
            // 
            this.txtSendtoAllClients.Location = new System.Drawing.Point(36, 326);
            this.txtSendtoAllClients.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSendtoAllClients.Name = "txtSendtoAllClients";
            this.txtSendtoAllClients.Size = new System.Drawing.Size(363, 22);
            this.txtSendtoAllClients.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 294);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "send To All Clients";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnnewclient
            // 
            this.btnnewclient.Location = new System.Drawing.Point(36, 372);
            this.btnnewclient.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnnewclient.Name = "btnnewclient";
            this.btnnewclient.Size = new System.Drawing.Size(124, 53);
            this.btnnewclient.TabIndex = 8;
            this.btnnewclient.Text = "New Client";
            this.btnnewclient.UseVisualStyleBackColor = true;
            this.btnnewclient.Click += new System.EventHandler(this.btnnewclient_Click);
            // 
            // btnsend
            // 
            this.btnsend.Location = new System.Drawing.Point(276, 372);
            this.btnsend.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnsend.Name = "btnsend";
            this.btnsend.Size = new System.Drawing.Size(124, 53);
            this.btnsend.TabIndex = 9;
            this.btnsend.Text = "Send";
            this.btnsend.UseVisualStyleBackColor = true;
            this.btnsend.Click += new System.EventHandler(this.btnsend_Click);
            // 
            // lblstatus
            // 
            this.lblstatus.AutoSize = true;
            this.lblstatus.ForeColor = System.Drawing.Color.Red;
            this.lblstatus.Location = new System.Drawing.Point(16, 458);
            this.lblstatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblstatus.Name = "lblstatus";
            this.lblstatus.Size = new System.Drawing.Size(98, 17);
            this.lblstatus.TabIndex = 10;
            this.lblstatus.Text = "Discoonected ";
            // 
            // listBoxConnectedClients
            // 
            this.listBoxConnectedClients.FormattingEnabled = true;
            this.listBoxConnectedClients.ItemHeight = 16;
            this.listBoxConnectedClients.Location = new System.Drawing.Point(410, 6);
            this.listBoxConnectedClients.Name = "listBoxConnectedClients";
            this.listBoxConnectedClients.Size = new System.Drawing.Size(324, 356);
            this.listBoxConnectedClients.TabIndex = 11;
            this.listBoxConnectedClients.SelectedIndexChanged += new System.EventHandler(this.listBoxConnectedClients_SelectedIndexChanged);
            // 
            // btnSendToSelectedClient
            // 
            this.btnSendToSelectedClient.Location = new System.Drawing.Point(475, 368);
            this.btnSendToSelectedClient.Name = "btnSendToSelectedClient";
            this.btnSendToSelectedClient.Size = new System.Drawing.Size(183, 55);
            this.btnSendToSelectedClient.TabIndex = 12;
            this.btnSendToSelectedClient.Text = "Send To The Selected Client";
            this.btnSendToSelectedClient.UseVisualStyleBackColor = true;
            this.btnSendToSelectedClient.Click += new System.EventHandler(this.btnSendToSelectedClient_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 490);
            this.Controls.Add(this.btnSendToSelectedClient);
            this.Controls.Add(this.listBoxConnectedClients);
            this.Controls.Add(this.lblstatus);
            this.Controls.Add(this.btnsend);
            this.Controls.Add(this.btnnewclient);
            this.Controls.Add(this.txtSendtoAllClients);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnstartserver);
            this.Controls.Add(this.txtserverport);
            this.Controls.Add(this.txtlog);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Server";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox txtlog;
        private System.Windows.Forms.TextBox txtserverport;
        private System.Windows.Forms.Button btnstartserver;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSendtoAllClients;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnnewclient;
        private System.Windows.Forms.Button btnsend;
        private System.Windows.Forms.Label lblstatus;
        private System.Windows.Forms.ListBox listBoxConnectedClients;
        private System.Windows.Forms.Button btnSendToSelectedClient;
    }
}

