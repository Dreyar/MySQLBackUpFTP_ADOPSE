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
    public partial class EncryptionSettings : Form
    {
        public EncryptionSettings()
        {
            InitializeComponent();
            algorithmCB.SelectedIndex = 0;
            Cryptography cr = BinarySerialization.DeserializeCryptography(BinarySerialization.CRYPTOGRAPHY_SETTINGS);
            if (cr != null)
            {
                keysizeCB.SelectedIndex = cr.GetKeySize();
                passwordTB.Text = cr.GetPassword();
                repasswordTB.Text = cr.GetPassword();
            }
            else
            {
                keysizeCB.SelectedIndex = 0;
                passwordTB.Text = "";
                repasswordTB.Text = "";
            }
            this.Visible = true;
        }

        private void EncryptionSettings_Load(object sender, EventArgs e)
        {

        }

        private void cancelB_Click(object sender, EventArgs e)
        {
            this.Close();
            MainWindow.isEncryptionSettingsOpen = false;
        }

        private void okB_Click(object sender, EventArgs e)
        {
            if (passwordTB.Text.Equals(repasswordTB.Text))
            {
                passwordMismatchL.Visible = false;
                Cryptography cr = new Cryptography(passwordTB.Text, (byte)keysizeCB.SelectedIndex);
                BinarySerialization.Serialize(cr, BinarySerialization.CRYPTOGRAPHY_SETTINGS);
                this.Close();
                MainWindow.isEncryptionSettingsOpen = false;
            }
            else
                passwordMismatchL.Visible = true;
        }

        private void algorithmCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void keysizeCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
