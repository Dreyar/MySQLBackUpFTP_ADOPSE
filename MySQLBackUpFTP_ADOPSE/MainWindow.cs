using MySQLBackUpFTP_ADOPSE.Work;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;

namespace MySQLBackUpFTP_ADOPSE
{
    public partial class MainWindow : Form
    {
        public static bool isBackupPathOpen = false;
        public static bool isEmailNotoficationsOpen = false;
        public static bool isFTPConnectionOpen = false;
        public static bool isHelpOpen = false;
        public static bool isScheduleOpen=false;
        public static bool isAboutOpen = false;
        public static bool isAddDBOpen = false;
        public static bool isEditDBOpen = false;
        public static bool isRemoveDBOpen = false;
        public static bool isResetOpen = false;
        public static bool isLogOpen = false;
        public static bool isEncryptionSettingsOpen = false;
        public static bool isDecryptOpen = false;
        public static bool isDeleteOldOpen = false;
        private static short operations = 0;

        public MainWindow()
        {
            if (!Directory.Exists(MySQLBackUpFTP_ADOPSE.Properties.Settings.Default.backupPath))
                MySQLBackUpFTP_ADOPSE.Properties.Settings.Default.backupPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            InitializeComponent();
            LoadSettings();
            this.FormClosing += new FormClosingEventHandler(this.FormIsClosing);
            this.Visible = true;
        }

        private void FormIsClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Visible = false;
        }

