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
    public partial class Schedule : Form
    {
        private MainWindow mainWindow;

        public Schedule(MainWindow mainWindow)
        {
            InitializeComponent();
            daysLB.SetSelected(0,MySQLBackUpFTP_ADOPSE.Properties.Settings.Default.sundayJob);
            daysLB.SetSelected(1, MySQLBackUpFTP_ADOPSE.Properties.Settings.Default.mondayJob);
            daysLB.SetSelected(2, MySQLBackUpFTP_ADOPSE.Properties.Settings.Default.tuesdayJob);
            daysLB.SetSelected(3, MySQLBackUpFTP_ADOPSE.Properties.Settings.Default.wednesdayJob);
            daysLB.SetSelected(4, MySQLBackUpFTP_ADOPSE.Properties.Settings.Default.thursdayJob);
            daysLB.SetSelected(5, MySQLBackUpFTP_ADOPSE.Properties.Settings.Default.fridayJob);
            daysLB.SetSelected(6, MySQLBackUpFTP_ADOPSE.Properties.Settings.Default.saturdayJob);
            hourNUD.Value = MySQLBackUpFTP_ADOPSE.Properties.Settings.Default.hourJob;
            minuteNUD.Value = MySQLBackUpFTP_ADOPSE.Properties.Settings.Default.minuteJob;
            this.mainWindow = mainWindow;
            this.Visible = true;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Schedule_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySQLBackUpFTP_ADOPSE.Properties.Settings.Default.sundayJob = daysLB.GetSelected(0);
            MySQLBackUpFTP_ADOPSE.Properties.Settings.Default.mondayJob = daysLB.GetSelected(1);
            MySQLBackUpFTP_ADOPSE.Properties.Settings.Default.tuesdayJob = daysLB.GetSelected(2);
            MySQLBackUpFTP_ADOPSE.Properties.Settings.Default.wednesdayJob = daysLB.GetSelected(3);
            MySQLBackUpFTP_ADOPSE.Properties.Settings.Default.thursdayJob = daysLB.GetSelected(4);
            MySQLBackUpFTP_ADOPSE.Properties.Settings.Default.fridayJob = daysLB.GetSelected(5);
            MySQLBackUpFTP_ADOPSE.Properties.Settings.Default.saturdayJob = daysLB.GetSelected(6);
            MySQLBackUpFTP_ADOPSE.Properties.Settings.Default.hourJob = Convert.ToInt32(hourNUD.Value);
            MySQLBackUpFTP_ADOPSE.Properties.Settings.Default.minuteJob = Convert.ToInt32(minuteNUD.Value);
            MySQLBackUpFTP_ADOPSE.Properties.Settings.Default.Save();
            mainWindow.StartScheduler();
            this.Close();
            MainWindow.isScheduleOpen = false;
        }

        private void minuteNUD_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
