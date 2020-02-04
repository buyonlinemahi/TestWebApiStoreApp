using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using OnlineStore.Infrastructure.ApplicationServices.Contracts;

namespace OnlineStore.Infrastructure.ApplicationServices
{
  public class EncryptionService:IEncryption
    {
        string _key = "qwertyuiopasdfghjklzxcvbnm1234567890";
        public string EncryptString(string encryptString)
        {
            string concatenateEncryptString = encryptString;
            TripleDESCryptoServiceProvider objDESCrypto = new TripleDESCryptoServiceProvider();
            MD5CryptoServiceProvider objHashMD5 = new MD5CryptoServiceProvider();
            byte[] byteHash, byteBuff;
            string strTempKey = _key;
            byteHash = objHashMD5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(strTempKey));
            objHashMD5 = null;
            objDESCrypto.Key = byteHash;
            objDESCrypto.Mode = CipherMode.ECB; //CBC, CFB
            byteBuff = ASCIIEncoding.ASCII.GetBytes(concatenateEncryptString);
            return Convert.ToBase64String(objDESCrypto.CreateEncryptor().
            TransformFinalBlock(byteBuff, 0, byteBuff.Length)).Replace("/", "!").Replace("+", "]");
        }

        public string DecryptString(string cipherText)
        {
            cipherText = cipherText.Replace("!", "/").Replace("]", "+");
            TripleDESCryptoServiceProvider objDESCrypto = new TripleDESCryptoServiceProvider();
            MD5CryptoServiceProvider objHashMD5 = new MD5CryptoServiceProvider();
            byte[] byteHash, byteBuff;
            string strTempKey = _key;
            byteHash = objHashMD5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(strTempKey));
            objHashMD5 = null;
            objDESCrypto.Key = byteHash;
            objDESCrypto.Mode = CipherMode.ECB; //CBC, CFB
            byteBuff = Convert.FromBase64String(cipherText);
            string strDecrypted = ASCIIEncoding.ASCII.GetString
            (objDESCrypto.CreateDecryptor().TransformFinalBlock
            (byteBuff, 0, byteBuff.Length));
            objDESCrypto = null;
            return strDecrypted;

        }
    }
}
