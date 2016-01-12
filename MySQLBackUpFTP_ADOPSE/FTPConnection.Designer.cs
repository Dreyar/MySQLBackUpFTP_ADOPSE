namespace MySQLBackUpFTP_ADOPSE
{
    partial class FTPConnection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FTPConnection));
            this.panel1 = new System.Windows.Forms.Panel();
            this.connectionUnsuccessfulL = new System.Windows.Forms.Label();
            this.checkConnectionB = new System.Windows.Forms.Button();
            this.fingerprintTB = new System.Windows.Forms.TextBox();
            this.fingerprintCB = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.protocolCB = new System.Windows.Forms.ComboBox();
            this.portNUD = new System.Windows.Forms.NumericUpDown();
            this.PasswordTB = new System.Windows.Forms.TextBox();
            this.usernameTB = new System.Windows.Forms.TextBox();
            this.hostTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.okB = new System.Windows.Forms.Button();
            this.CancelB = new System.Windows.Forms.Button();
            this.connectionOkL = new System.Windows.Forms.Label();
            this.waitP = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.portNUD)).BeginInit();
            this.waitP.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.connectionUnsuccessfulL);
            this.panel1.Controls.Add(this.checkConnectionB);
            this.panel1.Controls.Add(this.fingerprintTB);
            this.panel1.Controls.Add(this.fingerprintCB);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.protocolCB);
            this.panel1.Controls.Add(this.portNUD);
            this.panel1.Controls.Add(this.PasswordTB);
            this.panel1.Controls.Add(this.usernameTB);
            this.panel1.Controls.Add(this.hostTB);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(296, 230);
            this.panel1.TabIndex = 0;
            // 
            // connectionUnsuccessfulL
            // 
            this.connectionUnsuccessfulL.AutoSize = true;
            this.connectionUnsuccessfulL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connectionUnsuccessfulL.ForeColor = System.Drawing.Color.Red;
            this.connectionUnsuccessfulL.Location = new System.Drawing.Point(6, 211);
            this.connectionUnsuccessfulL.Name = "connectionUnsuccessfulL";
            this.connectionUnsuccessfulL.Size = new System.Drawing.Size(149, 13);
            this.connectionUnsuccessfulL.TabIndex = 18;
            this.connectionUnsuccessfulL.Text = "Connection unsuccessful";
            this.connectionUnsuccessfulL.Visible = false;
            // 
            // checkConnectionB
            // 
            this.checkConnectionB.Location = new System.Drawing.Point(184, 206);
            this.checkConnectionB.Name = "checkConnectionB";
            this.checkConnectionB.Size = new System.Drawing.Size(112, 23);
            this.checkConnectionB.TabIndex = 9;
            this.checkConnectionB.Text = "Check connection";
            this.checkConnectionB.UseVisualStyleBackColor = true;
            this.checkConnectionB.Click += new System.EventHandler(this.checkConnectionB_Click);
            // 
            // fingerprintTB
            // 
            this.fingerprintTB.Enabled = false;
            this.fingerprintTB.Location = new System.Drawing.Point(9, 164);
            this.fingerprintTB.Name = "fingerprintTB";
            this.fingerprintTB.Size = new System.Drawing.Size(285, 20);
            this.fingerprintTB.TabIndex = 8;
            // 
            // fingerprintCB
            // 
            this.fingerprintCB.AutoSize = true;
            this.fingerprintCB.Enabled = false;
            this.fingerprintCB.Location = new System.Drawing.Point(8, 141);
            this.fingerprintCB.Name = "fingerprintCB";
            this.fingerprintCB.Size = new System.Drawing.Size(241, 17);
            this.fingerprintCB.TabIndex = 7;
            this.fingerprintCB.Text = "Connect only if SSH/TLS fingerprint matches:";
            this.fingerprintCB.UseVisualStyleBackColor = true;
            this.fingerprintCB.CheckedChanged += new System.EventHandler(this.sshCB_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Protocol:";
            // 
            // protocolCB
            // 
            this.protocolCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.protocolCB.FormattingEnabled = true;
            this.protocolCB.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.protocolCB.Items.AddRange(new object[] {
            "FTP",
            "SCP",
            "SFTP",
            "FTPS (exp.)",
            "FTPS (imp.)",
            "WebDAV",
            "WebDAV Secure"});
            this.protocolCB.Location = new System.Drawing.Point(8, 114);
            this.protocolCB.Name = "protocolCB";
            this.protocolCB.Size = new System.Drawing.Size(90, 21);
            this.protocolCB.TabIndex = 5;
            this.protocolCB.SelectedIndexChanged += new System.EventHandler(this.protocolCB_SelectedIndexChanged);
            // 
            // portNUD
            // 
            this.portNUD.Location = new System.Drawing.Point(250, 23);
            this.portNUD.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.portNUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.portNUD.Name = "portNUD";
            this.portNUD.Size = new System.Drawing.Size(44, 20);
            this.portNUD.TabIndex = 2;
            this.portNUD.Value = new decimal(new int[] {
            22,
            0,
            0,
            0});
            // 
            // PasswordTB
            // 
            this.PasswordTB.Location = new System.Drawing.Point(141, 68);
            this.PasswordTB.Name = "PasswordTB";
            this.PasswordTB.Size = new System.Drawing.Size(153, 20);
            this.PasswordTB.TabIndex = 4;
            this.PasswordTB.UseSystemPasswordChar = true;
            // 
            // usernameTB
            // 
            this.usernameTB.Location = new System.Drawing.Point(8, 68);
            this.usernameTB.Name = "usernameTB";
            this.usernameTB.Size = new System.Drawing.Size(127, 20);
            this.usernameTB.TabIndex = 3;
            // 
            // hostTB
            // 
            this.hostTB.Location = new System.Drawing.Point(8, 23);
            this.hostTB.Name = "hostTB";
            this.hostTB.Size = new System.Drawing.Size(236, 20);
            this.hostTB.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(138, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(247, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Port:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Host:";
            // 
            // okB
            // 
            this.okB.Enabled = false;
            this.okB.Location = new System.Drawing.Point(233, 257);
            this.okB.Name = "okB";
            this.okB.Size = new System.Drawing.Size(75, 23);
            this.okB.TabIndex = 10;
            this.okB.Text = "OK";
            this.okB.UseVisualStyleBackColor = true;
            this.okB.Click += new System.EventHandler(this.button1_Click);
            // 
            // CancelB
            // 
            this.CancelB.Location = new System.Drawing.Point(153, 257);
            this.CancelB.Name = "CancelB";
            this.CancelB.Size = new System.Drawing.Size(75, 23);
            this.CancelB.TabIndex = 11;
            this.CancelB.Text = "Cancel";
            this.CancelB.UseVisualStyleBackColor = true;
            this.CancelB.Click += new System.EventHandler(this.CancelB_Click);
            // 
            // connectionOkL
            // 
            this.connectionOkL.AutoSize = true;
            this.connectionOkL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connectionOkL.ForeColor = System.Drawing.Color.Green;
            this.connectionOkL.Location = new System.Drawing.Point(18, 245);
            this.connectionOkL.Name = "connectionOkL";
            this.connectionOkL.Size = new System.Drawing.Size(92, 13);
            this.connectionOkL.TabIndex = 19;
            this.connectionOkL.Text = "Connection OK";
            this.connectionOkL.Visible = false;
            // 
            // waitP
            // 
            this.waitP.Controls.Add(this.label7);
            this.waitP.Location = new System.Drawing.Point(1, 1);
            this.waitP.Name = "waitP";
            this.waitP.Size = new System.Drawing.Size(307, 241);
            this.waitP.TabIndex = 21;
            this.waitP.UseWaitCursor = true;
            this.waitP.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label7.Location = new System.Drawing.Point(71, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(173, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Checking connection...";
            this.label7.UseWaitCursor = true;
            // 
            // FTPConnection
            // 
            this.AcceptButton = this.okB;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 281);
            this.ControlBox = false;
            this.Controls.Add(this.waitP);
            this.Controls.Add(this.connectionOkL);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.CancelB);
            this.Controls.Add(this.okB);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(327, 319);
            this.MinimumSize = new System.Drawing.Size(327, 319);
            this.Name = "FTPConnection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FTP Connection";
            this.Load += new System.EventHandler(this.FTPConnection_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.portNUD)).EndInit();
            this.waitP.ResumeLayout(false);
            this.waitP.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox PasswordTB;
        private System.Windows.Forms.TextBox usernameTB;
        private System.Windows.Forms.TextBox hostTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button okB;
        private System.Windows.Forms.NumericUpDown portNUD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox protocolCB;
        private System.Windows.Forms.TextBox fingerprintTB;
        private System.Windows.Forms.CheckBox fingerprintCB;
        private System.Windows.Forms.Button CancelB;
        private System.Windows.Forms.Button checkConnectionB;
        private System.Windows.Forms.Label connectionUnsuccessfulL;
        private System.Windows.Forms.Label connectionOkL;
        private System.Windows.Forms.Panel waitP;
        private System.Windows.Forms.Label label7;
    }
}