using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Collections.Specialized;

namespace MySQLBackUpFTP_ADOPSE.Work
{
    class Log
    {
        public Log(string str)
        {
            if (MySQLBackUpFTP_ADOPSE.Properties.Settings.Default.log == null)
                MySQLBackUpFTP_ADOPSE.Properties.Settings.Default.log = new StringCollection();
            MySQLBackUpFTP_ADOPSE.Properties.Settings.Default.log.Add(DateTime.Now.ToString() + ":  " + str);
            MySQLBackUpFTP_ADOPSE.Properties.Settings.Default.Save();
        }
    }
}
