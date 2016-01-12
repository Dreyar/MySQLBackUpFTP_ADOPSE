using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Data;
using MySql;
using System.Net;
using System.Net.Security;
using System.Threading;
using System.ComponentModel;
using System.Collections;
using System.IO;
using System.Text.RegularExpressions;


namespace MySQLBackUpFTP_ADOPSE.Work
{
    [Serializable]
    class Database
    {
        protected string alias;
        private string host;
        private string dbname;
        private short port;
        private string username;
        private string password;
        private bool requireSSL;
        private bool willDoBackup;
        [field:NonSerialized]
        private MySqlConnection connection;
        [field: NonSerialized]
        private string file;
        [field: NonSerialized]
        private Cryptography cryptographySettings;
        [field: NonSerialized]
        private FTP ftpSettings;
        [field: NonSerialized]
        private EmailNotifications emailSettings;
        [field: NonSerialized]
        private byte attempts = 0;

        public Database() { }

        public void SetAlias(string alias)
        {
            this.alias = alias;
        }

        public string GetAlias()
        {
            return alias;
        }

        public string GetFile()
        {
            return file;
        }

        public void SetBasics(string host, string dbname,short port,string username, string password,bool requireSSL,bool willDoBackup)
        {
            this.host = host;
            this.dbname = dbname;
            this.port = port;
            this.username = username;
            this.password = password;
            this.requireSSL = requireSSL;
            this.willDoBackup = willDoBackup;
        }

        public void SetWillDoBackup(bool willDoBackup)
        {
            this.willDoBackup = willDoBackup;
        }

        public bool GetWillDoBackup()
        {
            return willDoBackup;
        }

        public void SetConnection()
        {
            if(!requireSSL)
                connection = new MySqlConnection("server=" + host + ";port="+port+";userid=" + username + ";password=" + password + ";database=" + dbname + ";sslmode=preferred;");
            else
                connection = new MySqlConnection("server=" + host + ";port="+port+";userid=" + username + ";password=" + password + ";database=" + dbname + ";sslmode=required;");
        }

        public delegate void ConnectionSuccessful();
        [field: NonSerialized]
        public event ConnectionSuccessful RaiseConnectionSuccessful;

        public delegate void ConnectionUnsuccessful();
        [field: NonSerialized]
        public event ConnectionUnsuccessful RaiseConnectionUnsuccessful;

        public delegate void DoingBackup();
        [field: NonSerialized]
        public event DoingBackup RaiseDoingBackup;

        public delegate void Finished();
        [field: NonSerialized]
        public event Finished RaiseFinished;

        public void CheckConnection()
        {
            SetConnection();
            BackgroundWorker bgw = new BackgroundWorker();
            bgw.DoWork += new DoWorkEventHandler(CheckDatabaseConnection);
            bgw.RunWorkerAsync();
        }

        private void CheckDatabaseConnection(object sender,DoWorkEventArgs e)
        {
            try
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand("select @@version", connection);
                MySqlDataReader reader = command.ExecuteReader();
                connection.Close();
                RaiseConnectionSuccessful();
            }
            catch (Exception ex)
            {
                RaiseConnectionUnsuccessful();
            }
        }

        public void Backup(string file,Cryptography cryptographySettings,FTP ftpSettings,EmailNotifications emailSettings)
        {
            this.file = file;
            this.cryptographySettings = cryptographySettings;
            this.ftpSettings = ftpSettings;
            this.emailSettings = emailSettings;
            SetConnection();
            BackgroundWorker bgw = new BackgroundWorker();
            bgw.DoWork += new DoWorkEventHandler(DoBackup);
            bgw.RunWorkerAsync();
        }

        private void DoBackup(object sender,DoWorkEventArgs e)
        {
            attempts++;
            new Log("Back-up operation for \""+alias+"\" started.");
            RaiseDoingBackup();
            using (connection)
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    using (MySqlBackup mb = new MySqlBackup(cmd))
                    {
                        try
                        {
                            cmd.Connection = connection;
                            connection.Open();
                            mb.ExportToFile(file);
                            connection.Close();
                            new Log("Back-up operation for \"" + alias + "\" completed successfully.");
                            emailSettings.NotifyCheck(alias,EmailNotifications.BACKUP_OPERATION_OK);
                            cryptographySettings.SetFile(file);
                            cryptographySettings.SetMode(Cryptography.ENCRYPT);
                            cryptographySettings.DoCryptography();
                            DeleteOldFiles();
                            ftpSettings.Transmission(this,emailSettings);
                            DeleteAfterBackup();
                            ftpSettings.DeleteOld(this);
                        }
                        catch (Exception ex)
                        {
                            if (attempts < 6)
                                DoBackup(sender,e);
                            else
                            {
                                new Log("ERROR: Back-up operation for \"" + alias + "\" failed.");
                                emailSettings.NotifyCheck(alias, EmailNotifications.BACKUP_OPERATION_FAIL);
                            }
                        }
                    }
                }
            }
            RaiseFinished();
        }

        private void DeleteOldFiles()
        {
            if (MySQLBackUpFTP_ADOPSE.Properties.Settings.Default.deleteOld && MySQLBackUpFTP_ADOPSE.Properties.Settings.Default.keepOnLocal>0)
            {
                try
                {
                    string[] listfiles = Directory.GetFiles(MySQLBackUpFTP_ADOPSE.Properties.Settings.Default.backupPath);
                    Regex regex = new Regex("DB_" + alias + @"_bu............\.sql$");
                    ArrayList files = new ArrayList();
                    for (int i = 0; i < listfiles.Length; i++)
                    {
                        Match match = regex.Match(listfiles[i]);
                        if (match.Success)
                            files.Add(listfiles[i]);
                    }
                    files.Sort();
                    int keepOnLocal = MySQLBackUpFTP_ADOPSE.Properties.Settings.Default.keepOnLocal;
                    if (MySQLBackUpFTP_ADOPSE.Properties.Settings.Default.deleteFiles)
                        keepOnLocal++;
                    for (int i = 0; i < files.Count - keepOnLocal; i++)
                        File.Delete((string)files[i]);
                }
                catch (Exception)
                {
                    new Log("Error trying to delete old backup file(s) from disk.");
                }
            }
        }

        public void DeleteAfterBackup()
        {
            if (MySQLBackUpFTP_ADOPSE.Properties.Settings.Default.deleteFiles)
            {
                try
                {
                    File.Delete(file);
                }
                catch (Exception)
                {
                    new Log("Error trying to delete backup file from disk.");
                }
            }
        }
    }
}
