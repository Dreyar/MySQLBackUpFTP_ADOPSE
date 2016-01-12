using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySQLBackUpFTP_ADOPSE.Work;

namespace MySQLBackUpFTP_ADOPSE
{
    public partial class EmailNotifications : Form
    {
        public EmailNotifications()
        {
            InitializeComponent();
            if (!authCB.Checked)
            {
                usernameTB.Enabled = false;
                usernameTB.Text = "";
                passwordTB.Enabled = false;
                passwordTB.Text = "";
            }
            else
            {
                usernameTB.Enabled = true;
                passwordTB.Enabled = true;
            }
            Work.EmailNotifications email= BinarySerialization.DeserializeEmailNotifications(BinarySerialization.EMAIL_SETTINGS);
            if (email != null)
            {
                providerCB.SelectedIndex = email.GetProvider();
                serverAddressTB.Text = email.GetServer();
                usernameTB.Text = email.GetUsername();
                portNUD.Value = email.GetPort();
                authCB.Checked = email.GetAuth();
                sslCB.Checked = email.GetSsl();
                emailTB.Text = email.GetAddress();
                passwordTB.Text = email.GetPassword();
            }
            else
            {
                providerCB.SelectedIndex = 0;
                serverAddressTB.Text = "smtp-mail.outlook.com";
                usernameTB.Text = "";
                portNUD.Value = 587;
                authCB.Checked = true;
                sslCB.Checked = true;
                emailTB.Text = "";
                passwordTB.Text = "";
            }
            backupOKCB.Checked = MySQLBackUpFTP_ADOPSE.Properties.Settings.Default.notifyOnBackupOK;
            backupFAILCB.Checked = MySQLBackUpFTP_ADOPSE.Properties.Settings.Default.notifyOnBackupFAIL;
            ftpOKCB.Checked = MySQLBackUpFTP_ADOPSE.Properties.Settings.Default.notifyOnFTPOK;
            ftpFAILCB.Checked = MySQLBackUpFTP_ADOPSE.Properties.Settings.Default.notifyOnFTPFAIL;
            this.Visible = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (providerCB.SelectedIndex)
            {
                case 0:
                    {
                        usernameTB.Text = "";
                        emailTB.Text = "";
                        passwordTB.Text = "";
                        advancedP.Enabled = false;
                        serverAddressTB.Text = "smtp-mail.outlook.com";
                        portNUD.Value = 587;
                        authCB.Checked = true;
                        sslCB.Checked = true;
                        break;
                    }
                case 1:
                    {
                        usernameTB.Text = "";
                        emailTB.Text = "";
                        passwordTB.Text = "";
                        advancedP.Enabled = false;
                        serverAddressTB.Text = "smtp.gmail.com";
                        portNUD.Value = 587;
                        authCB.Checked = true;
                        sslCB.Checked = true;
                        break;
                    }
                case 2:
                    {
                        usernameTB.Text = "";
                        emailTB.Text = "";
                        passwordTB.Text = "";
                        advancedP.Enabled = false;
                        serverAddressTB.Text = "smtp.mail.yahoo.com";
                        portNUD.Value = 587;
                        authCB.Checked = true;
                        sslCB.Checked = true;
                        break;
                    }
                case 3:
                    {
                        usernameTB.Text = "";
                        emailTB.Text = "";
                        passwordTB.Text = "";
                        advancedP.Enabled = true;
                        serverAddressTB.Text = "";
                        portNUD.Value = 25;
                        authCB.Checked = false;
                        sslCB.Checked = false;
                        break;
                    }
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cancelB_Click(object sender, EventArgs e)
        {
            this.Close();
            MainWindow.isEmailNotoficationsOpen = false;
        }

        private void okB_Click(object sender, EventArgs e)
        {
            Work.EmailNotifications email= new Work.EmailNotifications(Convert.ToByte(providerCB.SelectedIndex),emailTB.Text,serverAddressTB.Text,(short)portNUD.Value,sslCB.Checked,authCB.Checked,usernameTB.Text,passwordTB.Text);
            BinarySerialization.Serialize(email,BinarySerialization.EMAIL_SETTINGS);
            MySQLBackUpFTP_ADOPSE.Properties.Settings.Default.notifyOnBackupOK = backupOKCB.Checked;
            MySQLBackUpFTP_ADOPSE.Properties.Settings.Default.notifyOnBackupFAIL = backupFAILCB.Checked;
            MySQLBackUpFTP_ADOPSE.Properties.Settings.Default.notifyOnFTPOK = ftpOKCB.Checked;
            MySQLBackUpFTP_ADOPSE.Properties.Settings.Default.notifyOnFTPFAIL = ftpFAILCB.Checked;
            MySQLBackUpFTP_ADOPSE.Properties.Settings.Default.Save();
            this.Close();
            MainWindow.isEmailNotoficationsOpen = false;
        }

        private void EmailNotifications_Load(object sender, EventArgs e)
        {

        }

        private void emailTB_TextChanged(object sender, EventArgs e)
        {
            if (!advancedP.Enabled)
                usernameTB.Text = emailTB.Text;
        }

        private void serverAddressTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void usernameTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void authCB_CheckedChanged(object sender, EventArgs e)
        {
            if (!authCB.Checked)
            {
                usernameTB.Enabled = false;
                usernameTB.Text = "";
                passwordTB.Enabled = false;
                passwordTB.Text = "";
            }
            else
            {
                usernameTB.Enabled = true;
                passwordTB.Enabled=true;
            }
        }
    }
}
