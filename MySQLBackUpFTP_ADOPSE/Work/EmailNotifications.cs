using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;

namespace MySQLBackUpFTP_ADOPSE.Work
{
    [Serializable]
    class EmailNotifications
    {
        public const byte BACKUP_OPERATION_OK = 0;
        public const byte BACKUP_OPERATION_FAIL = 1;
        public const byte FTP_OPERATION_OK = 2;
        public const byte FTP_OPERATION_FAIL = 3;

        private byte provider;
        private string address;
        private string server;
        private short port;
        private bool ssl;
        private bool auth;
        private string username;
        private string password;
        [field: NonSerialized]
        private string alias;
        [field: NonSerialized]
        private byte attempts = 0;

        public EmailNotifications() { }

        public EmailNotifications(byte provider,string address, string server, short port, bool ssl, bool auth, string username, string password)
        {
            this.provider = provider;
            this.address = address;
            this.server = server;
            this.port = port;
            this.ssl = ssl;
            this.auth = auth;
            this.username = username;
            this.password = password;
        }

        public byte GetProvider()
        {
            return provider;
        }

        public string GetAddress()
        {
            return address;
        }

        public string GetServer()
        {
            return server;
        }

        public short GetPort()
        {
            return port;
        }

        public bool GetSsl()
        {
            return ssl;
        }

        public bool GetAuth()
        {
            return auth;
        }

        public string GetUsername()
        {
            return username;
        }

        public string GetPassword()
        {
            return password;
        }

        public void NotifyCheck(string alias,byte operation)
        {
            this.alias = alias;
            if (MySQLBackUpFTP_ADOPSE.Properties.Settings.Default.notify)
            {
                switch (operation)
                {
                    case BACKUP_OPERATION_OK:
                        NotifyBackupOK();
                        break;
                    case BACKUP_OPERATION_FAIL:
                        NotifyBackupFAIL();
                        break;
                    case FTP_OPERATION_OK:
                        NotifyFTPOK();
                        break;
                    case FTP_OPERATION_FAIL:
                        NotifyFTPFAIL();
                        break;
                }
            }
        }

        private void NotifyBackupOK()
        {
            if (MySQLBackUpFTP_ADOPSE.Properties.Settings.Default.notifyOnBackupOK)
            {
                SendMail(":::MySQLBackUpFTP_ADOPSE:::  Backup operation for \"" + alias + "\" completed successfully on "+DateTime.Now.ToString()+".");
            }
        }

        private void NotifyBackupFAIL()
        {
            if (MySQLBackUpFTP_ADOPSE.Properties.Settings.Default.notifyOnBackupFAIL)
            {
                SendMail(":::MySQLBackUpFTP_ADOPSE:::  Backup operation for \"" + alias + "\" FAILED.");
            }
        }

        private void NotifyFTPOK()
        {
            if (MySQLBackUpFTP_ADOPSE.Properties.Settings.Default.notifyOnFTPOK)
            {
                SendMail(":::MySQLBackUpFTP_ADOPSE:::  FTP transmission for \"" + alias + "\" completed successfully on " + DateTime.Now.ToString() + ".");
            }
        }

        private void NotifyFTPFAIL()
        {
            if (MySQLBackUpFTP_ADOPSE.Properties.Settings.Default.notifyOnFTPFAIL)
            {
                SendMail(":::MySQLBackUpFTP_ADOPSE:::  FTP transmission for \"" + alias + "\" FAILED.");
            }
        }

        private void SendMail(string body)
        {
            attempts++;
            string subject = "MySQLBackUpFTP_ADOPSE Notification";
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient client = new SmtpClient();
                mail.From = new MailAddress(address, "MySQLBackUpFTP_ADOPSE", Encoding.UTF8);
                mail.To.Add(address);
                mail.Subject = subject;
                mail.SubjectEncoding = Encoding.UTF8;
                mail.Body = body;
                mail.IsBodyHtml = true;
                mail.BodyEncoding = Encoding.UTF8;
                client.Host = server;
                client.Port = port;
                client.UseDefaultCredentials = !auth;
                if(auth)
                    client.Credentials = new System.Net.NetworkCredential(username, password);
                client.EnableSsl = ssl;
                client.Send(mail);
            }
            catch (Exception ex)
            {
                if (attempts < 6)
                    SendMail(body);
                else
                    new Log("Error sending e-mail to " + address + ".");
            }
        }
    }
}