        private void Exit()
        {
            if (operations != 0)
                MessageBox.Show("Some operations are still in progress. Please wait.", "MySQLBackUpFTP_ADOPSE", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            else
            {
                ArrayList databases = BinarySerialization.DeserializeArrayList(BinarySerialization.DATABASES_ARRAYLIST);
                if (databases != null)
                {
                    for (int i = 0; i < myDatabasesCLB.Items.Count; i++)
                    {
                        for (int j = 0; j < databases.Count; j++)
                        {
                            Database database=(Database)databases[j];
                            if (myDatabasesCLB.Items[i].Equals(database.GetAlias()))
                            {
                                database.SetWillDoBackup(myDatabasesCLB.GetItemChecked(i));
                                databases[j] = database;
                                break;
                            }
                        }
                    }
                    BinarySerialization.Serialize(databases,BinarySerialization.DATABASES_ARRAYLIST);
                }
                Application.ExitThread();
            }
        }

        private void db_OnDoingBackup()
        {
            object[] p = new object[0];
            BeginInvoke(new Database.DoingBackup(BackupStarted), p);
        }

        private void db_OnFinished()
        {
            object[] p = new object[0];
            BeginInvoke(new Database.Finished(SomethingFinished),p);
        }

        private void BackupStarted()
        {
            if (operations == 0)
            {
                backupNowB.Enabled = false;
                UpdateCurrentStatusLabel("Working...");
                notifyIcon1.Visible = false;
                notifyIcon2.Visible = true;
            }
            operations++;
        }

        private void SomethingFinished()
        {
            operations--;
            if (operations == 0)
            {
                UpdateCurrentStatusLabel("Standby");
                backupNowB.Enabled = true;
                notifyIcon2.Visible = false;
                notifyIcon1.Visible = true;
            }
        }

        private void scheduler_OnWorkTime()
        {
            object[] p = new object[0];
            BeginInvoke(new Scheduler.WorkTime(Backup),p);
        }

        private void UpdateCurrentStatusLabel(string txt)
        {
            currentStatusL.Text = txt;
            if (!txt.Equals("Standby"))
                currentStatusL.ForeColor = Color.LimeGreen;
            else
                currentStatusL.ForeColor = Color.DimGray;
        }

        public void LoadSettings()
        {
            FTP ftpcheck = BinarySerialization.DeserializeFTP(BinarySerialization.FTP_SETTINGS);
            Work.EmailNotifications emailcheck = BinarySerialization.DeserializeEmailNotifications(BinarySerialization.EMAIL_SETTINGS);
            if (ftpcheck == null)
                MySQLBackUpFTP_ADOPSE.Properties.Settings.Default.sendBackup = false;
            if (emailcheck == null)
                MySQLBackUpFTP_ADOPSE.Properties.Settings.Default.notify = false;
            sendCB.Checked = MySQLBackUpFTP_ADOPSE.Properties.Settings.Default.sendBackup;
            deleteFilesCB.Checked = MySQLBackUpFTP_ADOPSE.Properties.Settings.Default.deleteFiles;
            emailCB.Checked = MySQLBackUpFTP_ADOPSE.Properties.Settings.Default.notify;
            encryptCB.Checked = MySQLBackUpFTP_ADOPSE.Properties.Settings.Default.encryptFiles;
            deleteOldCB.Checked = MySQLBackUpFTP_ADOPSE.Properties.Settings.Default.deleteOld;
            autoBackupCB.Checked = MySQLBackUpFTP_ADOPSE.Properties.Settings.Default.auto;
            RefreshDBList();
        }

        public void RefreshDBList()
        {
            ArrayList databases = BinarySerialization.DeserializeArrayList(BinarySerialization.DATABASES_ARRAYLIST);
            if (databases!=null)
            {
                myDatabasesCLB.Items.Clear();
                for (int i = 0; i < databases.Count; i++)
                {
                    Database db = (Database)databases[i];
                    myDatabasesCLB.Items.Add(db.GetAlias());
                    myDatabasesCLB.SetItemChecked(i, db.GetWillDoBackup());
                }
            }
            else
            {
                myDatabasesCLB.Items.Clear();
            }
        }

        private void Backup()
        {
            try
            {
                Cryptography cryptographySettings = BinarySerialization.DeserializeCryptography(BinarySerialization.CRYPTOGRAPHY_SETTINGS);
                if (cryptographySettings == null)
                    cryptographySettings = new Cryptography();
                FTP ftpSettings = BinarySerialization.DeserializeFTP(BinarySerialization.FTP_SETTINGS);
                if (ftpSettings == null)
                    ftpSettings = new FTP();
                else
                    ftpSettings = new FTP(ftpSettings.GetHost(), ftpSettings.GetPort(), ftpSettings.GetProtocol(), ftpSettings.GetFingerprint(), ftpSettings.GetUsername(), ftpSettings.GetPassword());
                Work.EmailNotifications emailSettings = BinarySerialization.DeserializeEmailNotifications(BinarySerialization.EMAIL_SETTINGS);
                if (emailSettings == null)
                    emailSettings = new Work.EmailNotifications();
                ArrayList databases = BinarySerialization.DeserializeArrayList(BinarySerialization.DATABASES_ARRAYLIST);
                string[] items = myDatabasesCLB.CheckedItems.OfType<string>().ToArray();
                for (int i = 0; i < databases.Count; i++)
                {
                    Database backmeup = (Database)databases[i];
                    backmeup.RaiseDoingBackup += new Database.DoingBackup(db_OnDoingBackup);
                    backmeup.RaiseFinished += new Database.Finished(db_OnFinished);
                    for (int j = 0; j < items.Length; j++)
                    {
                        if (backmeup.GetAlias().Equals(items[j]))
                        {
                            string file = MySQLBackUpFTP_ADOPSE.Properties.Settings.Default.backupPath + "\\DB_" + backmeup.GetAlias() + "_bu" + DateTime.Now.ToString("yyyyMMddHHmm") + ".sql";
                            backmeup.Backup(file, cryptographySettings, ftpSettings, emailSettings);
                        }
                    }
                }
            }
            catch (Exception) { }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void mainWindow_Load(object sender, EventArgs e)
        {

        }

        private void addDBB_Click(object sender, EventArgs e)
        {
            if (!isAddDBOpen)
            {
                new AddDB(this);
                isAddDBOpen = true;
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void setBackupPathToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void backupPathToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!isBackupPathOpen)
            {
                new BackupPath(this);
                isBackupPathOpen=true;
            }
        }

        private void fTPConnectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!isFTPConnectionOpen)
            {
                new FTPConnection();
                isFTPConnectionOpen = true;
            }
        }

