using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MySQLBackUpFTP_ADOPSE
{
    public partial class BackupPath : Form
    {
        private MainWindow mainWindow;

        public BackupPath(MainWindow mainWindow)
        {
            InitializeComponent();
            backupsLocationTB.Text = MySQLBackUpFTP_ADOPSE.Properties.Settings.Default.backupPath;
            this.mainWindow = mainWindow;
            this.Visible = true;
        }

        private void BackupPath_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(backupsLocationTB.Text))
            {
                MySQLBackUpFTP_ADOPSE.Properties.Settings.Default.backupPath = backupsLocationTB.Text;
                MySQLBackUpFTP_ADOPSE.Properties.Settings.Default.Save();
                this.Close();
                MainWindow.isBackupPathOpen = false;
            }
            else
                errorL.Text = "Invalid path.";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            MainWindow.isBackupPathOpen = false;
        }

        private void backupsLocationTB_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
