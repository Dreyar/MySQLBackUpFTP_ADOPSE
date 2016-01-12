namespace MySQLBackUpFTP_ADOPSE
{
    partial class EmailNotifications
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmailNotifications));
            this.panel1 = new System.Windows.Forms.Panel();
            this.cancelB = new System.Windows.Forms.Button();
            this.okB = new System.Windows.Forms.Button();
            this.ftpFAILCB = new System.Windows.Forms.CheckBox();
            this.ftpOKCB = new System.Windows.Forms.CheckBox();
            this.backupFAILCB = new System.Windows.Forms.CheckBox();
            this.backupOKCB = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.passwordTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.emailTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.advancedP = new System.Windows.Forms.Panel();
            this.usernameTB = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.sslCB = new System.Windows.Forms.CheckBox();
            this.authCB = new System.Windows.Forms.CheckBox();
            this.portNUD = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.serverAddressTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.providerCB = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.advancedP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.portNUD)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cancelB);
            this.panel1.Controls.Add(this.okB);
            this.panel1.Controls.Add(this.ftpFAILCB);
            this.panel1.Controls.Add(this.ftpOKCB);
            this.panel1.Controls.Add(this.backupFAILCB);
            this.panel1.Controls.Add(this.backupOKCB);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.passwordTB);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.emailTB);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.advancedP);
            this.panel1.Controls.Add(this.providerCB);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(303, 334);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // cancelB
            // 
            this.cancelB.Location = new System.Drawing.Point(147, 311);
            this.cancelB.Name = "cancelB";
            this.cancelB.Size = new System.Drawing.Size(75, 23);
            this.cancelB.TabIndex = 13;
            this.cancelB.Text = "Cancel";
            this.cancelB.UseVisualStyleBackColor = true;
            this.cancelB.Click += new System.EventHandler(this.cancelB_Click);
            // 
            // okB
            // 
            this.okB.Location = new System.Drawing.Point(228, 311);
            this.okB.Name = "okB";
            this.okB.Size = new System.Drawing.Size(75, 23);
            this.okB.TabIndex = 12;
            this.okB.Text = "OK";
            this.okB.UseVisualStyleBackColor = true;
            this.okB.Click += new System.EventHandler(this.okB_Click);
            // 
            // ftpFAILCB
            // 
            this.ftpFAILCB.AutoSize = true;
            this.ftpFAILCB.Location = new System.Drawing.Point(12, 284);
            this.ftpFAILCB.Name = "ftpFAILCB";
            this.ftpFAILCB.Size = new System.Drawing.Size(137, 17);
            this.ftpFAILCB.TabIndex = 11;
            this.ftpFAILCB.Text = "FTP transmission failure";
            this.ftpFAILCB.UseVisualStyleBackColor = true;
            // 
            // ftpOKCB
            // 
            this.ftpOKCB.AutoSize = true;
            this.ftpOKCB.Location = new System.Drawing.Point(12, 261);
            this.ftpOKCB.Name = "ftpOKCB";
            this.ftpOKCB.Size = new System.Drawing.Size(148, 17);
            this.ftpOKCB.TabIndex = 10;
            this.ftpOKCB.Text = "FTP transmission success";
            this.ftpOKCB.UseVisualStyleBackColor = true;
            // 
            // backupFAILCB
            // 
            this.backupFAILCB.AutoSize = true;
            this.backupFAILCB.Location = new System.Drawing.Point(12, 238);
            this.backupFAILCB.Name = "backupFAILCB";
            this.backupFAILCB.Size = new System.Drawing.Size(141, 17);
            this.backupFAILCB.TabIndex = 9;
            this.backupFAILCB.Text = "Backup operation failure";
            this.backupFAILCB.UseVisualStyleBackColor = true;
            // 
            // backupOKCB
            // 
            this.backupOKCB.AutoSize = true;
            this.backupOKCB.Location = new System.Drawing.Point(12, 215);
            this.backupOKCB.Name = "backupOKCB";
            this.backupOKCB.Size = new System.Drawing.Size(152, 17);
            this.backupOKCB.TabIndex = 8;
            this.backupOKCB.Text = "Backup operation success";
            this.backupOKCB.UseVisualStyleBackColor = true;
            this.backupOKCB.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Send me an e-mail on:";
            // 
            // passwordTB
            // 
            this.passwordTB.Location = new System.Drawing.Point(125, 164);
            this.passwordTB.Name = "passwordTB";
            this.passwordTB.Size = new System.Drawing.Size(172, 20);
            this.passwordTB.TabIndex = 7;
            this.passwordTB.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Password:";
            // 
            // emailTB
            // 
            this.emailTB.Location = new System.Drawing.Point(125, 139);
            this.emailTB.Name = "emailTB";
            this.emailTB.Size = new System.Drawing.Size(172, 20);
            this.emailTB.TabIndex = 6;
            this.emailTB.TextChanged += new System.EventHandler(this.emailTB_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "E-mail address:";
            // 
            // advancedP
            // 
            this.advancedP.Controls.Add(this.usernameTB);
            this.advancedP.Controls.Add(this.label7);
            this.advancedP.Controls.Add(this.sslCB);
            this.advancedP.Controls.Add(this.authCB);
            this.advancedP.Controls.Add(this.portNUD);
            this.advancedP.Controls.Add(this.label3);
            this.advancedP.Controls.Add(this.serverAddressTB);
            this.advancedP.Controls.Add(this.label2);
            this.advancedP.Enabled = false;
            this.advancedP.Location = new System.Drawing.Point(0, 33);
            this.advancedP.Name = "advancedP";
            this.advancedP.Size = new System.Drawing.Size(300, 100);
            this.advancedP.TabIndex = 2;
            // 
            // usernameTB
            // 
            this.usernameTB.Location = new System.Drawing.Point(125, 29);
            this.usernameTB.Name = "usernameTB";
            this.usernameTB.Size = new System.Drawing.Size(172, 20);
            this.usernameTB.TabIndex = 2;
            this.usernameTB.TextChanged += new System.EventHandler(this.usernameTB_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Username:";
            // 
            // sslCB
            // 
            this.sslCB.AutoSize = true;
            this.sslCB.Location = new System.Drawing.Point(167, 78);
            this.sslCB.Name = "sslCB";
            this.sslCB.Size = new System.Drawing.Size(130, 17);
            this.sslCB.TabIndex = 5;
            this.sslCB.Text = "Encrypted connection";
            this.sslCB.UseVisualStyleBackColor = true;
            // 
            // authCB
            // 
            this.authCB.AutoSize = true;
            this.authCB.Location = new System.Drawing.Point(70, 78);
            this.authCB.Name = "authCB";
            this.authCB.Size = new System.Drawing.Size(94, 17);
            this.authCB.TabIndex = 4;
            this.authCB.Text = "Authentication";
            this.authCB.UseVisualStyleBackColor = true;
            this.authCB.CheckedChanged += new System.EventHandler(this.authCB_CheckedChanged);
            // 
            // portNUD
            // 
            this.portNUD.Location = new System.Drawing.Point(125, 52);
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
            this.portNUD.TabIndex = 3;
            this.portNUD.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Port:";
            // 
            // serverAddressTB
            // 
            this.serverAddressTB.Location = new System.Drawing.Point(125, 7);
            this.serverAddressTB.Name = "serverAddressTB";
            this.serverAddressTB.Size = new System.Drawing.Size(172, 20);
            this.serverAddressTB.TabIndex = 1;
            this.serverAddressTB.TextChanged += new System.EventHandler(this.serverAddressTB_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Server address:";
            // 
            // providerCB
            // 
            this.providerCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.providerCB.FormattingEnabled = true;
            this.providerCB.Items.AddRange(new object[] {
            "Microsoft (someone@outlook.com)",
            "Google (someone@gmail.com)",
            "Yahoo! (someone@yahoo.com)",
            "other"});
            this.providerCB.Location = new System.Drawing.Point(125, 6);
            this.providerCB.Name = "providerCB";
            this.providerCB.Size = new System.Drawing.Size(175, 21);
            this.providerCB.TabIndex = 1;
            this.providerCB.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "E-mail service provider:";
            // 
            // EmailNotifications
            // 
            this.AcceptButton = this.okB;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 347);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(333, 385);
            this.MinimumSize = new System.Drawing.Size(333, 385);
            this.Name = "EmailNotifications";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Email notifications";
            this.Load += new System.EventHandler(this.EmailNotifications_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.advancedP.ResumeLayout(false);
            this.advancedP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.portNUD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox providerCB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel advancedP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox serverAddressTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown portNUD;
        private System.Windows.Forms.CheckBox sslCB;
        private System.Windows.Forms.CheckBox authCB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox passwordTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox emailTB;
        private System.Windows.Forms.CheckBox ftpFAILCB;
        private System.Windows.Forms.CheckBox ftpOKCB;
        private System.Windows.Forms.CheckBox backupFAILCB;
        private System.Windows.Forms.CheckBox backupOKCB;
        private System.Windows.Forms.Button cancelB;
        private System.Windows.Forms.Button okB;
        private System.Windows.Forms.TextBox usernameTB;
        private System.Windows.Forms.Label label7;
    }
}