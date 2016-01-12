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
    public partial class Decrypt : Form
    {
        public Decrypt()
        {
            InitializeComponent();
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            MainWindow.isDecryptOpen = true;
            Cryptography cr = BinarySerialization.DeserializeCryptography(BinarySerialization.CRYPTOGRAPHY_SETTINGS);
            if (cr == null)
                cr = new Cryptography();
            cr.SetFile(openFileDialog1.FileName);
            cr.SetMode(Cryptography.DECRYPT);
            cr.RaiseFinishedDecryption += new Cryptography.FinishedDecryption(cr_OnFinishedDecryption);
            cr.DoCryptography();
            this.Visible = true;
        }

        private void cr_OnFinishedDecryption()
        {
            object[] p = new object[0];
            BeginInvoke(new Cryptography.FinishedDecryption(DecryptionFinished),p);
        }

        private void DecryptionFinished()
        {
            this.Close();
            MainWindow.isDecryptOpen = false;
        }

        private void Decrypt_Load(object sender, EventArgs e)
        {

        }
    }
}
