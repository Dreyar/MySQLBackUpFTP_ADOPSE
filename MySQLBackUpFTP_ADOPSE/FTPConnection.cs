using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySQLBackUpFTP_ADOPSE.Work;

namespace MySQLBackUpFTP_ADOPSE
{
    public partial class FTPConnection : Form
    {
        public FTPConnection()
        {
            InitializeComponent();
            FTP ftp = BinarySerialization.DeserializeFTP(BinarySerialization.FTP_SETTINGS);
            if(ftp!=null)
            {
                hostTB.Text = ftp.GetHost();
                portNUD.Value = Convert.ToInt32(ftp.GetPort());
                protocolCB.SelectedIndex = ftp.GetProtocol();
                fingerprintTB.Text = ftp.GetFingerprint();
                usernameTB.Text = ftp.GetUsername();
                PasswordTB.Text = ftp.GetPassword();
            }
            else
            {
                hostTB.Text = "";
                portNUD.Value = 22;
                protocolCB.SelectedIndex = 0;
                fingerprintTB.Text = "";
                usernameTB.Text = "";
                PasswordTB.Text = "";
            }
            this.Visible = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FTPConnection_Load(object sender, EventArgs e)
        {

        }

        private void portTB_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BinarySerialization.Serialize(new FTP(hostTB.Text, (short)portNUD.Value, Convert.ToByte(protocolCB.SelectedIndex), fingerprintTB.Text, usernameTB.Text, PasswordTB.Text), BinarySerialization.FTP_SETTINGS);
            this.Close();
            MainWindow.isFTPConnectionOpen = false;
        }

        private void sshCB_CheckedChanged(object sender, EventArgs e)
        {
            if (fingerprintCB.Checked)
                fingerprintTB.Enabled = true;
            else
            {
                fingerprintTB.Enabled = false;
                fingerprintTB.Text = "";
            }
        }


        private void checkConnectionB_Click(object sender, EventArgs e)
        {
            waitP.Visible = true;
            if (!fingerprintCB.Checked)
                fingerprintTB.Text = "";
            FTP ftp = new FTP(hostTB.Text, (short)portNUD.Value, Convert.ToByte(protocolCB.SelectedIndex), fingerprintTB.Text, usernameTB.Text, PasswordTB.Text);
            ftp.RaiseConnectionOK += new FTP.ConnectionOK(ftp_OnConnectionOK);
            ftp.RaiseConnectionFAILED += new FTP.ConnectionFAILED(ftp_OnConnectionFAILED);
            ftp.TestConnection();
        }

        private void ftp_OnConnectionOK()
        {
            object[] p = new object[0];
            BeginInvoke(new FTP.ConnectionOK(ConnectionIsOK),p);
        }

        private void ftp_OnConnectionFAILED()
        {
            object[] p = new object[0];
            BeginInvoke(new FTP.ConnectionFAILED(ConnectionIsNotOK), p);
        }

        private void ConnectionIsOK()
        {
            connectionUnsuccessfulL.Visible = false;
            connectionOkL.Visible = true;
            waitP.Visible = false;
            panel1.Enabled = false;
            okB.Enabled = true;
            okB.Focus();
        }

        private void ConnectionIsNotOK()
        {
            waitP.Visible = false;
            connectionUnsuccessfulL.Visible = true;
        }

        private void CancelB_Click(object sender, EventArgs e)
        {
            this.Close();
            MainWindow.isFTPConnectionOpen = false;
        }


        private void protocolCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (protocolCB.SelectedIndex == FTP.FTP_PROTOCOL || protocolCB.SelectedIndex == FTP.WEBDAV_PROTOCOL)
            {
                fingerprintCB.Enabled = false;
                fingerprintCB.Checked = false;
                fingerprintTB.Enabled = false;
                fingerprintTB.Text = "";
            }
            else
            {
                fingerprintCB.Enabled = true;
            }
        }
    }
}
