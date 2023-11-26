using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace APINetFramework.Helper
{
    public class CryptingManager
    {
        #region AES


        public string EncryptAes(string data, string password)
        {
            string returnValue = string.Empty;

            try
            {
                byte[] bytes = Encoding.UTF8.GetBytes(data);
                byte[] passwordBytes = Encoding.UTF8.GetBytes(password);
                int passwordShiftIndex = 0;
                for (int i = 0; i < bytes.Length; i++)
                {
                    bytes[i] = (byte)(bytes[i] + passwordBytes[passwordShiftIndex]);
                    passwordShiftIndex = (passwordShiftIndex + 1) % passwordBytes.Length;
                }
                returnValue = Convert.ToBase64String(bytes);
            }
            catch
            {
                returnValue = data;
            }

            return returnValue;
        }

        public string DecryptAes(string data, string password)
        {
            string returnValue = string.Empty;

            try
            {
                byte[] bytes = Convert.FromBase64String(data);
                byte[] passwordBytes = Encoding.UTF8.GetBytes(password);
                int passwordShiftIndex = 0;
                for (int i = 0; i < bytes.Length; i++)
                {
                    bytes[i] = (byte)(bytes[i] - passwordBytes[passwordShiftIndex]);
                    passwordShiftIndex = (passwordShiftIndex + 1) % passwordBytes.Length;
                }
                returnValue = Encoding.UTF8.GetString(bytes, 0, bytes.Length);
            }
            catch
            {
                returnValue = data;
            }

            return returnValue;
        }
        #endregion

        #region MD5
        public string MD5Hash(string text)
        {
            return MD5Hash(ASCIIEncoding.ASCII.GetBytes(text));
        }

        public string MD5Hash(byte[] bytes)
        {
            MD5 md5 = new MD5CryptoServiceProvider();

            //compute hash from the bytes of text
            md5.ComputeHash(bytes);

            //get hash result after compute it
            byte[] result = md5.Hash;

            StringBuilder strBuilder = new StringBuilder();
            for (int i = 0; i < result.Length; i++)
            {
                //change it into 2 hexadecimal digits
                //for each byte
                strBuilder.Append(result[i].ToString("x2"));
            }

            return strBuilder.ToString();
        }

        #endregion

        #region Password

        public bool CheckPassword(string password, string hash)
        {
            string[] arrayhash = hash.Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries);
            if (arrayhash.Length == 1)
                return MD5Hash(password) == hash;
            else if (arrayhash.Length == 2)
                return MD5Hash(arrayhash[1] + password) == arrayhash[0];
            else
                return false;
        }


        public string GetRandomString(int length)
        {
            string charsToUse = "ABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";

            char[] chars = charsToUse.ToCharArray();
            int size = length;

            byte[] data = new byte[1];
            RNGCryptoServiceProvider crypto = new RNGCryptoServiceProvider();
            crypto.GetNonZeroBytes(data);
            size = length;

            data = new byte[size];
            crypto.GetNonZeroBytes(data);

            StringBuilder result = new StringBuilder(size);

            foreach (byte b in data)
            {
                result.Append(chars[b % (chars.Length - 1)]);
            }

            return result.ToString();
        }

        public string GetRandomStringNumbersOnly(int length)
        {
            string charsToUse = "1234567890";

            char[] chars = charsToUse.ToCharArray();
            int size = length;

            byte[] data = new byte[1];
            RNGCryptoServiceProvider crypto = new RNGCryptoServiceProvider();
            crypto.GetNonZeroBytes(data);
            size = length;

            data = new byte[size];
            crypto.GetNonZeroBytes(data);

            StringBuilder result = new StringBuilder(size);

            foreach (byte b in data)
            {
                result.Append(chars[b % (chars.Length - 1)]);
            }

            return result.ToString();
        }

        #endregion

        #region SHA256
        public string EncryptSHA256Managed(string input)
        {
            HashAlgorithm algorithm = new SHA256CryptoServiceProvider();
            byte[] inputBytes = Encoding.UTF8.GetBytes(input);
            byte[] hashedBytes = algorithm.ComputeHash(inputBytes);

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < hashedBytes.Length; i++)
            {
                sb.Append(string.Format("{0:x2}", hashedBytes[i]));
            }
            return sb.ToString();
        }

        #endregion

        #region Rijndael




        public string DecryptRijndael(string text, byte[] publicRijndaelKey, byte[] privateRijndaelKey)
        {
            try
            {
                byte[] newClearData = null;

                using (RijndaelManaged _cipher = new RijndaelManaged() { Padding = PaddingMode.PKCS7, Mode = CipherMode.CBC, KeySize = 128, IV = publicRijndaelKey, Key = privateRijndaelKey })
                {
                    using (ICryptoTransform Decryptor = _cipher.CreateDecryptor(publicRijndaelKey, privateRijndaelKey))
                    {
                        byte[] input = Convert.FromBase64String(text);
                        newClearData = Decryptor.TransformFinalBlock(input, 0, input.Length);
                    }
                    return Encoding.ASCII.GetString(newClearData);
                }
            }
            catch
            {
                return text;
            }

        }

        public string EncryptRijndael(string text, byte[] publicRijndaelKey, byte[] privateRijndaelKey)
        {
            try
            {
                using (RijndaelManaged _cipher = new RijndaelManaged() { Padding = PaddingMode.PKCS7, Mode = CipherMode.CBC, KeySize = 128, IV = publicRijndaelKey, Key = privateRijndaelKey })
                {
                    using (ICryptoTransform Encryptor = _cipher.CreateEncryptor(publicRijndaelKey, privateRijndaelKey))
                    {
                        byte[] buffer = Encoding.UTF8.GetBytes(text);
                        return Convert.ToBase64String(Encryptor.TransformFinalBlock(buffer, 0, buffer.Length));
                    }
                }
            }
            catch
            {
                return text;
            }
        }

        public string EncryptRijndaelExternalSource(string text, byte[] publicRijndaelKey, byte[] privateRijndaelKey)
        {
            RijndaelManaged rijn = new RijndaelManaged
            {
                Mode = CipherMode.CBC,
                Padding = PaddingMode.Zeros,
                BlockSize = 128
            };

            using (MemoryStream msEncrypt = new MemoryStream())
            {
                using (ICryptoTransform encryptor = rijn.CreateEncryptor(publicRijndaelKey, privateRijndaelKey))
                {
                    byte[] buffer = Encoding.UTF8.GetBytes(text);
                    return Convert.ToBase64String(encryptor.TransformFinalBlock(buffer, 0, buffer.Length));
                }
            }
        }

        public string DecryptRijndaelExternalSource(string text, byte[] publicRijndaelKey, byte[] privateRijndaelKey)
        {
            string result;
            RijndaelManaged rijn = new RijndaelManaged
            {
                Mode = CipherMode.CBC,
                Padding = PaddingMode.Zeros,
                BlockSize = 128
            };

            byte[] newClearData = null;

            using (ICryptoTransform decryptor = rijn.CreateDecryptor(publicRijndaelKey, privateRijndaelKey))
            {
                byte[] input = Convert.FromBase64String(text);
                newClearData = decryptor.TransformFinalBlock(input, 0, input.Length);
            }

            result = Encoding.ASCII.GetString(newClearData);

            return result.Replace("\0", "");
        }






        #endregion

        #region DESCryptoServiceProvider

        public string DESCryptoServiceProviderDecrypt(string stringToDecrypt, byte[] intKeyDESCryptoServiceProvider, byte[] IVDESCryptoServiceProvider)
        {
            int sLen = stringToDecrypt.Length;
            byte[] inputByteArray = new byte[stringToDecrypt.Length + 1];
            try
            {
                byte[] keyDESCryptoServiceProvider = System.Text.Encoding.UTF8.GetBytes(intKeyDESCryptoServiceProvider.ToString().Substring(0, 8));
                DESCryptoServiceProvider des = new DESCryptoServiceProvider();
                inputByteArray = Convert.FromBase64String(stringToDecrypt);
                MemoryStream ms = new MemoryStream();
                CryptoStream cs = new CryptoStream(ms, des.CreateDecryptor(keyDESCryptoServiceProvider, IVDESCryptoServiceProvider), CryptoStreamMode.Write);
                cs.Write(inputByteArray, 0, inputByteArray.Length);
                cs.FlushFinalBlock();
                Encoding encoding = System.Text.Encoding.UTF8;
                return encoding.GetString(ms.ToArray());
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        public string DESCryptoServiceProviderEncrypt(string stringToEncrypt, byte[] intKeyDESCryptoServiceProvider, byte[] IVDESCryptoServiceProvider)
        {
            try
            {
                byte[] keyDESCryptoServiceProvider = System.Text.Encoding.UTF8.GetBytes(intKeyDESCryptoServiceProvider.ToString().Substring(0, 8));
                DESCryptoServiceProvider des = new DESCryptoServiceProvider();
                byte[] inputByteArray = Encoding.UTF8.GetBytes(stringToEncrypt);
                MemoryStream ms = new MemoryStream();
                CryptoStream cs = new CryptoStream(ms, des.CreateEncryptor(keyDESCryptoServiceProvider, IVDESCryptoServiceProvider), CryptoStreamMode.Write);
                cs.Write(inputByteArray, 0, inputByteArray.Length);
                cs.FlushFinalBlock();
                return Convert.ToBase64String(ms.ToArray());
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        #endregion

    }
}