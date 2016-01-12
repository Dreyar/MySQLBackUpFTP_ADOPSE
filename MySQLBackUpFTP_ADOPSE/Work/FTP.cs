using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using WinSCP;
using System.ComponentModel;
using System.Collections;
using System.Text.RegularExpressions;

namespace MySQLBackUpFTP_ADOPSE.Work
{
    [Serializable]
    class FTP
    {
        public const byte FTP_PROTOCOL = 0;
        public const byte SCP_PROTOCOL = 1;
        public const byte SFTP_PROTOCOL = 2;
        public const byte FTPS_PROTOCOL_EXP = 3;
        public const byte FTPS_PROTOCOL_IMP = 4;
        public const byte WEBDAV_PROTOCOL = 5;
        public const byte WEBDAVSECURE_PROTOCOL = 6;

        private string host;
        private short port;
        private byte protocol;
        private string fingerprint;
        private string username;
        private string password;
        private static SessionOptions sessionOptions;
        [field: NonSerialized]
        private byte sendAttempts = 0;
        [field: NonSerialized]
        private byte deleteAttempts = 0;

        public FTP() { }

        public FTP(string host, short port, byte protocol, string fingerprint,string username,string password)
        {
            this.host = host;
            this.port = port;
            this.protocol = protocol;
            this.fingerprint = fingerprint;
            this.username = username;
            this.password = password;
            sessionOptions = new SessionOptions();
            try
            {
                switch (protocol)
                {
                    case FTP_PROTOCOL:
                        sessionOptions.Protocol = Protocol.Ftp;
                        break;
                    case SCP_PROTOCOL:
                        {
                            sessionOptions.Protocol = Protocol.Scp;
                            if (fingerprint.Equals(""))
                                sessionOptions.GiveUpSecurityAndAcceptAnySshHostKey = true;
                            else
                                sessionOptions.SshHostKeyFingerprint = fingerprint;
                            break;
                        }
                    case SFTP_PROTOCOL:
                        {
                            sessionOptions.Protocol = Protocol.Sftp;
                            if (fingerprint.Equals(""))
                                sessionOptions.GiveUpSecurityAndAcceptAnySshHostKey = true;
                            else
                                sessionOptions.SshHostKeyFingerprint = fingerprint;
                            break;
                        }
                    case FTPS_PROTOCOL_EXP:
                        {
                            sessionOptions.Protocol = Protocol.Ftp;
                            sessionOptions.FtpSecure = FtpSecure.Explicit;
                            if (fingerprint.Equals(""))
                                sessionOptions.GiveUpSecurityAndAcceptAnyTlsHostCertificate = true;
                            else
                                sessionOptions.TlsHostCertificateFingerprint = fingerprint;
                            break;
                        }
                    case FTPS_PROTOCOL_IMP:
                        {
                            sessionOptions.Protocol = Protocol.Ftp;
                            sessionOptions.FtpSecure = FtpSecure.Implicit;
                            if (fingerprint.Equals(""))
                                sessionOptions.GiveUpSecurityAndAcceptAnyTlsHostCertificate = true;
                            else
                                sessionOptions.TlsHostCertificateFingerprint = fingerprint;
                            break;
                        }
                    case WEBDAV_PROTOCOL:
                        sessionOptions.Protocol = Protocol.Webdav;
                        break;
                    case WEBDAVSECURE_PROTOCOL:
                        {
                            sessionOptions.Protocol = Protocol.Webdav;
                            sessionOptions.WebdavSecure = true;
                            if (fingerprint.Equals(""))
                                sessionOptions.GiveUpSecurityAndAcceptAnyTlsHostCertificate = true;
                            else
                                sessionOptions.TlsHostCertificateFingerprint = fingerprint;
                            break;
                        }
                }
            }
            catch (Exception)
            {
                sessionOptions.Protocol = Protocol.Ftp;
            }
            sessionOptions.HostName = host;
            sessionOptions.PortNumber = port;
            sessionOptions.UserName = username;
            sessionOptions.Password = password;
        }

