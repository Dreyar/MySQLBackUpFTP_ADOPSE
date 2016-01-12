using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;
using System.Threading;
using System.ComponentModel;

namespace MySQLBackUpFTP_ADOPSE.Work
{
    [Serializable]
    sealed class Cryptography
    {
        public const byte ENCRYPT=0;
        public const byte DECRYPT=1;
        public const byte KEY_128 = 0;
        public const byte KEY_192 = 1;
        public const byte KEY_256 = 2;

        [field:NonSerialized]
        private byte mode;
        private string password="";
        [field: NonSerialized]
        private string file;
        private byte keysize = 0;
        [field: NonSerialized]
        private byte attempts=0;

        public Cryptography() { }

        public Cryptography(string password, byte keysize)
        {
            this.password = password;
            this.keysize = keysize;
        }

        public Cryptography(byte mode, string password, string file, byte keysize)
        {
            this.mode = mode;
            this.password = password;
            this.file = file;
            this.keysize = keysize;
        }

        public void SetFile(string file){
            this.file=file;
        }

        public byte GetKeySize()
        {
            return keysize;
        }

        public string GetPassword()
        {
            return password;
        }

        public void SetMode(byte mode)
        {
            this.mode=mode;
        }

        public delegate void FinishedDecryption();
        [field: NonSerialized]
        public event FinishedDecryption RaiseFinishedDecryption;

        public void DoCryptography()
        {
            if (MySQLBackUpFTP_ADOPSE.Properties.Settings.Default.encryptFiles)
            {
                attempts = 0;
                switch (mode)
                {
                    case ENCRYPT:
                        EncryptFile();
                        break;
                    case DECRYPT:
                        {
                            BackgroundWorker bgw = new BackgroundWorker();
                            bgw.DoWork += new DoWorkEventHandler(DecryptFile);
                            bgw.RunWorkerAsync();
                            break;
                        }
                }
            }
        }

        public void ForceCryptography()
        {
            switch (mode)
            {
                case ENCRYPT:
                    EncryptFile();
                    break;
                case DECRYPT:
                    DecryptFile();
                    break;
            }
        }

        private byte[] AES_Encrypt(byte[] bytesToBeEncrypted, byte[] passwordBytes)
        {
            byte[] encryptedBytes = null;
            byte[] saltBytes = new byte[] {6,0,9,4,5,8,2,1};
            using (MemoryStream ms = new MemoryStream())
            {
                using (RijndaelManaged AES = new RijndaelManaged())
                {
                    switch (keysize)
                    {
                        case KEY_128:
                            AES.KeySize = 128;
                            break;
                        case KEY_192:
                            AES.KeySize = 192;
                            break;
                        case KEY_256:
                            AES.KeySize = 256;
                            break;
                    }
                    AES.BlockSize = 128;
                    var key = new Rfc2898DeriveBytes(passwordBytes, saltBytes, 1000);
                    AES.Key = key.GetBytes(AES.KeySize / 8);
                    AES.IV = key.GetBytes(AES.BlockSize / 8);
                    AES.Mode = CipherMode.CBC;
                    using (var cs = new CryptoStream(ms, AES.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(bytesToBeEncrypted, 0, bytesToBeEncrypted.Length);
                        cs.Close();
                    }
                    encryptedBytes = ms.ToArray();
                }
            }
            return encryptedBytes;
        }

        private byte[] AES_Decrypt(byte[] bytesToBeDecrypted, byte[] passwordBytes)
        {
            byte[] decryptedBytes = null;
            byte[] saltBytes = new byte[] { 6, 0, 9, 4, 5, 8, 2, 1 };
            using (MemoryStream ms = new MemoryStream())
            {
                using (RijndaelManaged AES = new RijndaelManaged())
                {
                    switch (keysize)
                    {
                        case KEY_128:
                            AES.KeySize = 128;
                            break;
                        case KEY_192:
                            AES.KeySize = 192;
                            break;
                        case KEY_256:
                            AES.KeySize = 256;
                            break;
                    }
                    AES.BlockSize = 128;
                    var key = new Rfc2898DeriveBytes(passwordBytes, saltBytes, 1000);
                    AES.Key = key.GetBytes(AES.KeySize / 8);
                    AES.IV = key.GetBytes(AES.BlockSize / 8);

                    AES.Mode = CipherMode.CBC;

                    using (var cs = new CryptoStream(ms, AES.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(bytesToBeDecrypted, 0, bytesToBeDecrypted.Length);
                        cs.Close();
                    }
                    decryptedBytes = ms.ToArray();
                }
            }
            return decryptedBytes;
        }

        private void EncryptFile()
        {
            attempts++;
            try
            {
                byte[] bytesToBeEncrypted = File.ReadAllBytes(file);
                byte[] passwordBytes = Encoding.UTF8.GetBytes(password);
                passwordBytes = SHA256.Create().ComputeHash(passwordBytes);
                byte[] bytesEncrypted = AES_Encrypt(bytesToBeEncrypted, passwordBytes);
                File.WriteAllBytes(file, bytesEncrypted);
            }
            catch (Exception ex) 
            {
                if (attempts < 7)
                    EncryptFile();
            }
        }

        private void DecryptFile(object sender,DoWorkEventArgs e)
        {
            try
            {
                byte[] bytesToBeDecrypted = File.ReadAllBytes(file);
                byte[] passwordBytes = Encoding.UTF8.GetBytes(password);
                passwordBytes = SHA256.Create().ComputeHash(passwordBytes);
                byte[] bytesDecrypted = AES_Decrypt(bytesToBeDecrypted, passwordBytes);
                File.WriteAllBytes(file, bytesDecrypted);
            }
            catch (Exception ex) { }
            try
            {
                RaiseFinishedDecryption();
            }
            catch (Exception ex) 
            {
            }
        }

        private void DecryptFile()
        {
            try
            {
                byte[] bytesToBeDecrypted = File.ReadAllBytes(file);
                byte[] passwordBytes = Encoding.UTF8.GetBytes(password);
                passwordBytes = SHA256.Create().ComputeHash(passwordBytes);
                byte[] bytesDecrypted = AES_Decrypt(bytesToBeDecrypted, passwordBytes);
                File.WriteAllBytes(file, bytesDecrypted);
            }
            catch (Exception ex) 
            {
            }
        }
    }
}
