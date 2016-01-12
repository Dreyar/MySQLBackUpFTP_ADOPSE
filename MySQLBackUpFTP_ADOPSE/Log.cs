using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Collections.Specialized;
using MySQLBackUpFTP_ADOPSE.Work;

namespace MySQLBackUpFTP_ADOPSE
{
    public partial class Log : Form
    {

        public Log()
        {
            InitializeComponent();
            this.Visible = true;
            LoadLog();
        }

        private void LoadLog()
        {
            logTB.Text = "";
            StringCollection log = MySQLBackUpFTP_ADOPSE.Properties.Settings.Default.log;
            if (log != null)
            {
                for (int i = log.Count; i-- > 0; )
                {
                    logTB.Text += log[i];
                    logTB.AppendText(Environment.NewLine);
                }
            }
            logTB.Select(0,0);
            logTB.ScrollToCaret();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainWindow.isLogOpen = false;
            this.Close();
        }

        private void Log_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MySQLBackUpFTP_ADOPSE.Properties.Settings.Default.log = null;
            MySQLBackUpFTP_ADOPSE.Properties.Settings.Default.Save();
            LoadLog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoadLog();
        }
    }
}