        public string GetHost()
        {
            return host;
        }

        public short GetPort()
        {
            return port;
        }

        public byte GetProtocol()
        {
            return protocol;
        }

        public string GetFingerprint()
        {
            return fingerprint;
        }

        public string GetUsername()
        {
            return username;
        }

        public string GetPassword()
        {
            return password;
        }

        public void Transmission(Database db,EmailNotifications emailSettings)
        {
            if (MySQLBackUpFTP_ADOPSE.Properties.Settings.Default.sendBackup)
            {
                DoTransmission(db,emailSettings);
            }
        }

        private void DoTransmission(Database db,EmailNotifications emailSettings)
        {
            sendAttempts++;
           new Log("FTP transmission for \"" + db.GetAlias() + "\" started.");
            try
            {
                using (Session session = new Session())
                {
                    session.Open(sessionOptions);
                    TransferOptions transferOptions = new TransferOptions();
                    transferOptions.TransferMode = TransferMode.Binary;
                    TransferOperationResult transferResult;
                    transferResult = session.PutFiles(db.GetFile(), "DB_" + db.GetAlias() + "_bu" + DateTime.Now.ToString("yyyyMMddHHmm") + ".sql", false, transferOptions);
                    transferResult.Check();
                    new Log("FTP transmission for \"" + db.GetAlias() + "\" completed successfully.");
                    session.Close();
                    emailSettings.NotifyCheck(db.GetAlias(),EmailNotifications.FTP_OPERATION_OK);
                }
            }
            catch (Exception ex)
            {
                if (sendAttempts < 6)
                    DoTransmission(db,emailSettings);
                else
                {
                    new Log("ERROR: FTP transmission for \"" + db.GetAlias() + "\" failed.");
                    emailSettings.NotifyCheck(db.GetAlias(), EmailNotifications.FTP_OPERATION_FAIL);
                }
            }
        }

        public void DeleteOld(Database db)
        {
            if (MySQLBackUpFTP_ADOPSE.Properties.Settings.Default.deleteOld && MySQLBackUpFTP_ADOPSE.Properties.Settings.Default.keepOnFTP > 0 && MySQLBackUpFTP_ADOPSE.Properties.Settings.Default.sendBackup)
            {
                deleteAttempts++;
                try
                {
                    using (Session session = new Session())
                    {
                        session.Open(sessionOptions);
                        ArrayList files = new ArrayList();
                        RemoteDirectoryInfo directory = session.ListDirectory(session.HomePath);
                        Regex regex = new Regex("^DB_"+db.GetAlias()+@"_bu............\.sql$");
                        for (int i = 0; i < directory.Files.Count; i++)
                        {
                            Match match = regex.Match(directory.Files[i].Name);
                            if (match.Success)
                                files.Add(directory.Files[i].Name);
                        }
                        files.Sort();
                        for (int i = 0; i < files.Count - MySQLBackUpFTP_ADOPSE.Properties.Settings.Default.keepOnFTP; i++)
                            session.RemoveFiles((string)files[i]);
                    }
                }
                catch (Exception)
                {
                    if (deleteAttempts < 4)
                        DeleteOld(db);
                    else
                        new Log("Error trying to delete backup file(s) from the FTP server.");
                }
            }
        }

        public delegate void ConnectionOK();
        [field: NonSerialized]
        public event ConnectionOK RaiseConnectionOK;

        public delegate void ConnectionFAILED();
        [field: NonSerialized]
        public event ConnectionFAILED RaiseConnectionFAILED;

        public void TestConnection()
        {
            BackgroundWorker bgw = new BackgroundWorker();
            bgw.DoWork += new DoWorkEventHandler(DoTestConnection);
            bgw.RunWorkerAsync();
        }

        private void DoTestConnection(object sender, DoWorkEventArgs e)
        {
            try
            {
                using (Session session = new Session())
                {
                    session.Open(sessionOptions);
                    session.Close();
                }
                RaiseConnectionOK();
            }
            catch (Exception ex)
            {
                RaiseConnectionFAILED();
            }
        }
    }
}
