using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Collections;

namespace MySQLBackUpFTP_ADOPSE.Work
{
    class BinarySerialization
    {
        public static readonly string DATABASES_ARRAYLIST = "databases.bin";
        public static readonly string FTP_SETTINGS = "ftp.bin";
        public static readonly string CRYPTOGRAPHY_SETTINGS = "cryptography.bin";
        public static readonly string EMAIL_SETTINGS = "email.bin";
        private static readonly string BINS_PASSWORD = "efyRAjiM=4p@l";

        public static void EncryptBin(string file)
        {
            Cryptography cr = new Cryptography(Cryptography.ENCRYPT,BINS_PASSWORD,file,Cryptography.KEY_128);
            cr.ForceCryptography();
        }

        public static void DecryptBin(string file)
        {
            Cryptography cr = new Cryptography(Cryptography.DECRYPT, BINS_PASSWORD, file, Cryptography.KEY_128);
            cr.ForceCryptography();
        }

        public static void Serialize(ArrayList al,string file)
        {
            try
            {
                IFormatter formatter = new BinaryFormatter();
                Stream stream = new FileStream(file, FileMode.Create, FileAccess.Write, FileShare.None);
                formatter.Serialize(stream,al);
                stream.Close();
                EncryptBin(file);
            }
            catch (Exception ex)
            {
                new Error("Cannot write to \"" + file + "\". Please check write permissions.");
            }
        }

        public static void Serialize(FTP ftp, string file)
        {
            try
            {
                IFormatter formatter = new BinaryFormatter();
                Stream stream = new FileStream(file, FileMode.Create, FileAccess.Write, FileShare.None);
                formatter.Serialize(stream, ftp);
                stream.Close();
                EncryptBin(file);
            }
            catch (Exception ex)
            {
                new Error("Cannot write to \"" + file + "\". Please check write permissions.");
            }
        }

        public static void Serialize(Cryptography cr, string file)
        {
            try
            {
                IFormatter formatter = new BinaryFormatter();
                Stream stream = new FileStream(file, FileMode.Create, FileAccess.Write, FileShare.None);
                formatter.Serialize(stream, cr);
                stream.Close();
                EncryptBin(file);
            }
            catch (Exception ex)
            {
                new Error("Cannot write to \"" + file + "\". Please check write permissions.");
            }
        }

        public static void Serialize(EmailNotifications email, string file)
        {
            try
            {
                IFormatter formatter = new BinaryFormatter();
                Stream stream = new FileStream(file, FileMode.Create, FileAccess.Write, FileShare.None);
                formatter.Serialize(stream, email);
                stream.Close();
                EncryptBin(file);
            }
            catch (Exception ex)
            {
                new Error("Cannot write to \"" + file + "\". Please check write permissions.");
            }
        }

        public static ArrayList DeserializeArrayList(string file)
        {
            try
            {
                DecryptBin(file);
                IFormatter formatter = new BinaryFormatter();
                Stream stream = new FileStream(file, FileMode.Open, FileAccess.Read, FileShare.Read);
                ArrayList al = (ArrayList)formatter.Deserialize(stream);
                stream.Close();
                EncryptBin(file);
                return al;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public static FTP DeserializeFTP(string file)
        {
            try
            {
                DecryptBin(file);
                IFormatter formatter = new BinaryFormatter();
                Stream stream = new FileStream(file, FileMode.Open, FileAccess.Read, FileShare.Read);
                FTP ftp = (FTP)formatter.Deserialize(stream);
                stream.Close();
                EncryptBin(file);
                return ftp;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public static Cryptography DeserializeCryptography(string file)
        {
            try
            {
                DecryptBin(file);
                IFormatter formatter = new BinaryFormatter();
                Stream stream = new FileStream(file, FileMode.Open, FileAccess.Read, FileShare.Read);
                Cryptography cr = (Cryptography)formatter.Deserialize(stream);
                stream.Close();
                EncryptBin(file);
                return cr;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public static EmailNotifications DeserializeEmailNotifications(string file)
        {
            try
            {
                DecryptBin(file);
                IFormatter formatter = new BinaryFormatter();
                Stream stream = new FileStream(file, FileMode.Open, FileAccess.Read, FileShare.Read);
                EmailNotifications email = (EmailNotifications)formatter.Deserialize(stream);
                stream.Close();
                EncryptBin(file);
                return email;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
