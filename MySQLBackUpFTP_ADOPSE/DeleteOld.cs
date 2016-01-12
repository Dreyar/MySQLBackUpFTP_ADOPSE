using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MySQLBackUpFTP_ADOPSE
{
    public partial class DeleteOld : Form
    {
        public DeleteOld()
        {
            InitializeComponent();
            keepOnLocalNUD.Value = MySQLBackUpFTP_ADOPSE.Properties.Settings.Default.keepOnLocal;
            keepOnFTPNUD.Value = MySQLBackUpFTP_ADOPSE.Properties.Settings.Default.keepOnFTP;
            this.Visible = true;
        }

        private void DeleteOld_Load(object sender, EventArgs e)
        {

        }

        private void okB_Click(object sender, EventArgs e)
        {
            MySQLBackUpFTP_ADOPSE.Properties.Settings.Default.keepOnLocal = (byte)keepOnLocalNUD.Value;
            MySQLBackUpFTP_ADOPSE.Properties.Settings.Default.keepOnFTP = (byte)keepOnFTPNUD.Value;
            MySQLBackUpFTP_ADOPSE.Properties.Settings.Default.Save();
            this.Close();
            MainWindow.isDeleteOldOpen = false;
        }
    }
}
