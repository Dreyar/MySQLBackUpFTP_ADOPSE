namespace MySQLBackUpFTP_ADOPSE
{
    partial class EncryptionSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EncryptionSettings));
            this.settingsP = new System.Windows.Forms.Panel();
            this.passwordMismatchL = new System.Windows.Forms.Label();
            this.repasswordTB = new System.Windows.Forms.TextBox();
            this.passwordTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.keysizeCB = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.algorithmCB = new System.Windows.Forms.ComboBox();
            this.okB = new System.Windows.Forms.Button();
            this.cancelB = new System.Windows.Forms.Button();
            this.algorithmP = new System.Windows.Forms.Panel();
            this.settingsP.SuspendLayout();
            this.algorithmP.SuspendLayout();
            this.SuspendLayout();
            // 
            // settingsP
            // 
            this.settingsP.Controls.Add(this.passwordMismatchL);
            this.settingsP.Controls.Add(this.repasswordTB);
            this.settingsP.Controls.Add(this.passwordTB);
            this.settingsP.Controls.Add(this.label4);
            this.settingsP.Controls.Add(this.label3);
            this.settingsP.Controls.Add(this.keysizeCB);
            this.settingsP.Controls.Add(this.label2);
            this.settingsP.Location = new System.Drawing.Point(13, 44);
            this.settingsP.Name = "settingsP";
            this.settingsP.Size = new System.Drawing.Size(226, 105);
            this.settingsP.TabIndex = 0;
            // 
            // passwordMismatchL
            // 
            this.passwordMismatchL.AutoSize = true;
            this.passwordMismatchL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordMismatchL.ForeColor = System.Drawing.Color.Red;
            this.passwordMismatchL.Location = new System.Drawing.Point(98, 89);
            this.passwordMismatchL.Name = "passwordMismatchL";
            this.passwordMismatchL.Size = new System.Drawing.Size(117, 13);
            this.passwordMismatchL.TabIndex = 11;
            this.passwordMismatchL.Text = "Password mismatch";
            this.passwordMismatchL.Visible = false;
            // 
            // repasswordTB
            // 
            this.repasswordTB.Location = new System.Drawing.Point(96, 66);
            this.repasswordTB.Name = "repasswordTB";
            this.repasswordTB.Size = new System.Drawing.Size(127, 20);
            this.repasswordTB.TabIndex = 7;
            this.repasswordTB.UseSystemPasswordChar = true;
            // 
            // passwordTB
            // 
            this.passwordTB.Location = new System.Drawing.Point(96, 40);
            this.passwordTB.Name = "passwordTB";
            this.passwordTB.Size = new System.Drawing.Size(127, 20);
            this.passwordTB.TabIndex = 6;
            this.passwordTB.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Retype password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password:";
            // 
            // keysizeCB
            // 
            this.keysizeCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.keysizeCB.FormattingEnabled = true;
            this.keysizeCB.Items.AddRange(new object[] {
            "128",
            "192",
            "256"});
            this.keysizeCB.Location = new System.Drawing.Point(153, 6);
            this.keysizeCB.Name = "keysizeCB";
            this.keysizeCB.Size = new System.Drawing.Size(70, 21);
            this.keysizeCB.TabIndex = 3;
            this.keysizeCB.SelectedIndexChanged += new System.EventHandler(this.keysizeCB_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Key size (bits):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Encryption algorithm:";
            // 
            // algorithmCB
            // 
            this.algorithmCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.algorithmCB.FormattingEnabled = true;
            this.algorithmCB.Items.AddRange(new object[] {
            "AES"});
            this.algorithmCB.Location = new System.Drawing.Point(153, 0);
            this.algorithmCB.Name = "algorithmCB";
            this.algorithmCB.Size = new System.Drawing.Size(70, 21);
            this.algorithmCB.TabIndex = 1;
            this.algorithmCB.SelectedIndexChanged += new System.EventHandler(this.algorithmCB_SelectedIndexChanged);
            // 
            // okB
            // 
            this.okB.Location = new System.Drawing.Point(164, 149);
            this.okB.Name = "okB";
            this.okB.Size = new System.Drawing.Size(75, 23);
            this.okB.TabIndex = 8;
            this.okB.Text = "OK";
            this.okB.UseVisualStyleBackColor = true;
            this.okB.Click += new System.EventHandler(this.okB_Click);
            // 
            // cancelB
            // 
            this.cancelB.Location = new System.Drawing.Point(83, 149);
            this.cancelB.Name = "cancelB";
            this.cancelB.Size = new System.Drawing.Size(75, 23);
            this.cancelB.TabIndex = 9;
            this.cancelB.Text = "Cancel";
            this.cancelB.UseVisualStyleBackColor = true;
            this.cancelB.Click += new System.EventHandler(this.cancelB_Click);
            // 
            // algorithmP
            // 
            this.algorithmP.Controls.Add(this.label1);
            this.algorithmP.Controls.Add(this.algorithmCB);
            this.algorithmP.Location = new System.Drawing.Point(13, 13);
            this.algorithmP.Name = "algorithmP";
            this.algorithmP.Size = new System.Drawing.Size(226, 25);
            this.algorithmP.TabIndex = 10;
            // 
            // EncryptionSettings
            // 
            this.AcceptButton = this.okB;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(240, 172);
            this.ControlBox = false;
            this.Controls.Add(this.algorithmP);
            this.Controls.Add(this.cancelB);
            this.Controls.Add(this.settingsP);
            this.Controls.Add(this.okB);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(256, 210);
            this.MinimumSize = new System.Drawing.Size(256, 210);
            this.Name = "EncryptionSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Encryption settings";
            this.Load += new System.EventHandler(this.EncryptionSettings_Load);
            this.settingsP.ResumeLayout(false);
            this.settingsP.PerformLayout();
            this.algorithmP.ResumeLayout(false);
            this.algorithmP.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel settingsP;
        private System.Windows.Forms.TextBox repasswordTB;
        private System.Windows.Forms.TextBox passwordTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox keysizeCB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox algorithmCB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cancelB;
        private System.Windows.Forms.Button okB;
        private System.Windows.Forms.Panel algorithmP;
        private System.Windows.Forms.Label passwordMismatchL;
    }
}