        private void emailNotoficationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!isEmailNotoficationsOpen)
            {
                new EmailNotifications();
                isEmailNotoficationsOpen = true;
            }
        }

        private void scheduleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!isScheduleOpen)
            {
                new Schedule(this);
                isScheduleOpen = true;
            }
        }

        private void viewHelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!isHelpOpen)
            {
                new Help();
                isHelpOpen = true;
            }
        }

        private void aboutMySQLBackUpFTPADOPSEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!isAboutOpen)
            {
                new About();
                isAboutOpen = true;
            }
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void backupHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exit();
        }

        private void sendCB_CheckedChanged(object sender, EventArgs e)
        {
            int l = 0;
            FTP f;
            try
            {
                f = BinarySerialization.DeserializeFTP(BinarySerialization.FTP_SETTINGS);
                l = f.GetHost().Length;
            }
            catch (Exception) { }
            if (l == 0 && sendCB.Checked == true && !isFTPConnectionOpen)
            {
                sendCB.Checked = false;
                MessageBox.Show("You need to set up a valid server connection first!", "MySQLBackUpFTP_ADOPSE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                new FTPConnection();
                isFTPConnectionOpen = true;
            }
            MySQLBackUpFTP_ADOPSE.Properties.Settings.Default.sendBackup = sendCB.Checked;
            MySQLBackUpFTP_ADOPSE.Properties.Settings.Default.Save();
            if (sendCB.Checked)
                deleteFilesCB.Enabled = true;
            else
            {
                deleteFilesCB.Enabled = false;
                deleteFilesCB.Checked = false;
                MySQLBackUpFTP_ADOPSE.Properties.Settings.Default.deleteFiles = deleteFilesCB.Checked;
                MySQLBackUpFTP_ADOPSE.Properties.Settings.Default.Save();
            }
        }

        private void emailCB_CheckedChanged(object sender, EventArgs e)
        {
            int l = 0;
            Work.EmailNotifications email = BinarySerialization.DeserializeEmailNotifications(BinarySerialization.EMAIL_SETTINGS);
            try
            {
                l = email.GetAddress().Length;
            }
            catch (Exception) { }
            if (l == 0 && emailCB.Checked==true && !isEmailNotoficationsOpen)
            {
                emailCB.Checked = false;
                MessageBox.Show("You need to set up a valid server connection first!", "MySQLBackUpFTP_ADOPSE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                new EmailNotifications();
                isEmailNotoficationsOpen = true;
            }
            MySQLBackUpFTP_ADOPSE.Properties.Settings.Default.notify = emailCB.Checked;
            MySQLBackUpFTP_ADOPSE.Properties.Settings.Default.Save();
        }

        private void autoBackupCB_CheckedChanged(object sender, EventArgs e)
        {
            MySQLBackUpFTP_ADOPSE.Properties.Settings.Default.auto = autoBackupCB.Checked;
            MySQLBackUpFTP_ADOPSE.Properties.Settings.Default.Save();
            StartScheduler();
        }

        public void StartScheduler()
        {
            if (autoBackupCB.Checked)
            {
                Scheduler scheduler = new Scheduler();
                scheduler.RaiseWorkTime += new Scheduler.WorkTime(scheduler_OnWorkTime);
                scheduler.RunScheduler();
            }
        }

        private void backupNowB_Click(object sender, EventArgs e)
        {
            Backup();
        }

        private void editDBB_Click(object sender, EventArgs e)
        {

        }

        private void removeDBB_Click(object sender, EventArgs e)
        {
            if (!isRemoveDBOpen)
            {
                try
                {
                    new RemoveDB((string)myDatabasesCLB.Items[myDatabasesCLB.SelectedIndex], this);
                    isRemoveDBOpen = true;
                }
                catch (Exception ex) { }
            }
        }

        private void myDatabasesCLB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void logFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!isLogOpen)
            {
                new Log();
                isLogOpen = true;
            }
        }

        private void deleteFilesCB_CheckedChanged(object sender, EventArgs e)
        {
            MySQLBackUpFTP_ADOPSE.Properties.Settings.Default.deleteFiles = deleteFilesCB.Checked;
            MySQLBackUpFTP_ADOPSE.Properties.Settings.Default.Save();
        }

        private void encryptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!isEncryptionSettingsOpen)
            {
                new EncryptionSettings();
                isEncryptionSettingsOpen = true;
            }
        }

        private void encryptCB_CheckedChanged(object sender, EventArgs e)
        {
            MySQLBackUpFTP_ADOPSE.Properties.Settings.Default.encryptFiles = encryptCB.Checked;
            MySQLBackUpFTP_ADOPSE.Properties.Settings.Default.Save();
        }

        private void decryptAESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!isDecryptOpen)
            {
                new Decrypt();
                isDecryptOpen = true;
            }
        }

        private void decryptBackupFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Decrypt();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Visible = true;
        }


        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Exit();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void autodeleteOldBackupsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!isDeleteOldOpen)
            {
                new DeleteOld();
                isDeleteOldOpen = true;
            }
        }

        private void deleteOldCB_CheckedChanged(object sender, EventArgs e)
        {
            if (MySQLBackUpFTP_ADOPSE.Properties.Settings.Default.keepOnLocal == 0 && MySQLBackUpFTP_ADOPSE.Properties.Settings.Default.keepOnFTP == 0 && deleteOldCB.Checked && !isDeleteOldOpen)
            {
                deleteOldCB.Checked = false;
                new DeleteOld();
                isDeleteOldOpen = true;
            }
            else
            {
                MySQLBackUpFTP_ADOPSE.Properties.Settings.Default.deleteOld = deleteOldCB.Checked;
                MySQLBackUpFTP_ADOPSE.Properties.Settings.Default.Save();
            }
        }

        private void backupNowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Backup();
        }

        private void exitMySQLBackUpFTPADOPSEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exit();
        }

        private void notifyIcon2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Visible = true;
        }

    }
}
