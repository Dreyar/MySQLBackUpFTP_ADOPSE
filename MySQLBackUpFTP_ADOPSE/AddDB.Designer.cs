namespace MySQLBackUpFTP_ADOPSE
{
    partial class AddDB
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddDB));
            this.panel1 = new System.Windows.Forms.Panel();
            this.requireSSLCB = new System.Windows.Forms.CheckBox();
            this.noConnectionL = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.passwordTB = new System.Windows.Forms.TextBox();
            this.usernameTB = new System.Windows.Forms.TextBox();
            this.databaseTB = new System.Windows.Forms.TextBox();
            this.hostTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.aliasTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.invalidAliasL = new System.Windows.Forms.Label();
            this.usedAliasL = new System.Windows.Forms.Label();
            this.waitP = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.okB = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.portNUD = new System.Windows.Forms.NumericUpDown();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.waitP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.portNUD)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.portNUD);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.requireSSLCB);
            this.panel1.Controls.Add(this.noConnectionL);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.passwordTB);
            this.panel1.Controls.Add(this.usernameTB);
            this.panel1.Controls.Add(this.databaseTB);
            this.panel1.Controls.Add(this.hostTB);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(267, 175);
            this.panel1.TabIndex = 0;
            // 
            // requireSSLCB
            // 
            this.requireSSLCB.AutoSize = true;
            this.requireSSLCB.Location = new System.Drawing.Point(69, 138);
            this.requireSSLCB.Name = "requireSSLCB";
            this.requireSSLCB.Size = new System.Drawing.Size(86, 17);
            this.requireSSLCB.TabIndex = 11;
            this.requireSSLCB.Text = "Require SSL";
            this.requireSSLCB.UseVisualStyleBackColor = true;
            // 
            // noConnectionL
            // 
            this.noConnectionL.AutoSize = true;
            this.noConnectionL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noConnectionL.ForeColor = System.Drawing.Color.Red;
            this.noConnectionL.Location = new System.Drawing.Point(3, 158);
            this.noConnectionL.Name = "noConnectionL";
            this.noConnectionL.Size = new System.Drawing.Size(154, 13);
            this.noConnectionL.TabIndex = 10;
            this.noConnectionL.Text = "Unsuccessful connection.";
            this.noConnectionL.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(189, 136);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 37);
            this.button1.TabIndex = 9;
            this.button1.Text = "Check Connection";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Database:";
            // 
            // passwordTB
            // 
            this.passwordTB.Location = new System.Drawing.Point(69, 112);
            this.passwordTB.Name = "passwordTB";
            this.passwordTB.Size = new System.Drawing.Size(100, 20);
            this.passwordTB.TabIndex = 4;
            this.passwordTB.UseSystemPasswordChar = true;
            // 
            // usernameTB
            // 
            this.usernameTB.Location = new System.Drawing.Point(69, 85);
            this.usernameTB.Name = "usernameTB";
            this.usernameTB.Size = new System.Drawing.Size(100, 20);
            this.usernameTB.TabIndex = 3;
            // 
            // databaseTB
            // 
            this.databaseTB.Location = new System.Drawing.Point(69, 30);
            this.databaseTB.Name = "databaseTB";
            this.databaseTB.Size = new System.Drawing.Size(190, 20);
            this.databaseTB.TabIndex = 2;
            // 
            // hostTB
            // 
            this.hostTB.Location = new System.Drawing.Point(69, 4);
            this.hostTB.Name = "hostTB";
            this.hostTB.Size = new System.Drawing.Size(190, 20);
            this.hostTB.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Host:";
            // 
            // aliasTB
            // 
            this.aliasTB.Location = new System.Drawing.Point(69, 6);
            this.aliasTB.Name = "aliasTB";
            this.aliasTB.Size = new System.Drawing.Size(100, 20);
            this.aliasTB.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Alias:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.invalidAliasL);
            this.panel2.Controls.Add(this.usedAliasL);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.aliasTB);
            this.panel2.Enabled = false;
            this.panel2.Location = new System.Drawing.Point(13, 192);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(267, 50);
            this.panel2.TabIndex = 1;
            // 
            // invalidAliasL
            // 
            this.invalidAliasL.AutoSize = true;
            this.invalidAliasL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invalidAliasL.ForeColor = System.Drawing.Color.Red;
            this.invalidAliasL.Location = new System.Drawing.Point(3, 31);
            this.invalidAliasL.Name = "invalidAliasL";
            this.invalidAliasL.Size = new System.Drawing.Size(79, 13);
            this.invalidAliasL.TabIndex = 12;
            this.invalidAliasL.Text = "Invalid alias.";
            this.invalidAliasL.Visible = false;
            // 
            // usedAliasL
            // 
            this.usedAliasL.AutoSize = true;
            this.usedAliasL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usedAliasL.ForeColor = System.Drawing.Color.Red;
            this.usedAliasL.Location = new System.Drawing.Point(3, 31);
            this.usedAliasL.Name = "usedAliasL";
            this.usedAliasL.Size = new System.Drawing.Size(121, 13);
            this.usedAliasL.TabIndex = 11;
            this.usedAliasL.Text = "Alias already in use.";
            this.usedAliasL.Visible = false;
            // 
            // waitP
            // 
            this.waitP.Controls.Add(this.label6);
            this.waitP.Location = new System.Drawing.Point(5, 5);
            this.waitP.Name = "waitP";
            this.waitP.Size = new System.Drawing.Size(284, 187);
            this.waitP.TabIndex = 13;
            this.waitP.UseWaitCursor = true;
            this.waitP.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label6.Location = new System.Drawing.Point(53, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(173, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Checking connection...";
            this.label6.UseWaitCursor = true;
            // 
            // okB
            // 
            this.okB.Enabled = false;
            this.okB.Location = new System.Drawing.Point(202, 248);
            this.okB.Name = "okB";
            this.okB.Size = new System.Drawing.Size(75, 23);
            this.okB.TabIndex = 10;
            this.okB.Text = "OK";
            this.okB.UseVisualStyleBackColor = true;
            this.okB.Click += new System.EventHandler(this.okB_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(124, 248);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Port:";
            // 
            // portNUD
            // 
            this.portNUD.Location = new System.Drawing.Point(69, 56);
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
            this.portNUD.TabIndex = 13;
            this.portNUD.Value = new decimal(new int[] {
            3306,
            0,
            0,
            0});
            // 
            // AddDB
            // 
            this.AcceptButton = this.okB;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 272);
            this.ControlBox = false;
            this.Controls.Add(this.waitP);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.okB);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(296, 310);
            this.MinimumSize = new System.Drawing.Size(296, 310);
            this.Name = "AddDB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Database Connection";
            this.Load += new System.EventHandler(this.AddDB_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.waitP.ResumeLayout(false);
            this.waitP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.portNUD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox passwordTB;
        private System.Windows.Forms.TextBox usernameTB;
        private System.Windows.Forms.TextBox databaseTB;
        private System.Windows.Forms.TextBox hostTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox aliasTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label noConnectionL;
        private System.Windows.Forms.Button okB;
        private System.Windows.Forms.Label usedAliasL;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel waitP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label invalidAliasL;
        private System.Windows.Forms.CheckBox requireSSLCB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown portNUD;
    }
}