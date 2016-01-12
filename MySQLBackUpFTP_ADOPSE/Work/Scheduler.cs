using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Threading;

namespace MySQLBackUpFTP_ADOPSE.Work
{
    class Scheduler
    {
        private static short workerInstance=-1;
        private BackgroundWorker bgw;

        public delegate void WorkTime();
        public event WorkTime RaiseWorkTime;

        public Scheduler() { }

        public void RunScheduler()
        {
            bgw = new BackgroundWorker();
            bgw.DoWork += new DoWorkEventHandler(DoRunScheduler);
            bgw.RunWorkerAsync();
        }

        private void DoRunScheduler(object sender, DoWorkEventArgs e)
        {
            short myInstance = ++workerInstance;
            BackgroundWorker worker = sender as BackgroundWorker;
            do
            {
                bool[] week = { MySQLBackUpFTP_ADOPSE.Properties.Settings.Default.sundayJob, MySQLBackUpFTP_ADOPSE.Properties.Settings.Default.mondayJob, MySQLBackUpFTP_ADOPSE.Properties.Settings.Default.tuesdayJob, MySQLBackUpFTP_ADOPSE.Properties.Settings.Default.wednesdayJob, MySQLBackUpFTP_ADOPSE.Properties.Settings.Default.thursdayJob, MySQLBackUpFTP_ADOPSE.Properties.Settings.Default.fridayJob, MySQLBackUpFTP_ADOPSE.Properties.Settings.Default.saturdayJob };
                TimeSpan timeOfJob = new TimeSpan(MySQLBackUpFTP_ADOPSE.Properties.Settings.Default.hourJob, MySQLBackUpFTP_ADOPSE.Properties.Settings.Default.minuteJob, 0);
                byte today = (byte)DateTime.Now.DayOfWeek;
                TimeSpan now = DateTime.Now.TimeOfDay;
                if (week[today])
                {
                    if (timeOfJob > now || timeOfJob==now)
                    {
                        Thread.Sleep(timeOfJob - now);
                        if (myInstance == workerInstance && MySQLBackUpFTP_ADOPSE.Properties.Settings.Default.auto)
                            RaiseWorkTime();
                    }
                    else
                    {
                        Thread.Sleep(new TimeSpan(24, 0, 0) - now);
                    }
                }
                else
                {
                    Thread.Sleep(new TimeSpan(24, 0, 0) - now);
                }
            } while (myInstance == workerInstance && MySQLBackUpFTP_ADOPSE.Properties.Settings.Default.auto);
        }
    }
}
