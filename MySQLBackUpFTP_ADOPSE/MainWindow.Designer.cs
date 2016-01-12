namespace MySQLBackUpFTP_ADOPSE
{
    partial class MainWindow
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.decryptBackupFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backupPathToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fTPConnectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autodeleteOldBackupsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emailNotificationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.encryptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scheduleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutMySQLBackUpFTPADOPSEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.currentStatusL = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.backupNowB = new System.Windows.Forms.Button();
            this.backupOptionsGB = new System.Windows.Forms.GroupBox();
            this.deleteOldCB = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.encryptCB = new System.Windows.Forms.CheckBox();
            this.deleteFilesCB = new System.Windows.Forms.CheckBox();
            this.autoBackupCB = new System.Windows.Forms.CheckBox();
            this.sendCB = new System.Windows.Forms.CheckBox();
            this.emailCB = new System.Windows.Forms.CheckBox();
            this.myDatabasesCLB = new System.Windows.Forms.CheckedListBox();
            this.removeDBB = new System.Windows.Forms.Button();
            this.addDBB = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.backupNowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon2 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exitMySQLBackUpFTPADOPSEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.backupOptionsGB.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(540, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.decryptBackupFileToolStripMenuItem,
            this.logFileToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // decryptBackupFileToolStripMenuItem
            // 
            this.decryptBackupFileToolStripMenuItem.Name = "decryptBackupFileToolStripMenuItem";
            this.decryptBackupFileToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.decryptBackupFileToolStripMenuItem.Text = "Decrypt backup file";
            this.decryptBackupFileToolStripMenuItem.Click += new System.EventHandler(this.decryptBackupFileToolStripMenuItem_Click);
            // 
            // logFileToolStripMenuItem
            // 
            this.logFileToolStripMenuItem.Name = "logFileToolStripMenuItem";
            this.logFileToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.logFileToolStripMenuItem.Text = "Log file";
            this.logFileToolStripMenuItem.Click += new System.EventHandler(this.logFileToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backupPathToolStripMenuItem,
            this.fTPConnectionToolStripMenuItem,
            this.autodeleteOldBackupsToolStripMenuItem,
            this.emailNotificationsToolStripMenuItem,
            this.encryptionToolStripMenuItem,
            this.scheduleToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click);
            // 
            // backupPathToolStripMenuItem
            // 
            this.backupPathToolStripMenuItem.Name = "backupPathToolStripMenuItem";
            this.backupPathToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.backupPathToolStripMenuItem.Text = "Backup path";
            this.backupPathToolStripMenuItem.Click += new System.EventHandler(this.backupPathToolStripMenuItem_Click);
            // 
            // fTPConnectionToolStripMenuItem
            // 
            this.fTPConnectionToolStripMenuItem.Name = "fTPConnectionToolStripMenuItem";
            this.fTPConnectionToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.fTPConnectionToolStripMenuItem.Text = "FTP connection";
            this.fTPConnectionToolStripMenuItem.Click += new System.EventHandler(this.fTPConnectionToolStripMenuItem_Click);
            // 
            // autodeleteOldBackupsToolStripMenuItem
            // 
            this.autodeleteOldBackupsToolStripMenuItem.Name = "autodeleteOldBackupsToolStripMenuItem";
            this.autodeleteOldBackupsToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.autodeleteOldBackupsToolStripMenuItem.Text = "Auto-delete old backups";
            this.autodeleteOldBackupsToolStripMenuItem.Click += new System.EventHandler(this.autodeleteOldBackupsToolStripMenuItem_Click);
            // 
            // emailNotificationsToolStripMenuItem
            // 
            this.emailNotificationsToolStripMenuItem.Name = "emailNotificationsToolStripMenuItem";
            this.emailNotificationsToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.emailNotificationsToolStripMenuItem.Text = "E-mail notifications";
            this.emailNotificationsToolStripMenuItem.Click += new System.EventHandler(this.emailNotoficationsToolStripMenuItem_Click);
            // 
            // encryptionToolStripMenuItem
            // 
            this.encryptionToolStripMenuItem.Name = "encryptionToolStripMenuItem";
            this.encryptionToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.encryptionToolStripMenuItem.Text = "Encryption";
            this.encryptionToolStripMenuItem.Click += new System.EventHandler(this.encryptionToolStripMenuItem_Click);
            // 
            // scheduleToolStripMenuItem
            // 
            this.scheduleToolStripMenuItem.Name = "scheduleToolStripMenuItem";
            this.scheduleToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.scheduleToolStripMenuItem.Text = "Schedule";
            this.scheduleToolStripMenuItem.Click += new System.EventHandler(this.scheduleToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewHelpToolStripMenuItem,
            this.aboutMySQLBackUpFTPADOPSEToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // viewHelpToolStripMenuItem
            // 
            this.viewHelpToolStripMenuItem.Name = "viewHelpToolStripMenuItem";
            this.viewHelpToolStripMenuItem.Size = new System.Drawing.Size(257, 22);
            this.viewHelpToolStripMenuItem.Text = "View help";
            this.viewHelpToolStripMenuItem.Click += new System.EventHandler(this.viewHelpToolStripMenuItem_Click);
            // 
            // aboutMySQLBackUpFTPADOPSEToolStripMenuItem
            // 
            this.aboutMySQLBackUpFTPADOPSEToolStripMenuItem.Name = "aboutMySQLBackUpFTPADOPSEToolStripMenuItem";
            this.aboutMySQLBackUpFTPADOPSEToolStripMenuItem.Size = new System.Drawing.Size(257, 22);
            this.aboutMySQLBackUpFTPADOPSEToolStripMenuItem.Text = "About MySQLBackUpFTP_ADOPSE";
            this.aboutMySQLBackUpFTPADOPSEToolStripMenuItem.Click += new System.EventHandler(this.aboutMySQLBackUpFTPADOPSEToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.backupNowB);
            this.panel1.Controls.Add(this.backupOptionsGB);
            this.panel1.Controls.Add(this.myDatabasesCLB);
            this.panel1.Controls.Add(this.removeDBB);
            this.panel1.Controls.Add(this.addDBB);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(523, 360);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.currentStatusL);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(133, 312);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(233, 39);
            this.panel2.TabIndex = 15;
            // 
            // currentStatusL
            // 
            this.currentStatusL.AutoSize = true;
            this.currentStatusL.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentStatusL.ForeColor = System.Drawing.Color.DimGray;
            this.currentStatusL.Location = new System.Drawing.Point(73, 14);
            this.currentStatusL.Name = "currentStatusL";
            this.currentStatusL.Size = new System.Drawing.Size(53, 13);
            this.currentStatusL.TabIndex = 15;
            this.currentStatusL.Text = "Standby";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Current status:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(9, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "you want to backup)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(3, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "(Check every database";
            // 
            // backupNowB
            // 
            this.backupNowB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backupNowB.Location = new System.Drawing.Point(372, 312);
            this.backupNowB.Name = "backupNowB";
            this.backupNowB.Size = new System.Drawing.Size(137, 39);
            this.backupNowB.TabIndex = 11;
            this.backupNowB.Text = "Backup Now";
            this.backupNowB.UseVisualStyleBackColor = true;
            this.backupNowB.Click += new System.EventHandler(this.backupNowB_Click);
            // 
            // backupOptionsGB
            // 
            this.backupOptionsGB.Controls.Add(this.deleteOldCB);
            this.backupOptionsGB.Controls.Add(this.label5);
            this.backupOptionsGB.Controls.Add(this.encryptCB);
            this.backupOptionsGB.Controls.Add(this.deleteFilesCB);
            this.backupOptionsGB.Controls.Add(this.autoBackupCB);
            this.backupOptionsGB.Controls.Add(this.sendCB);
            this.backupOptionsGB.Controls.Add(this.emailCB);
            this.backupOptionsGB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backupOptionsGB.Location = new System.Drawing.Point(133, 20);
            this.backupOptionsGB.Name = "backupOptionsGB";
            this.backupOptionsGB.Size = new System.Drawing.Size(376, 134);
            this.backupOptionsGB.TabIndex = 10;
            this.backupOptionsGB.TabStop = false;
            this.backupOptionsGB.Text = "Backup Options";
            // 
            // deleteOldCB
            // 
            this.deleteOldCB.AutoSize = true;
            this.deleteOldCB.Location = new System.Drawing.Point(6, 89);
            this.deleteOldCB.Name = "deleteOldCB";
            this.deleteOldCB.Size = new System.Drawing.Size(118, 17);
            this.deleteOldCB.TabIndex = 12;
            this.deleteOldCB.Text = "Delete old backups";
            this.deleteOldCB.UseVisualStyleBackColor = true;
            this.deleteOldCB.CheckedChanged += new System.EventHandler(this.deleteOldCB_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(120, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "(recommended)";
            // 
            // encryptCB
            // 
            this.encryptCB.AutoSize = true;
            this.encryptCB.Location = new System.Drawing.Point(6, 65);
            this.encryptCB.Name = "encryptCB";
            this.encryptCB.Size = new System.Drawing.Size(122, 17);
            this.encryptCB.TabIndex = 10;
            this.encryptCB.Text = "Encrypt backup files";
            this.encryptCB.UseVisualStyleBackColor = true;
            this.encryptCB.CheckedChanged += new System.EventHandler(this.encryptCB_CheckedChanged);
            // 
            // deleteFilesCB
            // 
            this.deleteFilesCB.AutoSize = true;
            this.deleteFilesCB.Enabled = false;
            this.deleteFilesCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteFilesCB.Location = new System.Drawing.Point(96, 19);
            this.deleteFilesCB.Name = "deleteFilesCB";
            this.deleteFilesCB.Size = new System.Drawing.Size(138, 17);
            this.deleteFilesCB.TabIndex = 9;
            this.deleteFilesCB.Text = "Don\'t keep backup files";
            this.deleteFilesCB.UseVisualStyleBackColor = true;
            this.deleteFilesCB.CheckedChanged += new System.EventHandler(this.deleteFilesCB_CheckedChanged);
            // 
            // autoBackupCB
            // 
            this.autoBackupCB.AutoSize = true;
            this.autoBackupCB.Location = new System.Drawing.Point(6, 112);
            this.autoBackupCB.Name = "autoBackupCB";
            this.autoBackupCB.Size = new System.Drawing.Size(87, 17);
            this.autoBackupCB.TabIndex = 8;
            this.autoBackupCB.Text = "Auto-backup";
            this.autoBackupCB.UseVisualStyleBackColor = true;
            this.autoBackupCB.CheckedChanged += new System.EventHandler(this.autoBackupCB_CheckedChanged);
            // 
            // sendCB
            // 
            this.sendCB.AutoSize = true;
            this.sendCB.Location = new System.Drawing.Point(6, 19);
            this.sendCB.Name = "sendCB";
            this.sendCB.Size = new System.Drawing.Size(91, 17);
            this.sendCB.TabIndex = 6;
            this.sendCB.Text = "Send via FTP";
            this.sendCB.UseVisualStyleBackColor = true;
            this.sendCB.CheckedChanged += new System.EventHandler(this.sendCB_CheckedChanged);
            // 
            // emailCB
            // 
            this.emailCB.AutoSize = true;
            this.emailCB.Location = new System.Drawing.Point(6, 42);
            this.emailCB.Name = "emailCB";
            this.emailCB.Size = new System.Drawing.Size(140, 17);
            this.emailCB.TabIndex = 7;
            this.emailCB.Text = "Send e-mail notifications";
            this.emailCB.UseVisualStyleBackColor = true;
            this.emailCB.CheckedChanged += new System.EventHandler(this.emailCB_CheckedChanged);
            // 
            // myDatabasesCLB
            // 
            this.myDatabasesCLB.FormattingEnabled = true;
            this.myDatabasesCLB.Location = new System.Drawing.Point(6, 50);
            this.myDatabasesCLB.Name = "myDatabasesCLB";
            this.myDatabasesCLB.Size = new System.Drawing.Size(107, 244);
            this.myDatabasesCLB.TabIndex = 9;
            this.myDatabasesCLB.SelectedIndexChanged += new System.EventHandler(this.myDatabasesCLB_SelectedIndexChanged);
            // 
            // removeDBB
            // 
            this.removeDBB.Location = new System.Drawing.Point(6, 328);
            this.removeDBB.Name = "removeDBB";
            this.removeDBB.Size = new System.Drawing.Size(107, 23);
            this.removeDBB.TabIndex = 4;
            this.removeDBB.Text = "Remove";
            this.removeDBB.UseVisualStyleBackColor = true;
            this.removeDBB.Click += new System.EventHandler(this.removeDBB_Click);
            // 
            // addDBB
            // 
            this.addDBB.Location = new System.Drawing.Point(6, 299);
            this.addDBB.Name = "addDBB";
            this.addDBB.Size = new System.Drawing.Size(107, 23);
            this.addDBB.TabIndex = 2;
            this.addDBB.Text = "Add";
            this.addDBB.UseVisualStyleBackColor = true;
            this.addDBB.Click += new System.EventHandler(this.addDBB_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "My Databases";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "MySQLBackUpFTP_ADOPSE";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backupNowToolStripMenuItem,
            this.toolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(243, 48);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // backupNowToolStripMenuItem
            // 
            this.backupNowToolStripMenuItem.Name = "backupNowToolStripMenuItem";
            this.backupNowToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.backupNowToolStripMenuItem.Text = "Backup Now";
            this.backupNowToolStripMenuItem.Click += new System.EventHandler(this.backupNowToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(242, 22);
            this.toolStripMenuItem1.Text = "Exit MySQLBackUpFTP_ADOPSE";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // notifyIcon2
            // 
            this.notifyIcon2.ContextMenuStrip = this.contextMenuStrip2;
            this.notifyIcon2.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon2.Icon")));
            this.notifyIcon2.Text = "MySQLBackUpFTP_ADOPSE: Working...";
            this.notifyIcon2.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon2_MouseDoubleClick);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitMySQLBackUpFTPADOPSEToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(243, 26);
            // 
            // exitMySQLBackUpFTPADOPSEToolStripMenuItem
            // 
            this.exitMySQLBackUpFTPADOPSEToolStripMenuItem.Name = "exitMySQLBackUpFTPADOPSEToolStripMenuItem";
            this.exitMySQLBackUpFTPADOPSEToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.exitMySQLBackUpFTPADOPSEToolStripMenuItem.Text = "Exit MySQLBackUpFTP_ADOPSE";
            this.exitMySQLBackUpFTPADOPSEToolStripMenuItem.Click += new System.EventHandler(this.exitMySQLBackUpFTPADOPSEToolStripMenuItem_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 391);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(556, 429);
            this.MinimumSize = new System.Drawing.Size(556, 429);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MySQLBackUpFTP_ADOPSE";
            this.Load += new System.EventHandler(this.mainWindow_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.backupOptionsGB.ResumeLayout(false);
            this.backupOptionsGB.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button removeDBB;
        private System.Windows.Forms.Button addDBB;
        private System.Windows.Forms.CheckBox emailCB;
        private System.Windows.Forms.CheckBox sendCB;
        private System.Windows.Forms.GroupBox backupOptionsGB;
        private System.Windows.Forms.Button backupNowB;
        private System.Windows.Forms.CheckBox autoBackupCB;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backupPathToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fTPConnectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem emailNotificationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scheduleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewHelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutMySQLBackUpFTPADOPSEToolStripMenuItem;
        public System.Windows.Forms.CheckedListBox myDatabasesCLB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label currentStatusL;
        private System.Windows.Forms.ToolStripMenuItem logFileToolStripMenuItem;
        private System.Windows.Forms.CheckBox deleteFilesCB;
        private System.Windows.Forms.ToolStripMenuItem encryptionToolStripMenuItem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox encryptCB;
        private System.Windows.Forms.ToolStripMenuItem decryptBackupFileToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem autodeleteOldBackupsToolStripMenuItem;
        private System.Windows.Forms.CheckBox deleteOldCB;
        private System.Windows.Forms.NotifyIcon notifyIcon2;
        private System.Windows.Forms.ToolStripMenuItem backupNowToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem exitMySQLBackUpFTPADOPSEToolStripMenuItem;

    }
}

